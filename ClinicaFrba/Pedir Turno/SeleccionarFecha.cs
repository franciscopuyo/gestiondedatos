using ClinicaFrba.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.Abm_Profesional;
using ClinicaFrba.Abm_Especialidades_Medicas;
using ClinicaFrba.Agenda_Medico;
using ClinicaFrba.Abm_Afiliado;

namespace ClinicaFrba.Pedir_Turno
{
    public partial class SeleccionarFecha : Form
    {
        private string nombre;
        private string apellido;
        private string dni;
        private string especialidadDescripcion;
        private string codigoEspecialidad;

        public SeleccionarFecha(string nombre, string apellido, string dni, string especialidadDescripcion)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.especialidadDescripcion = especialidadDescripcion;
            this.codigoEspecialidad = Profession.getCodeByDescription(this.especialidadDescripcion).ToString();
        }

        private void SeleccionarFecha_Load(object sender, EventArgs e)
        {
            if (Session.isAfiliado())
            {
                labelAfiliado.Hide();
                nroAfiliado.Hide();
            }
            titulo.Text = "Asignando turno con " + nombre.ToUpper() + " " + apellido.ToUpper();

            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.loadAgendas();
        }

        private void loadHorarios(int agendaId)
        {

            int dni = Int32.Parse(this.dni);
            DataTable timetable = Timetable.getTimetableByAgenda(agendaId);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = timetable;

            timetableGrid.DataSource = bindingSource;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Update(timetable);
        }

        private void loadAgendas()
        {
            int especialidadCodigo = Profession.getCodeByDescription(this.especialidadDescripcion);
            DataTable timetables = Timetable.getTimetablesByEspecialidadAndProfesional(Int32.Parse(this.dni), especialidadCodigo);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = timetables;

            timetablesGrid.DataSource = bindingSource;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Update(timetables);

            timetablesGrid.Columns[0].Visible = false;
        }

        private void volver_Click(object sender, EventArgs e)
        {
            Session.mainMenu(this);
        }

        private Boolean validateAfiliado()
        {
            Boolean valid = true;
            Validations.validateIntWithMaxLength(nroAfiliado, errorProviderAfiliado, "Nro de afiliado vacio o invalido", 10, ref valid);
            valid = Validations.isOnlyNumeric(nroAfiliado.Text);

            if (!valid)
            {
                return false;
            }


            Boolean existeAfiliado = Afiliado.nroAfiliadoExiste(nroAfiliado.Text);
            if (!existeAfiliado)
            {
                errorProviderAfiliado.SetError(nroAfiliado, "El afiliado ingresado no existe");
                return false;
            }
            return true;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!Session.isAfiliado() && !this.validateAfiliado())
                return;

            DateTime horarioTurno = dateTimePicker1.Value.AddSeconds(-dateTimePicker1.Value.Second);

            bool cumpleHorario = Turno.cumpleHorarioMedico(dni, codigoEspecialidad, horarioTurno);
            bool esSobreturno = Turno.esSobreturno(dni, codigoEspecialidad, horarioTurno);
            bool franjaCancelada = Turno.hayCancelacion(dni, codigoEspecialidad, horarioTurno);

            int dniAfiliado = Session.isAfiliado() ? Session.dni : Int32.Parse(nroAfiliado.Text.Substring(0, nroAfiliado.Text.Length-2));
            if (cumpleHorario && !esSobreturno && !franjaCancelada) 
            {
                Turno.crear(dniAfiliado, dni, codigoEspecialidad, horarioTurno);
                MessageBox.Show("El turno fue asignado"); ;
                Session.mainMenu(this);
                return;
            }

            if (franjaCancelada)
            {
                MessageBox.Show("El medico cancelo una franja horaria en ese horario");
            }

                if (!cumpleHorario)
            {
                MessageBox.Show("El medico no atiende a esa hora");
                return;
            }

            if (esSobreturno)
            {
                MessageBox.Show("El medico ya tiene un turno asignado a esa hora");
                return;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timetablesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String accion = timetablesGrid.Columns[e.ColumnIndex].HeaderText.ToString();
            if (e.RowIndex >= timetablesGrid.Rows.Count) return;
            int professionCode = Int32.Parse(timetablesGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
            int agendaId = Int32.Parse(timetablesGrid.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (accion == "Ver")
            {
                loadHorarios(agendaId);
            }
        }
    }
}
