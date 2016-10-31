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
    public partial class DatosConyugue : Form
    {
        private Afiliado afiliado;

        public DatosConyugue(Afiliado afiliado)
        {
            InitializeComponent();
            this.afiliado = afiliado;
            this.Show();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            //if (!validInputs())
            //{
            //    return;
            //};

            Afiliado conyugue = new Afiliado();
            conyugue.nombre = nombre.Text;
            conyugue.apellido = apellido.Text;
            conyugue.tipoDNI = tipoDoc.Text;
            conyugue.DNI = documento.Text;
            conyugue.direccion = direccion.Text;
            conyugue.telefono = telefono.Text;
            conyugue.mail = mail.Text;
            conyugue.fechaNacimiento = fechaNacimiento.Value;
            conyugue.sexo = sexo.Text;
            conyugue.estadoCivil = this.afiliado.estadoCivil;
            conyugue.planMedico = this.afiliado.planMedico;

            this.afiliado.conyugue = conyugue;

            this.Hide();

            PreguntarDatosResponsables preguntarDatosResponsables = new PreguntarDatosResponsables(afiliado);

        }

        private void nombreLabel_Click(object sender, EventArgs e)
        {

        }

        private void ApellidoLabel_Click(object sender, EventArgs e)
        {

        }

        private void apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void sexoLabel_Click(object sender, EventArgs e)
        {

        }

        private void sexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mailLabel_Click(object sender, EventArgs e)
        {

        }

        private void mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tipoDocLabel_Click(object sender, EventArgs e)
        {

        }

        private void tipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void documento_TextChanged(object sender, EventArgs e)
        {

        }

        private void fechaNacLabel_Click(object sender, EventArgs e)
        {

        }

        private void fechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void telefonoLabel_Click(object sender, EventArgs e)
        {

        }

        private void telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void direccionLabel_Click(object sender, EventArgs e)
        {

        }

        private void direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
