using ClinicaFrba.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registro_Llegada
{
    public partial class SeleccionarBono : Form
    {
        private BindingSource bindingSource;
        private SqlDataAdapter adapter;

        private string nroTurno;
        private string dniAfiliado;

        public SeleccionarBono(string nroTurno, String dniAfiliado)
        {
            InitializeComponent();
            this.nroTurno = nroTurno;
            this.dniAfiliado = dniAfiliado;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Session.mainMenu(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String nroBono = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            String query = "INSERT INTO group_by.Atencion_Medica(fecha_llegada, nro_bono, turno_numero) VALUES(group_by.GETDATECUSTOM(), {0}, {1})";
            query = String.Format(query, nroBono, nroTurno);
            Sql.query(query);

            MessageBox.Show("Registro de llegada exitoso");
            Session.mainMenu(this);
        }

        private void SeleccionarBono_Load(object sender, EventArgs e)
        {
            SqlConnection connection = util.Sql.connect("gd");

            String query = @"select distinct  Bonos.nro_bono as Numero_De_Bono, p.descripcion as Plan_Medico, 'Seleccionar' as Seleccionar from group_by.Bonos, group_by.Afiliados a, group_by.Planes_Medicos p where
(bonos.afiliado_dni = a.afiliado_dni
or
Bonos.afiliado_dni = a.afiliado_conyugue
or
Bonos.afiliado_dni = a.afiliado_responsable
or
Bonos.afiliado_dni in (SELECT a2.afiliado_dni from group_by.Afiliados a2 where afiliado_responsable = a.afiliado_dni)
or
Bonos.afiliado_dni in (SELECT a3.afiliado_dni from group_by.Afiliados a3 where afiliado_conyugue = a.afiliado_dni)
)
and
a.afiliado_dni = {0}
and
Bonos.nro_consulta_medica IS NULL
and
p.codigo = Bonos.plan_codigo";
            query = String.Format(query, dniAfiliado);
            query = query.Replace("\r", " ");
            query = query.Replace("\n", " ");
            adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            dataGridView1.DataSource = bindingSource;

            adapter.Update(dataTable);
        }
    }
}
