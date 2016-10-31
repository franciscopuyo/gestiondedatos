using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Abm_Afiliado
{
    public class Afiliado
    {
        public String nombre;
        public String apellido;
        public String tipoDNI;
        public String DNI;
        public String direccion;
        public String telefono;
        public String mail;
        public DateTime fechaNacimiento;
        public String sexo;
        public String estadoCivil;
        public int cantidadResponsables;
        public String planMedico;

        public Afiliado conyugue;
        public List<Afiliado> responsables = new List<Afiliado>();
        public Boolean ingresarProximoResponsable = true;

        public String username;
        public String password;
    }
}
