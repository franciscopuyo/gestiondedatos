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

namespace ClinicaFrba.Pedir_Turno
{
    public partial class SeleccionarFecha : Form
    {
        private string nombre;
        private string apellido;
        private string dni;
        private string especialidadDescripcion;

        public SeleccionarFecha(string nombre, string apellido, string dni, string especialidadDescripcion)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.especialidadDescripcion = especialidadDescripcion;
        }

        private void SeleccionarFecha_Load(object sender, EventArgs e)
        {
            titulo.Text = "Asignando turno con " + nombre.ToUpper() + " " + apellido.ToUpper();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            Session.mainMenu(this);
        }
    }
}
