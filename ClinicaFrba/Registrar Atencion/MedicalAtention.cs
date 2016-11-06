using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaFrba.util;
using System.Data;
using System.Windows.Forms;

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

        public static void update(int tourn, bool done, DateTime doneDate, ListView.ListViewItemCollection simpthoms, ListView.ListViewItemCollection diagnostic)
        {
            int realizada = done ? 1 : 0; 
            String query = "UPDATE Atencion_Medica set realizada = {0}, fecha_efectivizacion = '{1}' where turno_numero = {2}";
            query = String.Format(query, realizada, doneDate, tourn);
            Sql.query(query);

            if (done)
            {
                foreach (ListViewItem item in simpthoms)
                {
                    query = "INSERT INTO Sintomas (atencion, sintoma) VALUES ({0}, '{1}')";
                    query = String.Format(query, tourn, item.Text);
                    Sql.query(query);
                }

                foreach (ListViewItem item in diagnostic)
                {
                    query = "INSERT INTO Diagnosticos (atencion, diagnostico) VALUES ({0}, '{1}')";
                    query = String.Format(query, tourn, item.Text);
                    Sql.query(query);
                }
            }
        }
    }
}
