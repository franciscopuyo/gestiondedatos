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
    public partial class Add___Step_2 : Form
    {

        private Afiliado afiliado;

        public Add___Step_2(Afiliado afiliado)
        {
            this.afiliado = afiliado;
            InitializeComponent();
        }

        private void Add___Step_2_Load(object sender, EventArgs e)
        {
            if (afiliado.estadoCivil == "Casado/a" || afiliado.estadoCivil == "Concubinato")
            {
                preguntarDatosConyugue();
            }

            Boolean ingresarSiguienteResponsable = true;
            for (int i = 0; i < afiliado.cantidadResponsables && ingresarSiguienteResponsable; i++ )
            {
                preguntarDatosResponsables();
            }
        }

        private void preguntarDatosConyugue()
        {
        }

        private void preguntarDatosResponsables()
        {
        }
    }
}
