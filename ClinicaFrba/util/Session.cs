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
            DataTable result = util.Sql.query("select descripcion from Roles where codigo = " + role);
            return result.Rows[0][0].ToString().ToUpper() == "ADMIN";
        }


        internal static bool isAfiliado()
        {
            DataTable result = util.Sql.query("select descripcion from Roles where codigo = " + role);
            return result.Rows[0][0].ToString().ToUpper() == "AFILIADO";
        }

        internal static bool isProfesional()
        {
            DataTable result = util.Sql.query("select descripcion from Roles where codigo = " + role);
            return result.Rows[0][0].ToString().ToUpper() == "PROFESIONAL";
        }

        internal static void mainMenu(Form form)
        {
            form.Hide();
            ListadoFuncionalidad mainMenu = new ListadoFuncionalidad();
            mainMenu.Show();
        }
    }
}
