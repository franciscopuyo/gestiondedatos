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
            String query = "SELECT * FROM Turnos t LEFT JOIN cancelaciones can ON (can.turno_nro = t.numero) WHERE (t.fecha BETWEEN '{0}' AND '{1}') AND especialidad_codigo = {2} AND profesional_dni = {3} AND can.turno_nro IS NULL";
            query = String.Format(query, horario.AddMinutes(-30), horario.AddMinutes(30), codigoEspecialidad, dni);
            DataTable results = Sql.query(query);
            return results.Rows.Count > 0;
        }

        public static bool hayCancelacion(String dni, String codigoEspecialidad, DateTime horario)
        {
            String query = "SELECT * FROM Periodos_Cancelados WHERE desde <= '{0}' AND hasta >= '{1}' AND profesional_dni = {2} AND especialidad_codigo = {3}";
            query = String.Format(query, horario, horario.AddMinutes(30), dni, codigoEspecialidad);
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
            String query = "INSERT INTO Cancelaciones SELECT t.Numero as turno_nro, 2 as tipo, '{0}' as motivo from Turnos t LEFT JOIN Cancelaciones can ON (can.turno_nro = t.numero) where can.turno_nro IS NULL AND (t.fecha BETWEEN '{1}' AND '{2}') and profesional_dni = {3} and especialidad_codigo = {4}";
            query = String.Format(query, reason, from, to.AddMinutes(30), dniProfesional, professionCode);
            Sql.query(query);
        }

        public static DataTable conseguirPorProfesional(int dniProfesional, int professionCode, DateTime from, DateTime to)
        {
            String query = "SELECT t.Numero, t.Fecha, CASE WHEN can.turno_nro IS NULL THEN 'SI' ELSE 'NO' END as Cancelado from Turnos t LEFT JOIN Cancelaciones can ON (can.turno_nro = t.numero) where profesional_dni = {0} and especialidad_codigo = {1} AND (t.fecha BETWEEN '{2}' AND '{3}')";
            query = String.Format(query, dniProfesional, professionCode, from, to);
            return Sql.query(query);
        }



        public static DataTable conseguirPorAfiliado(int dni)
        {
            String query = "SELECT numero, e.descripcion as Especialidad, CONCAT(pd.apellido, ' ', pd.nombre) as Medico, CASE WHEN fecha >= dateadd(DAY, 1,GETDATE()) THEN 'Cancelar' ELSE 'X' END as Cancelar FROM Turnos t JOIN Profesionales p ON (p.profesional_dni = t.profesional_dni) JOIN Personas_Detalle pd ON (p.profesional_dni = pd.dni) JOIN Especialidades e ON (e.codigo = t.especialidad_codigo) LEFT JOIN Cancelaciones c ON (c.turno_nro = t.numero) WHERE afiliado_dni = {0} AND FECHA >= GETDATE() AND c.turno_nro IS NULL";
            query = String.Format(query, dni);
            return Sql.query(query);
        }

        public static void cancelar(int numero, int tipo, String motivo)
        {
            String query = "INSERT INTO Cancelaciones (turno_nro, tipo, motivo) VALUES ({0},{1},'{2}')";
            query = String.Format(query, numero, tipo, motivo);
            Sql.query(query);
        }
    }
}
