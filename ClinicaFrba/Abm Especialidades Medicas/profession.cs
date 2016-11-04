using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using ClinicaFrba.util;

namespace ClinicaFrba.Abm_Especialidades_Medicas
{
    class Profession
    {
        public static DataTable getProfessionByCode(int code)
        {
            String query = "SELECT * from Especialidades where codigo = {0}";
            query = String.Format(query, code);
            return Sql.query(query);
        }
    }
}
