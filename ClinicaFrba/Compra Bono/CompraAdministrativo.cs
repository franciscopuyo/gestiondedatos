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
using ClinicaFrba.Abm_Afiliado;

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
            Validations.validateIntWithMaxLength(nroAfiliado, errorProviderAfiliado, "Nro de afiliado vacio o invalido", 10, ref valid);

            valid &= Validations.isOnlyNumeric(nroAfiliado.Text);
            valid &= Validations.isOnlyNumeric(cantidad.Text);
            
            if (!valid)
            {
                return;
            }

            if (int.Parse(cantidad.Text) < 1)
            {
                errorProviderCantidad.SetError(cantidad, "La cantidad debe ser mayor a 0");
                return;
            }

            Boolean existeAfiliado = Afiliado.nroAfiliadoExiste(nroAfiliado.Text);
            if (!existeAfiliado)
            {
                errorProviderAfiliado.SetError(nroAfiliado, "El afiliado ingresado no existe");
                return;
            }

            this.Hide();
            ConfirmarCompraAdministrativo confirmar = new ConfirmarCompraAdministrativo(nroAfiliado.Text, int.Parse(cantidad.Text));
            confirmar.Show();
        }
    }
}
