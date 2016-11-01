using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class Borrar : Form
    {
        private string dni;

        public Borrar(string dni)
        {
            InitializeComponent();
            this.dni = dni;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            List list = new List();
            list.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Afiliado.borrar(dni);

            MessageBox.Show("Afiliado borrado correctamente");

            List list = new List();
            list.Show();
        }

        private void Borrar_Load(object sender, EventArgs e)
        {
            Afiliado afiliado = Afiliado.GetAfiliado(dni);
            label2.Text = "Documento " + afiliado.documento;
            label1.Text = "Desea borrar afiliado " + afiliado.nombre.ToUpper() + " " + afiliado.apellido.ToUpper() + "?";
        }
    }
}
