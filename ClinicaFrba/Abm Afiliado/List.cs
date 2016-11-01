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

            String query = "select (select nombre from Personas_Detalle where dni = afiliado_dni) as Nombre, (select apellido from Personas_Detalle where dni = afiliado_dni) as Apellido, afiliado_dni as Documento, nro_afiliado as NroAfiliado, (select descripcion from Planes_Medicos where codigo = plan_medico_codigo ) as Plan_Medico, 'Editar' as Editar, 'Borrar' as Borrar, 'Ver historial cambios de plan' as Historial from Afiliados where activo = 1 ";
           
            if (dniFilter.Text != null && !dniFilter.Text.Equals(""))
            {
                query += " and (afiliado_dni = " + dniFilter.Text + ")";
            }

            if (nombre.Text != "")
            {
                String nombreFilter = " and ((select nombre from Personas_Detalle where dni = afiliado_dni) like '%{0}%') ";
                nombreFilter = String.Format(nombreFilter, nombre.Text);
                query += nombreFilter;
            }

            if (apellido.Text != "")
            {
                String apellidoFilter = " and ((select apellido from Personas_Detalle where dni = afiliado_dni) like '%{0}%') ";
                apellidoFilter = String.Format(apellidoFilter, apellido.Text);
                query += apellidoFilter;
            }

            if (planMedico.Text != "")
            {
                String planFilter = " and ((select descripcion from Planes_Medicos where codigo = plan_medico_codigo ) like '%{0}%') ";
                planFilter = String.Format(planFilter, planMedico.Text);
                query += planFilter;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            cantResults.Text = "Cantidad de registros: " + bindingSource.Count.ToString(); 
        }

        private void List_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dniFilter.Text = "";
            nombre.Text = "";
            apellido.Text = "";
            planMedico.Text = "";
            dataGridView1.DataSource = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String accion = dataGridView1.Columns[e.ColumnIndex].HeaderText.ToString();
            String dni = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            if (accion == "Editar")
            {
                this.Hide();
                Edit edit = new Edit(dni);
                edit.Show();
            }
            if (accion == "Borrar")
            {
                this.Hide();
                Borrar borrar = new Borrar(dni);
                borrar.Show();
            }
            if (accion == "Historial")
            {
                this.Hide();
                HistorialCambiosDePlan historial = new HistorialCambiosDePlan(dni);
                historial.Show();
            }
        }

    }
}
