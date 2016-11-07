using ClinicaFrba.Listado_Funcionalidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.util
{
    class Session
    {

        public static String user;
        public static int dni;
        public static int role;

        internal static bool isAdmin()
        {
            return role == 3;
        }


        internal static bool isAfiliado()
        {
            return role == 2;
        }

        internal static bool isProfesional()
        {
            return role == 1;
        }

        internal static void mainMenu(Form form)
        {
            form.Hide();
            ListadoFuncionalidad mainMenu = new ListadoFuncionalidad();
            mainMenu.Show();
        }
    }
}
