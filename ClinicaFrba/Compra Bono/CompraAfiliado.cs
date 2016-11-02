﻿using ClinicaFrba.util;
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
    public partial class CompraAfiliado : Form
    {
        public CompraAfiliado()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void continuar_Click(object sender, EventArgs e)
        {
            Boolean valid = true;
            Validations.validateIntWithMaxLength(cantidad, errorProvider1, "Cantidad vacia o invalida", 10, ref valid);

            if (!valid)
            {
                return;
            }

            this.Hide();
            ConfirmarCompra confirmar = new ConfirmarCompra(int.Parse(cantidad.Text));
            confirmar.Show();
        }

        private void cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
