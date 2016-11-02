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

namespace ClinicaFrba.Abm_Rol
{
    public partial class List : Form
    {
        private BindingSource bindingSource;

        public List()
        {
            InitializeComponent();
            loadRoles();
        }

        private void loadRoles()
        {

            DataTable dataTable = Role.getRolesToTable();
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            rolesGrid.DataSource = bindingSource;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.Update(dataTable);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String accion = rolesGrid.Columns[e.ColumnIndex].HeaderText.ToString();
            if (e.RowIndex >= rolesGrid.Rows.Count) return; 
            int roleId = Int32.Parse(rolesGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            String roleDescription = rolesGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (accion == "Editar")
            {
                this.Hide();
                Edit edit = new Edit(roleId, roleDescription);
                edit.Show();
            }
            if (accion == "Borrar")
            {
                this.Hide();
                Remove remove = new Remove(roleId, roleDescription);
                remove.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit edit = new Edit(0, "");
            edit.Show();
        }
    }
}
