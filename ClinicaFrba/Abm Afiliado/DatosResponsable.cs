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
    public partial class DatosResponsable : Form
    {
        private Afiliado afiliado;

        public DatosResponsable(Afiliado afiliado)
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

            Afiliado responsable = new Afiliado();
            responsable.nombre = nombre.Text;
            responsable.apellido = apellido.Text;
            responsable.tipoDocumento = tipoDoc.Text;
            responsable.documento = int.Parse(documento.Text);
            responsable.direccion = direccion.Text;
            responsable.telefono = telefono.Text;
            responsable.mail = mail.Text;
            responsable.fechaNacimiento = fechaNacimiento.Value;
            responsable.sexo = sexo.Text;
            responsable.estadoCivil = this.afiliado.estadoCivil;
            responsable.planMedico = this.afiliado.planMedico;

            this.afiliado.responsables.Add(responsable);

            this.Hide();

            PreguntarDatosResponsables preguntarDatosResponsables = new PreguntarDatosResponsables(this.afiliado);
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
            Validations.validateIntWithMaxLength(telefono, errorProviderTelefono, "Telefono vacio o invalido", 14, ref validInputs);
        
            if (Afiliado.documentoYaExiste(documento.Text) || afiliado.contiene(documento.Text))
            {
                errorProviderDocumento.SetError(documento, "El documento ingresado ya existe");
                validInputs = false;
            }
            
            return validInputs;

        }
    }
}
