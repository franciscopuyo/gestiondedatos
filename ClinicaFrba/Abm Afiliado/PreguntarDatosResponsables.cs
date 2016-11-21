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
    public partial class PreguntarDatosResponsables : Form
    {
        private Afiliado afiliado;

        public PreguntarDatosResponsables(Afiliado afiliado)
        {
            InitializeComponent();
            this.afiliado = afiliado;

            if (afiliado.cantidadResponsables >= 0 && afiliado.cantidadResponsables > afiliado.responsables.Count)
            {
                this.Show();
            }
            else
            {
                afiliado.persist();
                MessageBox.Show("Afiliados cargados con exito. \n Nombre de usuario principal: " + afiliado.username + " Contrasena: " + afiliado.password + ".");
                Session.mainMenu(this);            
            } 
        }

        private void NO_Click(object sender, EventArgs e)
        {
            afiliado.persist();
            MessageBox.Show("Afiliados cargados con exito. \n Nombre de usuario principal: " + afiliado.username + " Contrasena: " + afiliado.password + ".");
            Session.mainMenu(this);
        }

        private void SI_Click(object sender, EventArgs e)
        {
            DatosResponsable datosResponsable = new DatosResponsable(this.afiliado);
            this.Hide();
        }

        private void PreguntarDatosResponsables_Load(object sender, EventArgs e)
        {
            cargados.Text = "(Cargados " + this.afiliado.responsables.Count.ToString() + " de " + afiliado.cantidadResponsables.ToString() + ")";
        }

    }
}
