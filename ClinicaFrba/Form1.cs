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
using ClinicaFrba.Seleccion_Rol;

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

            String userExists = "select * from Usuarios where usuario = {0}";
            userExists = String.Format(userExists, user);

            DataTable userExistsResults = Sql.query(userExists);

            if (userExistsResults.Rows.Count == 0)
            {
                MessageBox.Show("Usuario inexistente");
                return;
            }

            Boolean activo = (Boolean) userExistsResults.Rows[0][2];
            if (!activo)
            {
                MessageBox.Show("Usuario deshabilitado");
                return;
            }

            String userPassQuery = "select * from Usuarios where usuario = {0} and contrasena = HASHBYTES('SHA2_256', '{1}')";
            userPassQuery = String.Format(userPassQuery, user, pass);

            DataTable userResults = Sql.query(userPassQuery);

            int count = userResults.Rows.Count;

            if (count == 0) {
                MessageBox.Show("Contrasena inválida");
                String incrementWrongTries = "update usuarios set cantidad_intentos_login = cantidad_intentos_login + 1 where usuario = {0}";
                incrementWrongTries = String.Format(incrementWrongTries, user);

                Sql.update(incrementWrongTries);

                int tries = (int) userExistsResults.Rows[0][3];
                if (tries + 1 == 3)
                {
                    String unactivate = "update usuarios set activo = 0 where usuario = {0}";
                    unactivate = String.Format(unactivate, user);
                    Sql.update(unactivate);
                    MessageBox.Show("Fuiste deshabilitado por intentar muchas veces");
                }
                return;
            } 
            
            
            MessageBox.Show("Todo bien");
            Session.user = user;
            String cleanWrongTries = "update usuarios set cantidad_intentos_login = 0 where usuario = {0}";
            cleanWrongTries = String.Format(cleanWrongTries, user);
            Sql.update(cleanWrongTries);

            this.Hide();
            RoleSelect roleSelect = new RoleSelect();
            roleSelect.Show();
            
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
