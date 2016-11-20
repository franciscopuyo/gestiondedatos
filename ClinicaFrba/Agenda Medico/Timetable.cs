using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using ClinicaFrba.util;
using ClinicaFrba.Pedir_Turno;

namespace ClinicaFrba.Agenda_Medico
{
    class Timetable
    {

        public static void create(int professionId, int dni, DateTime from, DateTime to)
        {
            String query = "INSERT INTO group_by.Agendas (desde, hasta, especialidad_codigo, profesional_dni) " +
                "VALUES ('{0}','{1}',{2},{3})";
            query = String.Format(query, from.Date.ToString("d"), to.Date.ToString("d"), professionId, dni);
            Sql.query(query);
        }

        public static void addWorkDay(int day, int professionId, int dni, DateTime from, DateTime to)
        {
            String query = "INSERT INTO group_by.Disponibilidad (dia, desde, hasta, especialidad_codigo, profesional_dni) " +
                "VALUES ({0},'{1}','{2}',{3},{4})";
            query = String.Format(query, day.ToString(), from.AddSeconds(-from.Second).TimeOfDay.ToString(), to.AddSeconds(-to.Second).TimeOfDay.ToString(), professionId, dni);
            Sql.query(query);
        }

        public static DataTable getTimetable(int professionId, int dni)
        {
            String query = "SELECT CASE " +
                "WHEN dia = 1 THEN 'Lunes' " +
                "WHEN dia = 2 THEN 'Martes' " +
                "WHEN dia = 3 THEN 'Miercoles' " +
                "WHEN dia = 4 THEN 'Jueves' " +
                "WHEN dia = 5 THEN 'Viernes' " +
                "WHEN dia = 6 THEN 'Sabado' " +
                "END as Dia, " +
                " CONVERT(VARCHAR(5),d.desde,108) as desde, CONVERT(VARCHAR(5),d.hasta,108) as hasta from group_by.Disponibilidad d JOIN group_by.Agendas a ON (d.profesional_dni = a.profesional_dni AND d.especialidad_codigo = a.especialidad_codigo) " +
                "WHERE d.especialidad_codigo = {0} AND d.profesional_dni = {1}";

            query = String.Format(query, professionId.ToString(), dni.ToString());
            return Sql.query(query);
        }

        public static DataTable getTimetables(int dni)
        {
            String query = "SELECT e.codigo, e.descripcion as Especialidad, ISNULL(a.desde, '') as Desde, ISNULL(a.hasta, '') as Hasta, CASE WHEN a.profesional_dni IS NULL THEN 'CREAR' ELSE 'CREADA' END as Crear, CASE WHEN a.profesional_dni IS NULL THEN 'X' ELSE 'VER' END as Ver from group_by.Medico_Especialidad me JOIN group_by.Especialidades e ON (e.codigo = me.especialidad_codigo) LEFT JOIN group_by.Agendas a ON (me.profesional_dni = a.profesional_dni AND me.especialidad_codigo = a.especialidad_codigo) " +
                "WHERE me.profesional_dni = {0}";

            query = String.Format(query, dni.ToString());
            return Sql.query(query);
        }

        public static void cancelPeriod(int dni, int professionCode, DateTime from, DateTime to, String reason)
        {
            String query = "INSERT INTO group_by.Periodos_Cancelados (desde, hasta, especialidad_codigo, profesional_dni) VALUES ('{0}','{1}',{2},{3})";
            query = String.Format(query, from, to, professionCode, dni);
            Sql.query(query);

            Turno.cancelarTurnosPorProfesional(dni, professionCode, reason, from, to);
        }

        public static DataTable getCanceledPeriods(int dni, int professionCode, DateTime from, DateTime to)
        {
            String query = "SELECT * from group_by.Periodos_Cancelados where profesional_dni = {0} and especialidad_codigo = {1} AND ((desde BETWEEN '{2}' AND '{3}') OR (desde BETWEEN '{2}' AND '{3}'))";
            query = String.Format(query, dni, professionCode, from, to);
            return Sql.query(query);
        }
    }
}
