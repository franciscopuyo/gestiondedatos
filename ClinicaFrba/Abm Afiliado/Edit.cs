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
    public partial class Edit : Form
    {

        private Afiliado afiliado;

        public Edit(String dni)
        {
            this.afiliado = Afiliado.GetAfiliado(dni);
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (!validInputs())
            {
                return;
            };
            
            afiliado.nombre = nombre.Text;
            afiliado.apellido = apellido.Text;
            afiliado.direccion = direccion.Text;
            afiliado.telefono = telefono.Text;
            afiliado.mail = mail.Text;
            afiliado.fechaNacimiento = fechaNacimiento.Value;
            afiliado.sexo = sexo.Text;
            afiliado.estadoCivil = estadoCivil.Text;
            afiliado.planMedico = planMedico.Text;

            this.Hide();
            afiliado.update();

            if(afiliado.planMedico != afiliado.planMedicoViejo)
            {
                AgregarCambioDePlan agregarCambioDePlan = new AgregarCambioDePlan(afiliado);
                agregarCambioDePlan.Show();
            } else{
                MessageBox.Show("Afiliado editado correctamente");
                List list = new List();
                list.Show();
            }

        }

        private Boolean validInputs()
        {

            Boolean validInputs = true;

            Validations.validateOnlyAlphabetical(nombre, errorProviderNombre, "Nombre vacio o invalido", ref validInputs);
            Validations.validateOnlyAlphabetical(apellido, errorProviderApellido, "Apellido vacio o invalido", ref validInputs);
            Validations.validateString(direccion, errorProviderDireccion, "Direccion vacia o invalida", ref validInputs);
            Validations.validateEmail(mail, errorProviderMail, "Email vacio o invalido", ref validInputs);
            Validations.validateDateBeforeNow(fechaNacimiento, errorProviderFechaNacimiento, "Fecha de nacimiento invalida", ref validInputs);

            return validInputs;

        }

        private void Edit_Load(object sender, EventArgs e)
        {
            DataTable planes = util.Sql.query("select descripcion from group_by.Planes_Medicos");

            List<String> options = new List<string>();

            for (int i = 0; i < planes.Rows.Count; i++)
            {
                options.Add(planes.Rows[i][0].ToString());
            }

            planMedico.DataSource = options;

            label1.Text = "Editando afiliado con documento " + this.afiliado.documento;
            loadAfiliadoData();
           
        }

        private void loadAfiliadoData()
        {
            nombre.Text = afiliado.nombre;
            apellido.Text = afiliado.apellido;
            direccion.Text = afiliado.direccion;
            telefono.Text = afiliado.telefono;
            mail.Text = afiliado.mail;
            fechaNacimiento.Value = afiliado.fechaNacimiento;
            sexo.Text = afiliado.sexo;
            estadoCivil.Text = afiliado.estadoCivil;
            planMedico.Text = afiliado.planMedico;
        }
    }

}
