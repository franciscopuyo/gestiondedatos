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
            
            DataTable planes = util.Sql.query("select descripcion from Planes_Medicos");

            List<String> options = new List<string>();

            for(int i = 0; i< planes.Rows.Count; i++)
            {
                options.Add(planes.Rows[i][0].ToString());
            }

            planMedico.DataSource = options;

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            //if (!validInputs())
            //{
            //    return;
            //};

            Afiliado afiliado = new Afiliado();
            afiliado.nombre = nombre.Text;
            afiliado.apellido = apellido.Text;
            afiliado.tipoDNI = tipoDoc.Text;
            afiliado.DNI = documento.Text;
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
            return validInputs;

        }

    }
}
