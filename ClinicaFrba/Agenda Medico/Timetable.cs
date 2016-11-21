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

        public static void addWorkDay(int day, DateTime from, DateTime to)
        {
            String query = "INSERT INTO group_by.Disponibilidad (dia, desde, hasta, agenda) " +
                "VALUES ({0},'{1}','{2}',IDENT_CURRENT( 'group_by.Agendas'))";
            query = String.Format(query, day.ToString(), from.AddSeconds(-from.Second).TimeOfDay.ToString(), to.AddSeconds(-to.Second).TimeOfDay.ToString());
            Sql.query(query);
        }

        public static DataTable getTimetableById(int id)
        {
            String query = "SELECT * from group_by.Agendas where agenda_id = {0}";
            query = String.Format(query, id);
            return Sql.query(query);  
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
                "WHEN dia = 7 THEN 'Domingo' " +
                "END as Dia, " +
                " CONVERT(VARCHAR(5),d.desde,108) as desde, CONVERT(VARCHAR(5),d.hasta,108) as hasta from group_by.Disponibilidad d JOIN group_by.Agendas a ON (d.agenda = a.agenda_id) " +
                "WHERE a.especialidad_codigo = {0} AND a.profesional_dni = {1}";

            query = String.Format(query, professionId.ToString(), dni.ToString());
            return Sql.query(query);
        }

        public static DataTable getTimetablesByEspecialidadAndProfesional(int dni, int especialidad)
        {
            String query = "SELECT a.agenda_id, e.codigo, e.descripcion as Especialidad, a.desde as Desde, a.hasta as Hasta, 'VER' as Ver from group_by.Agendas a JOIN group_by.Especialidades e ON (e.codigo = a.especialidad_codigo) WHERE profesional_dni = {0} AND especialidad_codigo = {1} ORDER BY desde ASC";
            query = String.Format(query, dni, especialidad);
            return Sql.query(query);
        }
        public static DataTable getTimetables(int dni)
        {
            String query = "SELECT a.agenda_id, e.codigo, e.descripcion as Especialidad, a.desde as Desde, a.hasta as Hasta, 'VER' as Ver from group_by.Agendas a JOIN group_by.Especialidades e ON (e.codigo = a.especialidad_codigo) WHERE profesional_dni = {0}";

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

        public static DataTable getCanceledPeriods(int dni, int professionCode)
        {
            String query = "SELECT * from group_by.Periodos_Cancelados where profesional_dni = {0} and especialidad_codigo = {1}";
            query = String.Format(query, dni, professionCode);
            return Sql.query(query);
        }

        public static bool hayAgendaEnPeriodo(DateTime from, DateTime to, int dni, int professionCode)
        {
            String query = "SELECT * from group_by.Agendas WHERE " +
            " (desde < '{0}' AND hasta > '{0}') OR " +
            " (desde > '{0}' AND hasta < '{1}') OR " +
            " (desde > '{0}' AND desde < '{1}') " +
            " AND profesional_dni = {2} AND especialidad_codigo = {3}";
            query = String.Format(query, from, to, dni, professionCode);
            return Sql.query(query).Rows.Count > 0;
        }

        public static DataTable getTimetableByAgenda(int agendaId)
        {
            String query = "SELECT CASE " +
               "WHEN dia = 1 THEN 'Lunes' " +
               "WHEN dia = 2 THEN 'Martes' " +
               "WHEN dia = 3 THEN 'Miercoles' " +
               "WHEN dia = 4 THEN 'Jueves' " +
               "WHEN dia = 5 THEN 'Viernes' " +
               "WHEN dia = 6 THEN 'Sabado' " +
               "WHEN dia = 7 THEN 'Domingo' " +
               "END as Dia, " +
               " CONVERT(VARCHAR(5),d.desde,108) as desde, CONVERT(VARCHAR(5),d.hasta,108) as hasta from group_by.Disponibilidad d " +
               " WHERE agenda = {0}";

            query = String.Format(query, agendaId);
            return Sql.query(query);
        }
    }
}
