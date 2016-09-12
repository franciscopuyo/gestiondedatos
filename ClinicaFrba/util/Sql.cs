using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClinicaFrba.util
{
    class Sql
    {
        public static SqlConnection connect(string connectionString)
        {
            SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings[connectionString].ConnectionString);
            try
            {
                connection.Open();
                MessageBox.Show("Me conecte a la base");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Fail connecting!" + ex.Message);
            }

            return connection;
        }
    }
}
