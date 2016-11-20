using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.util;

namespace ClinicaFrba
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            String query = "IF EXISTS(" +
            "SELECT * FROM sysobjects WHERE id = object_id(N'group_by.GETDATECUSTOM')" +
            "AND xtype IN(N'FN', N'IF', N'TF')" +
             ")  DROP FUNCTION group_by.GETDATECUSTOM";
            Sql.update(query);
            query = "CREATE FUNCTION group_by.GETDATECUSTOM () RETURNS DATETIME BEGIN return CONVERT(DATETIME,'{0}', 120); END";
            query = String.Format(query, Date.getDate());
            Sql.update(query);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
