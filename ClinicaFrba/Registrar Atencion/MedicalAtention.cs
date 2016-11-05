﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaFrba.util;
using System.Data;

namespace ClinicaFrba.Registrar_Atencion
{
    class MedicalAtention
    {
        public static DataTable getPendingByProfessional(int dni, int professionCode)
        {
            String query = "SELECT turno_numero as Turno, t.fecha as Fecha_Turno, CONCAT(pd.Apellido, ' ',pd.Nombre) as Paciente, fecha_llegada as Fecha_Llegada, 'Efectivizar' as Efectivizar FROM Atencion_Medica am JOIN Turnos t ON (am.turno_numero = t.numero) JOIN Afiliados a ON (t.afiliado_dni = a.afiliado_dni) JOIN Personas_Detalle pd ON (pd.dni = a.afiliado_dni) WHERE t.profesional_dni = {0} AND t.especialidad_codigo = {1} AND fecha_efectivizacion IS NULL AND t.fecha <= GETDATE()";
            query = String.Format(query, dni, professionCode);
            return Sql.query(query);
        }
    }
}
