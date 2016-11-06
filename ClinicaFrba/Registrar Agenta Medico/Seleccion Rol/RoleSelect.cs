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
using ClinicaFrba.Abm_Rol;
using ClinicaFrba.Listado_Funcionalidad;

namespace ClinicaFrba.Seleccion_Rol
{
    public partial class RoleSelect : Form
    {
        public RoleSelect()
        {
            InitializeComponent();
        }

        private void RoleSelect_Load(object sender, EventArgs e)
        {
            DataTable rolesResults = Role.getUserRoles(Session.dni);

            foreach (DataRow row in rolesResults.Rows) {
                ComboBoxItem RoleItem = new ComboBoxItem(Int32.Parse(row["codigo"].ToString()), row["descripcion"].ToString());  
                comboBox1.Items.Add(RoleItem);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem selectedRole = (ComboBoxItem)comboBox1.SelectedItem;
            Session.role = selectedRole.Value;
            this.Hide();
            Form listadoFuncionalidad = new ListadoFuncionalidad();
            listadoFuncionalidad.Show();
        }
    }
}
