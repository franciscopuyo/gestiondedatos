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
    public partial class ConfirmarCompra : Form
    {
        private int cantidad;
        private Double monto;

        public ConfirmarCompra(int cantidad)
        {
            InitializeComponent();
            this.cantidad = cantidad;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            ClinicaFrba.util.Session.mainMenu(this);
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            Compras.comprar(Session.dni, cantidad, monto);

            this.Hide();

            MessageBox.Show("Compra realizada con exito");
        }

        private void ConfirmarCompra_Load(object sender, EventArgs e)
        {
            label1.Text = String.Format("Esta a punto de comprar {0} bonos", cantidad);
            
            monto = Compras.calcularMonto(cantidad, Session.dni);

            label2.Text = String.Format("El monto total es de ${0}", monto);
        }
    }
}
