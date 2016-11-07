using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using ClinicaFrba.util;
namespace ClinicaFrba.Abm_Profesional
{
    class Professional
    {
        public static DataTable getProfessionalByDni(int dni)
        {
            String query = "SELECT * from group_by.Profesionales p JOIN group_by.Personas_Detalle pd ON (p.profesional_dni = pd.dni) WHERE profesional_dni = {0}";
            query = String.Format(query, dni.ToString());
            return Sql.query(query);
        }
    }
}
