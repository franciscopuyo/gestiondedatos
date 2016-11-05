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
            String query = "INSERT INTO Agendas (desde, hasta, especialidad_codigo, profesional_dni) " +
                "VALUES ('{0}','{1}',{2},{3})";
            query = String.Format(query, from.Date.ToString("d"), to.Date.ToString("d"), professionId, dni);
            Sql.query(query);
        }

        public static void addWorkDay(int day, int professionId, int dni, DateTime from, DateTime to)
        {
            String query = "INSERT INTO Disponibilidad (dia, desde, hasta, especialidad_codigo, profesional_dni) " +
                "VALUES ({0},'{1}','{2}',{3},{4})";
            query = String.Format(query, day.ToString(), from.TimeOfDay.ToString(), to.TimeOfDay.ToString(), professionId, dni);
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
                "d.desde, d.hasta from Disponibilidad d JOIN Agendas a ON (d.profesional_dni = a.profesional_dni AND d.especialidad_codigo = a.especialidad_codigo) " +
                "WHERE d.especialidad_codigo = {0} AND d.profesional_dni = {1}";

            query = String.Format(query, professionId.ToString(), dni.ToString());
            return Sql.query(query);
        }

        public static DataTable getTimetables(int dni)
        {
            String query = "SELECT e.codigo, e.descripcion as Especialidad, ISNULL(a.desde, '') as Desde, ISNULL(a.hasta, '') as Hasta, CASE WHEN a.profesional_dni IS NULL THEN 'CREAR' ELSE 'CREADA' END as Crear, CASE WHEN a.profesional_dni IS NULL THEN 'X' ELSE 'VER' END as Ver from Medico_Especialidad me JOIN Especialidades e ON (e.codigo = me.especialidad_codigo) LEFT JOIN Agendas a ON (me.profesional_dni = a.profesional_dni AND me.especialidad_codigo = a.especialidad_codigo) " +
                "WHERE me.profesional_dni = {0}";

            query = String.Format(query, dni.ToString());
            return Sql.query(query);
        }

        public static void cancelPeriod(int dni, int professionCode, DateTime from, DateTime to, String reason)
        {
            String query = "INSERT INTO Periodos_Cancelados (desde, hasta, especialidad_codigo, profesional_dni) VALUES ('{0}','{1}',{2},{3})";
            query = String.Format(query, from, to, professionCode, dni);
            Sql.query(query);

            Turno.cancelarTurnosPorProfesional(dni, professionCode, reason, from, to);
        }
    }
}
