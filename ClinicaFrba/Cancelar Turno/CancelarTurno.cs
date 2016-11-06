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
using ClinicaFrba.Pedir_Turno;

namespace ClinicaFrba.Cancelar_Turno
{
    public partial class CancelarTurno : Form
    {
        private int tournNumber;
        private int dni;
        public CancelarTurno(int dni, int tournNumber)
        {
            this.tournNumber = tournNumber;
            this.dni= dni;
            InitializeComponent();
        }

        private void CancelarTurno_Load(object sender, EventArgs e)
        {
            tournNumberLabel.Text = this.tournNumber.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Listado listado = new Listado(this.dni);
            listado.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Turno.cancelar(tournNumber, 1, reason.Text);
            MessageBox.Show("El turno fue cancelado con exito");
            this.Hide();
            Listado listado = new Listado(this.dni);
            listado.Show();
        }
    }
}
