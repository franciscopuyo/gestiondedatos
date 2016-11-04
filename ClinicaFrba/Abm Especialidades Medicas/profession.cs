﻿using System;
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

        public static int getCodeByDescription(String description)
        {
            String query = "SELECT codigo from Especialidades where descripcion = {0}";
            query = String.Format(query, description);
            return Int32.Parse(Sql.query(query).Rows[0][0].ToString());
        }
    }
}
