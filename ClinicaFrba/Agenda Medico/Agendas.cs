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

namespace ClinicaFrba.Agenda_Medico
{
    public partial class Agendas : Form
    {
        private int dni;
        public Agendas(int dni)
        {
            this.dni = dni;
            InitializeComponent();
        }

        private void Agendas_Load(object sender, EventArgs e)
        {
            DataTable professional = Professional.getProfessionalByDni(this.dni);
            labelProfesional.Text = professional.Rows[0]["nombre"].ToString() + " " + professional.Rows[0]["apellido"].ToString();

            DataTable timetables = Timetable.getTimetables(this.dni);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = timetables;

            timetablesGrid.DataSource = bindingSource;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Update(timetables);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String accion = timetablesGrid.Columns[e.ColumnIndex].HeaderText.ToString();
            if (e.RowIndex >= timetablesGrid.Rows.Count) return;
            int professionCode = Int32.Parse(timetablesGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            bool created = timetablesGrid.Rows[e.RowIndex].Cells[4].Value.ToString() == "CREADA";
            if (accion == "Crear")
            {
                if (created)
                {
                    MessageBox.Show("Esta agenda ya fue creada");
                    return;
                }
                this.Hide();
                AltaHorarios edit = new AltaHorarios(professionCode, this.dni);
                edit.Show();
            }
            if (accion == "Ver")
            {
                if (!created) {
                    MessageBox.Show("Esta agenda no esta creada");
                    return;
                }
                this.Hide();
                Agenda remove = new Agenda(professionCode, this.dni);
                remove.Show();
            }
        }
    }
}
