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
    public partial class ConfirmarCompraAdministrativo : Form
    {
        private int cantidad;
        private Double monto;
        private string nroAfiliado;

        public ConfirmarCompraAdministrativo(string p1, int p2)
        {
            InitializeComponent();
            this.nroAfiliado = p1;
            this.cantidad = p2;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            ClinicaFrba.util.Session.mainMenu(this);
        }

        private void ConfirmarCompraAdministrativo_Load(object sender, EventArgs e)
        {
            label1.Text = String.Format("Esta a punto de comprar {0} bonos", cantidad);

            monto = Compras.calcularMontoPorNroDeAfiliado(cantidad, nroAfiliado);

            label2.Text = String.Format("El monto total es de ${0}", monto);

            label3.Text = "Confirmar compra de bonos para afiliado " + nroAfiliado;
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            this.Hide();

            String bonosGenerados = Compras.comprarConNroDeAfiliado(nroAfiliado, cantidad, monto);
            MessageBox.Show("Compra realizada correctamente\nBonos generados:\n" + bonosGenerados);

            ClinicaFrba.util.Session.mainMenu(this);

        }
    }
}
