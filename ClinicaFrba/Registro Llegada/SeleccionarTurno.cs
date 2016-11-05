using ClinicaFrba.util;
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
using ClinicaFrba.util;

namespace ClinicaFrba.Registro_Llegada
{
    public partial class SeleccionarTurno : Form
    {
        private BindingSource bindingSource;
        private SqlDataAdapter adapter;

        private string dniProfesional;
        private int esp;

        public SeleccionarTurno(string dni, int esp)
        {
            InitializeComponent();
            this.dniProfesional = dni;
            this.esp = esp;
        }

        private void loadTurnos()
        {
            SqlConnection connection = util.Sql.connect("gd");

            String query = "select nombre as Nombre, apellido as Apellido, Turnos.afiliado_dni as DNI_Afiliado,Turnos.numero as Numero_Turno, 'Seleccionar' as Seleccionar from Turnos, Personas_Detalle where Turnos.profesional_dni = {0} and Turnos.especialidad_codigo = {1} and fecha = CONVERT(DATE, GETDATE()) and Personas_Detalle.dni = Turnos.afiliado_dni";
            query = String.Format(query, dniProfesional, esp);
            adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            dataGridView1.DataSource = bindingSource;

            adapter.Update(dataTable);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SeleccionarTurno_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String nroTurno = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            String dniAfiliado = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.Hide();

            SeleccionarBono s = new SeleccionarBono(nroTurno, dniAfiliado);
            s.Show();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            Session.mainMenu(this);
        }
    }
}
