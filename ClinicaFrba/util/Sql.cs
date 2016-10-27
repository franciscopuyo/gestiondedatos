using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data;

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
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Fail connecting!" + ex.Message);
            }

            return connection;
        }


        public static DataTable query(String query){
            SqlConnection connection = Sql.connect("gd");
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }

    }
}
