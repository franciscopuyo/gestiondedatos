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

namespace ClinicaFrba.Abm_Rol
{
    public partial class Edit : Form
    {
        private int code;
        public Edit(int roleCode, string roleDescription)
        {
            code = roleCode;
            InitializeComponent();
            loadFunctionalities();
            description.Text = roleDescription;
        }

        private void loadFunctionalities()
        {
            DataTable results = Role.getFunctionalityByRole(code);
            foreach (DataRow row in results.Rows)
            {
                ComboBoxItem functionalityItem = new ComboBoxItem(Int32.Parse(row["codigo"].ToString()), row["funcionalidad"].ToString());
                checkedListBox1.Items.Add(functionalityItem, Int32.Parse(row["habilitada"].ToString()) == 1);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!validInputs()) return;
            String newDescription = description.Text;
            IEnumerable<ComboBoxItem> functionalities = checkedListBox1.CheckedItems.Cast<ComboBoxItem>();
            if (code > 0) {
                Role.update(newDescription, functionalities, code);
            } else {
                Role.create(newDescription, functionalities);
            }
            this.Hide();
            List list = new List();
            list.Show();
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            List list = new List();
            list.Show();
        }

        private bool validInputs()
        {
            Boolean validInputs = true;
            Validations.validateOnlyAlphabetical(description, errorProviderDescription, "Nombre vacio o invalido", ref validInputs);
            return validInputs;
        }
    }
}
