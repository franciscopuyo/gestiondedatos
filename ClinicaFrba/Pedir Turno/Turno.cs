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
            String query = "SELECT * FROM Disponibilidad d JOIN Agendas a ON (d.profesional_dni = a.profesional_dni AND a.especialidad_codigo = d.especialidad_codigo) LEFT JOIN Periodos_Cancelados pc ON (pc.profesional_dni = a.profesional_dni AND pc.especialidad_codigo = a.especialidad_codigo) WHERE dia = {0} AND d.profesional_dni = {1} AND d.especialidad_codigo = {2} AND " +
                " d.desde <= CONVERT(time,'{3}') AND d.hasta >= CONVERT(time,'{4}') " +
                "and CONVERT(date, '{5}') between a.desde and a.hasta " + 
                "and (pc.profesional_dni IS NOT NULL OR '{5}' NOT BETWEEN pc.desde AND pc.hasta)";
            query = String.Format(query, dia, dni, codigoEspecialidad, horario, horario.AddMinutes(30), horario);
            DataTable results = Sql.query(query);
            return results.Rows.Count > 0;
        }

        public static bool esSobreturno(String dni, String codigoEspecialidad, DateTime horario)
        {
            String query = "SELECT * FROM Turnos t LEFT JOIN cancelaciones can ON (can.turno_nro = t.numero) WHERE (t.fecha BETWEEN '{0}' AND '{1}') AND especialidad_codigo = {2} AND profesional_dni = {3} AND can.turno_nro IS NULL";
            query = String.Format(query, horario.AddMinutes(-30), horario.AddMinutes(30), codigoEspecialidad, dni);
            DataTable results = Sql.query(query);
            return results.Rows.Count > 0;
        }

        public static void crear(int dniAfiliado, String dni, String codigoEspecialidad, DateTime horario)
        {
            String query = "INSERT INTO Turnos (numero, afiliado_dni, especialidad_codigo, profesional_dni, fecha) VALUES ((select top 1 numero + 1 from Turnos order by numero desc) ,{0},{1},{2},'{3}')";
            query = String.Format(query, dniAfiliado, codigoEspecialidad, dni, horario);
            Sql.query(query);
        }

        public static void cancelarTurnosPorProfesional(int dniProfesional, int professionCode, String reason, DateTime from, DateTime to)
        {
            String query = "INSERT INTO Cancelaciones SELECT t.Numero as turno_nro, 2 as tipo, '{0}' as motivo from Turnos t LEFT JOIN Cancelaciones can ON (can.turno_nro = t.numero) where can.turno_nro AND (t.fecha BETWEEN '{1}' AND '{2}') and profesional_dni = {3} and especialidad_codigo = {4}";
            query = String.Format(query, reason, from, to.AddMinutes(30), dniProfesional, professionCode);
            Sql.query(query);
        }
    }
}
