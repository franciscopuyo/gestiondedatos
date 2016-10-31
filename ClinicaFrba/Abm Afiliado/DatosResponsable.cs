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
            //if (!validInputs())
            //{
            //    return;
            //};

            Afiliado responsable = new Afiliado();
            responsable.nombre = nombre.Text;
            responsable.apellido = apellido.Text;
            responsable.tipoDNI = tipoDoc.Text;
            responsable.DNI = documento.Text;
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
    }
}
