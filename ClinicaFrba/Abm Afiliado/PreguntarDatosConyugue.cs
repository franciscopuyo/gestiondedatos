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
    public partial class PreguntarDatosConyugue : Form
    {
        private Afiliado afiliado;

        public PreguntarDatosConyugue(Afiliado afiliado)
        {
            InitializeComponent();
            this.afiliado = afiliado;
            if (afiliado.estadoCivil == "Casado" || afiliado.estadoCivil == "Concubinato")
            {
                this.Show();
            }
            else
            {
                nextStep();
            }
        }

        private void NO_Click(object sender, EventArgs e)
        {
            nextStep();
        }

        private void SI_Click(object sender, EventArgs e)
        {
            DatosConyugue datosConyugue = new DatosConyugue(afiliado);
            this.Hide();
        }

        private void nextStep()
        {
            PreguntarDatosResponsables preguntarDatosResponsables = new PreguntarDatosResponsables(afiliado);
            this.Hide();
        }


    }
}
