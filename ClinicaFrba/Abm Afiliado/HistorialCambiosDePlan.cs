using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class HistorialCambiosDePlan : Form
    {
        private string dni;

        public HistorialCambiosDePlan(string dni)
        {
            InitializeComponent();
            this.dni = dni;
        }

        private void HistorialCambiosDePlan_Load(object sender, EventArgs e)
        {
            Afiliado afiliado = Afiliado.GetAfiliado(dni);
            label1.Text = "Viendo historial de cambios de plan de afiliado " + afiliado.nombre.ToUpper() + " " + afiliado.apellido.ToUpper();
            label2.Text = "Documento " + afiliado.documento;

            loadHistorial();
        }

        private void loadHistorial()
        {
            SqlConnection connection = util.Sql.connect("gd");

            String query = "select(select descripcion from Planes_Medicos where codigo = c.plan_viejo) as PlanViejo,(select descripcion from Planes_Medicos where codigo = c.plan_nuevo) as PlanNuevo,fecha,motivo from Cambios_De_Plan c where afiliados_dni = " + dni;

            BindingSource bindingSource;
            SqlDataAdapter adapter;

            adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            dataGridView1.DataSource = bindingSource;

            adapter.Update(dataTable);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            List list = new List();
            list.Show();
        }
            

    }
}
