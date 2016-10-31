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
            if (!validInputs())
            {
                return;
            };

            Afiliado conyugue = new Afiliado();
            conyugue.nombre = nombre.Text;
            conyugue.apellido = apellido.Text;
            conyugue.tipoDocumento = tipoDoc.Text;
            conyugue.documento = int.Parse(documento.Text);
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

        private Boolean validInputs()
        {

            Boolean validInputs = true;

            Validations.validateOnlyAlphabetical(nombre, errorProviderNombre, "Nombre vacio o invalido", ref validInputs);
            Validations.validateOnlyAlphabetical(apellido, errorProviderApellido, "Apellido vacio o invalido", ref validInputs);
            Validations.validateString(direccion, errorProviderDireccion, "Direccion vacia o invalida", ref validInputs);
            if (tipoDoc.Text == "DNI")
            {
                Validations.validateIntWithLength(documento, errorProviderDocumento, "Documento vacio o invalido", 8, ref validInputs);
            }
            if (tipoDoc.Text == "LE")
            {
                Validations.validateIntWithLength(documento, errorProviderDocumento, "Documento vacio o invalido", 8, ref validInputs);
            }
            Validations.validateEmail(mail, errorProviderMail, "Email vacio o invalido", ref validInputs);
            Validations.validateDateBeforeNow(fechaNacimiento, errorProviderFechaNacimiento, "Fecha de nacimiento invalida", ref validInputs);
            return validInputs;

        }
    }
}
