using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.util;
using ClinicaFrba.Pedir_Turno;

namespace ClinicaFrba.Cancelar_Turno
{
    public partial class Listado : Form
    {
        private int dni;
        public Listado(int dni)
        {
            this.dni = dni;
            InitializeComponent();
        }

        private void Listado_Load(object sender, EventArgs e)
        {

            DataTable tourns = Turno.conseguirPorAfiliado(dni);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tourns;

            tournGrid.DataSource = bindingSource;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Update(tourns);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Session.mainMenu(this);
        }

        private void tournGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            String accion = tournGrid.Columns[e.ColumnIndex].HeaderText.ToString();
            String cancelable = tournGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            int tournNumber = Int32.Parse(tournGrid.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (accion == "Cancelar" && cancelable == "Cancelar")
            {
                this.Hide();
                CancelarTurno cancelation = new CancelarTurno(this.dni, tournNumber);
                cancelation.Show();
            }  

        }
    }
}
