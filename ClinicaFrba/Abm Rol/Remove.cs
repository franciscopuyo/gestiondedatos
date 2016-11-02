using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Rol
{
    public partial class Remove : Form
    {
        private int code;
        private String description;
        public Remove(int roleCode, String roleDescription)
        {
            code = roleCode;
            description = roleDescription;
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            List list = new List();
            list.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            Role.remove(code);

            MessageBox.Show("Rol borrado correctamente");

            List list = new List();
            list.Show();
        }

        private void Remove_Load_1(object sender, EventArgs e)
        {
            label1.Text = "Desea borrar el rol " + description.ToUpper() + "?";
        }
    }
}
