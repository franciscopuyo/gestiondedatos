using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class List : Form
    {
        private BindingSource bindingSource;
        private SqlDataAdapter adapter;

        public List()
        {
            InitializeComponent();
            loadAfiliados();
        }

        private void loadAfiliados()
        {
            SqlConnection connection = util.Sql.connect("gd");

            String query = "select afiliado_dni, nro_afiliado, plan_medico_codigo from Afiliados";

            if (dniFilter.Text != null && !dniFilter.Text.Equals(""))
            {
                query += " where afiliado_dni = " + dniFilter.Text;
            }
            
            adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            dataGridView1.DataSource = bindingSource;

            adapter.Update(dataTable);
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            loadAfiliados();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cantResults.Text = "Cantidad de registros: " + bindingSource.Count.ToString(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void List_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dniFilter.Text = "";
            dataGridView1.DataSource = null;
        }

    }
}
