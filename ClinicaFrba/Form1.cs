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
using System.Security.Cryptography;

namespace ClinicaFrba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user = textBox1.Text;
            String pass = textBox2.Text;

            String query = "select * from Usuarios where usuario = {0} and contrasena = HASHBYTES('SHA2_256', '{1}')";
            query = String.Format(query, user, pass);

            DataTable results = Sql.query(query);

            int count = results.Rows.Count;

            if (count == 0)
            {
                MessageBox.Show("Todo mal");
                return;
            }

            MessageBox.Show("Bien ahi");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
