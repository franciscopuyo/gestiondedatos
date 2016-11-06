using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.util;
using System.Data.SqlClient;
using ClinicaFrba.Pedir_Turno;
using ClinicaFrba.Abm_Especialidades_Medicas;

namespace ClinicaFrba.Registrar_Atencion
{
    public partial class SeleccionConsulta : Form
    {
        private int dni;

        public SeleccionConsulta(int dni)
        {
            this.dni = dni;
            this.dni = 20407720;
            InitializeComponent();
            loadEspecialidades();
            loadConsultas();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Session.mainMenu(this);
        }

        private void loadConsultas()
        {
            int professionCode = Profession.getCodeByDescription(especialidadesCombo.Text);
            DataTable dataTable = MedicalAtention.getPendingByProfessional(this.dni, professionCode);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            atentionsGrid.DataSource = bindingSource;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Update(dataTable);
        }

        private void loadEspecialidades()
        {

            DataTable especialidades = Profession.getByDni(dni);
            List<String> options = new List<string>();
            for (int i = 0; i < especialidades.Rows.Count; i++)
            {
                options.Add(especialidades.Rows[i][0].ToString());
            }
            especialidadesCombo.DataSource = options;
        }

        private void SeleccionConsulta_Load(object sender, EventArgs e)
        {
            loadEspecialidades();
            loadConsultas();
        }

        private void atentionsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String accion = atentionsGrid.Columns[e.ColumnIndex].HeaderText.ToString();
            if (e.RowIndex >= atentionsGrid.Rows.Count) return;
            int atention = Int32.Parse(atentionsGrid.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (accion == "Efectivizar")
            {
                this.Hide();
                Form1 edit = new Form1(atention, dni);
                edit.Show();
            }
        }

        private void especialidadesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadConsultas();
        }
    }
}
