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

namespace ClinicaFrba.Compra_Bono
{
    public partial class CompraAdministrativo : Form
    {
        public CompraAdministrativo()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            ClinicaFrba.util.Session.mainMenu(this);
        }

        private void continuar_Click(object sender, EventArgs e)
        {
            Boolean valid = true;
            Validations.validateIntWithMaxLength(cantidad, errorProviderCantidad, "Cantidad vacia o invalida", 10, ref valid);
            Validations.validateIntWithLength(nroAfiliado, nroAfiliado.Text, errorProviderAfiliado, "Nro de afiliado vacio o invalido", 10, ref valid);
            if (!valid)
            {
                return;
            }

            this.Hide();
            ConfirmarCompraAdministrativo confirmar = new ConfirmarCompraAdministrativo(nroAfiliado.Text, int.Parse(cantidad.Text));
            confirmar.Show();
        }
    }
}
