using ClinicaFrba.util;
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
    public partial class AgregarCambioDePlan : Form
    {
        private Afiliado afiliado;

        public AgregarCambioDePlan(Afiliado afiliado)
        {
            InitializeComponent();
            this.afiliado = afiliado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean validInputs = true;

            Validations.validateOnlyAlphabetical(motivo, errorProviderMotivo, "Motivo vacio o invalido", ref validInputs);

            if (!validInputs)
            {
                return;
            }

            afiliado.persitirCambioDePlan(motivo.Text);

            this.Hide();
            MessageBox.Show("Afiliado editado correctamente");
            List list = new List();
            list.Show();
        }
    }
}
