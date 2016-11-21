using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.Abm_Profesional;
using System.Data.SqlClient;
using ClinicaFrba.util;
using ClinicaFrba.Pedir_Turno;
using ClinicaFrba.Abm_Especialidades_Medicas;

namespace ClinicaFrba.Agenda_Medico
{
    public partial class Agendas : Form
    {
        private int dni;
        private bool initialized = false;
        public Agendas(int dni)
        {
            this.dni = dni;
            InitializeComponent();
        }

        private void Agendas_Load(object sender, EventArgs e)
        {
            DataTable professional = Professional.getProfessionalByDni(this.dni);
            labelProfesional.Text = professional.Rows[0]["nombre"].ToString() + " " + professional.Rows[0]["apellido"].ToString();
            loadEspecialidades();
            this.initialized = true;
        }

        private void loadAgendas(int especialidad)
        {
            if (!this.initialized) return;
            DataTable timetables = Timetable.getTimetablesByEspecialidadAndProfesional(this.dni, especialidad);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = timetables;

            timetablesGrid.DataSource = bindingSource;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Update(timetables);

            timetablesGrid.Columns[0].Visible = false;
        }




        private void loadCanceledPeriods(int professionCode)
        {

            DataTable periods = Timetable.getCanceledPeriods(this.dni, professionCode, this.from.Value, this.to.Value);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = periods;

            periodGrid.DataSource = bindingSource;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Update(periods);

        }



        private void loadEspecialidades()
        {
            DataTable especialidades = Profession.getByDni(this.dni);
            
            List<String> options = new List<string>();
            for (int i = 0; i < especialidades.Rows.Count; i++)
            {
                options.Add(especialidades.Rows[i][0].ToString());
            }
            especialidadesCombo.DataSource = options;
        }

        private void loadTourns(int professionCode)
        {

            DataTable tourns = Turno.conseguirPorProfesional(this.dni, professionCode, this.from.Value, this.to.Value);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tourns;

            tournsGrid.DataSource = bindingSource;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Update(tourns);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String accion = timetablesGrid.Columns[e.ColumnIndex].HeaderText.ToString();
            if (e.RowIndex >= timetablesGrid.Rows.Count) return;
            int professionCode = Int32.Parse(timetablesGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
            int agendaId = Int32.Parse(timetablesGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            
            if (accion == "Ver")
            {
                this.Hide();
                Agenda agenda = new Agenda(this.dni, professionCode, agendaId);
                agenda.Show();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Session.mainMenu(this);
        }

        private void especialidadesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshView(true);
        }

        private void from_ValueChanged(object sender, EventArgs e)
        {
            refreshView(false);    
        }

        private void refreshView(bool refreshAgendas)
        {
            int professionCode = Profession.getCodeByDescription(especialidadesCombo.Text);
            loadTourns(professionCode);
            loadCanceledPeriods(professionCode);

            if (refreshAgendas)
            {
                loadAgendas(professionCode);
            }
        }

        private void to_ValueChanged(object sender, EventArgs e)
        {
            refreshView(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltaHorarios edit = new AltaHorarios(this.dni);
            edit.Show();
        }
    }
}
