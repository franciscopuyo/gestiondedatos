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
using ClinicaFrba.Abm_Especialidades_Medicas;
using ClinicaFrba.util;
using ClinicaFrba.Pedir_Turno;
using System.Data.SqlClient;

namespace ClinicaFrba.Agenda_Medico
{
    public partial class Agenda : Form
    {
        private int dni;
        private int professionCode;
        public Agenda(int professionCode, int dni)
        {
            this.professionCode = professionCode;
            this.dni = dni;

            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            DataTable professional = Professional.getProfessionalByDni(this.dni);
            DataTable profession = Profession.getProfessionByCode(this.professionCode);

            labelProfesional.Text = professional.Rows[0]["nombre"].ToString() + " " + professional.Rows[0]["apellido"].ToString();
            labelEspecialidad.Text = profession.Rows[0]["descripcion"].ToString();

            DataTable timetable = Timetable.getTimetable(this.professionCode, this.dni);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = timetable;

            timetableGrid.DataSource = bindingSource;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Update(timetable);

            loadTourns();
            loadCanceledPeriods();
        }

        private void loadTourns()
        {

            DataTable tourns = Turno.conseguirPorProfesional(this.dni, this.professionCode, this.from.Value, this.to.Value);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tourns;

            tournsGrid.DataSource = bindingSource;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Update(tourns);
        }

        private void loadCanceledPeriods()
        {

            DataTable periods = Timetable.getCanceledPeriods(this.dni, this.professionCode, this.from.Value, this.to.Value);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = periods;

            periodGrid.DataSource = bindingSource;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Update(periods);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void labelProfesional_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agendas timetables = new Agendas(this.dni);
            timetables.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CancelarPeriodo cancelarPeriodo = new CancelarPeriodo(dni, professionCode);
            cancelarPeriodo.Show();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void labelEspecialidad_Click(object sender, EventArgs e)
        {

        }

        private void from_ValueChanged(object sender, EventArgs e)
        {
            loadTourns();
            loadCanceledPeriods();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            loadTourns();
            loadCanceledPeriods();
        }

        private void timetableGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
