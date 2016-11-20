using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ClinicaFrba.util;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Load(object sender, EventArgs e)
        {
   
            DataTable planes = util.Sql.query("select descripcion from group_by.Planes_Medicos");


            List<String> options = new List<string>();

            for(int i = 0; i< planes.Rows.Count; i++)
            {
                options.Add(planes.Rows[i][0].ToString());
            }

            planMedico.DataSource = options;

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (!validInputs())
            {
                return;
            };

            Afiliado afiliado = new Afiliado();
            afiliado.nombre = nombre.Text;
            afiliado.apellido = apellido.Text;
            afiliado.tipoDocumento = tipoDoc.Text;
            afiliado.documento = int.Parse(documento.Text);
            afiliado.direccion = direccion.Text;
            afiliado.telefono = telefono.Text;
            afiliado.mail = mail.Text;
            afiliado.fechaNacimiento = fechaNacimiento.Value;
            afiliado.sexo = sexo.Text;
            afiliado.estadoCivil = estadoCivil.Text;
            afiliado.planMedico = planMedico.Text;
            afiliado.cantidadResponsables = int.Parse(cantResponsables.Text);

            this.Hide();

            PreguntarDatosConyugue preguntarDatosConyugue = new PreguntarDatosConyugue(afiliado);
        }


        private Boolean validInputs() {

            Boolean validInputs = true;

            Validations.validateOnlyAlphabetical(nombre, errorProviderNombre, "Nombre vacio o invalido", ref validInputs);
            Validations.validateOnlyAlphabetical(apellido, errorProviderApellido, "Apellido vacio o invalido", ref validInputs);
            Validations.validateString(direccion, errorProviderDireccion, "Direccion vacia o invalida", ref validInputs);
            if (tipoDoc.Text == "DNI")
            {
                Validations.validateIntWithLength(documento, errorProviderDocumento, "Documento vacio o invalido", 8, ref validInputs);
            }
            if(tipoDoc.Text == "LE")
            {
                Validations.validateIntWithLength(documento, errorProviderDocumento, "Documento vacio o invalido", 8, ref validInputs);
            }
            Validations.validateEmail(mail, errorProviderMail, "Email vacio o invalido", ref validInputs);
            Validations.validateIntWithMaxLength(cantResponsables, errorProviderCantResponsables, "Cantidad de responsables no valida", 2, ref validInputs);
            Validations.validateDateBeforeNow(fechaNacimiento, errorProviderFechaNacimiento, "Fecha de nacimiento invalida", ref validInputs);


            if (Afiliado.documentoYaExiste(documento.Text))
            {
                errorProviderDocumento.SetError(documento, "El documento ingresado ya existe");
                validInputs = false;
            }

            return validInputs;

        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void ApellidoLabel_Click(object sender, EventArgs e)
        {

        }

        private void apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void estadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void estadoCivilLabel_Click(object sender, EventArgs e)
        {

        }

        private void tipoDocLabel_Click(object sender, EventArgs e)
        {

        }

        private void tipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cantHijosLabel_Click(object sender, EventArgs e)
        {

        }

        private void cantResponsables_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void documento_TextChanged(object sender, EventArgs e)
        {

        }

        private void planMedicoLabel_Click(object sender, EventArgs e)
        {

        }

        private void planMedico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void direccionLabel_Click(object sender, EventArgs e)
        {

        }

        private void mailLabel_Click(object sender, EventArgs e)
        {

        }

        private void mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void fechaNacLabel_Click(object sender, EventArgs e)
        {

        }

        private void fechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nombreLabel_Click(object sender, EventArgs e)
        {

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Session.mainMenu(this);
        }

      
    }
}
