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
using ClinicaFrba.util;

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
            titulo.Text = "Asignando turno con " + nombre.ToUpper() + " " + apellido.ToUpper();

            int dni = Int32.Parse(this.dni);
            
            DataTable timetable = Timetable.getTimetable(Int32.Parse(codigoEspecialidad), dni);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = timetable;

            timetableGrid.DataSource = bindingSource;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Update(timetable);

            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        }

        private void volver_Click(object sender, EventArgs e)
        {
            Session.mainMenu(this);
        }

        private void save_Click(object sender, EventArgs e)
        {
            DateTime horarioTurno = dateTimePicker1.Value;
            bool cumpleHorario = Turno.cumpleHorarioMedico(dni, codigoEspecialidad, horarioTurno);
            bool esSobreturno = Turno.esSobreturno(dni, codigoEspecialidad, horarioTurno);

            if (cumpleHorario && !esSobreturno) 
            {
                Turno.crear(Session.dni, dni, codigoEspecialidad, horarioTurno);
                MessageBox.Show("El turno fue asignado"); ;
                Session.mainMenu(this);
                return;
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
    }
}
