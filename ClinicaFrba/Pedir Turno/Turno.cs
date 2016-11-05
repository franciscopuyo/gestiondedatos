using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaFrba.util;
using System.Data;
namespace ClinicaFrba.Pedir_Turno
{
    class Turno
    {
        public static bool cumpleHorarioMedico(String dni, String codigoEspecialidad, DateTime horario)
        {
            int dia = (int)horario.DayOfWeek;
            String query = "SELECT * FROM Disponibilidad, Agendas WHERE dia = {0} AND Disponibilidad.profesional_dni = {1} AND Disponibilidad.especialidad_codigo = {2} AND " +
                " Disponibilidad.desde <= CONVERT(time,'{3}') AND Disponibilidad.hasta >= CONVERT(time,'{4}') and  " +
                " Agendas.especialidad_codigo = Disponibilidad.especialidad_codigo " +
                "and Disponibilidad.profesional_dni = Disponibilidad.profesional_dni " +
                "and CONVERT(date, '{5}') between Agendas.desde and Agendas.hasta";
            query = String.Format(query, dia, dni, codigoEspecialidad, horario, horario.AddMinutes(30), horario);
            DataTable results = Sql.query(query);
            return results.Rows.Count > 0;
        }

        public static bool esSobreturno(String dni, String codigoEspecialidad, DateTime horario)
        {
            String query = "SELECT * FROM Turnos WHERE (fecha BETWEEN '{0}' AND '{1}') AND especialidad_codigo = {2} AND profesional_dni = {3}";
            query = String.Format(query, horario.AddMinutes(-30), horario.AddMinutes(30), codigoEspecialidad, dni);
            DataTable results = Sql.query(query);
            return results.Rows.Count > 0;
        }

        public static void crear(int dniAfiliado, String dni, String codigoEspecialidad, DateTime horario)
        {
            dniAfiliado = 1123960;
            String query = "INSERT INTO Turnos (afiliado_dni, especialidad_codigo, profesional_dni, fecha) VALUES ({0},{1},{2},'{3}')";
            query = String.Format(query, dniAfiliado, codigoEspecialidad, dni, horario);
            Sql.query(query);
        }
    }
}
