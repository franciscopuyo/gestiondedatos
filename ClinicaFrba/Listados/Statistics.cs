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

namespace ClinicaFrba.Listados
{
    public partial class Statistics : Form
    {
        private BindingSource bindingSource;
        private SqlDataAdapter adapter;

        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            hidePlanYEspeciaidadFilters();

            loadStatisticOptions();
            loadYearOptions();
            loadSemesterOptions();
        }

        private void loadStatisticOptions()
        {
            String op1 = "Especialidades más canceladas";
            String op2 = "Profesionales más consultados";
            String op3 = "Profesionales con menos horas trabajadas";
            String op4 = "Afiliados con más bonos comprados";
            String op5 = "Especialidades con más bonos de consulta utilizados";

            List<String> options = new List<string>();
            options.Add(op1);
            options.Add(op2);
            options.Add(op3);
            options.Add(op4);
            options.Add(op5);

            tipoDeListado.DataSource = options;
        }

        private void loadYearOptions()
        {
            DataTable anios = util.Sql.query("select distinct YEAR(fecha) from Turnos union select YEAR(fecha_efectivizacion) from Atencion_Medica union select YEAR(fecha) from Compras");
            List<String> options = new List<string>();
            for (int i = 0; i < anios.Rows.Count; i++)
            {
                options.Add(anios.Rows[i][0].ToString());
            }
            anio.DataSource = options;
        }

        private void loadSemesterOptions()
        {
            String op1 = "1";
            String op2 = "2";

            List<String> options = new List<string>();
            options.Add(op1);
            options.Add(op2);

            semestre.DataSource = options;
        }

        private void volver_Click(object sender, EventArgs e)
        {
            ClinicaFrba.util.Session.mainMenu(this);
        }

        private void consultar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = util.Sql.connect("gd");
            String query = constructQuery();
            adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;
            adapter.Update(dataTable);
        }

        private String especialidadesMasCanceladas()
        {
            String query = "select top 5 e.descripcion as Especialidad,(select COUNT(*) from Cancelaciones, Turnos where Cancelaciones.turno_nro = Turnos.numero and Turnos.especialidad_codigo = e.codigo and YEAR(Turnos.fecha) = {0} and MONTH(Turnos.fecha) BETWEEN {1}) as Cancelaciones from  Especialidades e order by Cancelaciones desc";
            return String.Format(query, anio.Text, getSemestreInterval());
        }

        private String profesionalesMAsConsultados()
        {
            String query = "select top 5 e.descripcion as Especialidad,(select COUNT(*) from Cancelaciones, Turnos where Cancelaciones.turno_nro = Turnos.numero and Turnos.especialidad_codigo = e.codigo and YEAR(Turnos.fecha) = {0} and MONTH(Turnos.fecha) BETWEEN {1}) as Cancelaciones from  Especialidades e order by Cancelaciones desc";
            return String.Format(query, anio.Text, getSemestreInterval());
        }

        private String listProfesionalesMenosHoras()
        {
            String query = "select top 5 e.descripcion as Especialidad,(select COUNT(*) from Cancelaciones, Turnos where Cancelaciones.turno_nro = Turnos.numero and Turnos.especialidad_codigo = e.codigo and YEAR(Turnos.fecha) = {0} and MONTH(Turnos.fecha) BETWEEN {1}) as Cancelaciones from  Especialidades e order by Cancelaciones desc";
            return String.Format(query, anio.Text, getSemestreInterval());
        }

        private String afiliadosConMasBonos()
        {
            String query = "select top 5 e.descripcion as Especialidad,(select COUNT(*) from Cancelaciones, Turnos where Cancelaciones.turno_nro = Turnos.numero and Turnos.especialidad_codigo = e.codigo and YEAR(Turnos.fecha) = {0} and MONTH(Turnos.fecha) BETWEEN {1}) as Cancelaciones from  Especialidades e order by Cancelaciones desc";
            return String.Format(query, anio.Text, getSemestreInterval());
        }

        private String especialidadesConMasBonos()
        {
            String query = "select top 5 e.descripcion as Especialidad,(select COUNT(*) from Cancelaciones, Turnos where Cancelaciones.turno_nro = Turnos.numero and Turnos.especialidad_codigo = e.codigo and YEAR(Turnos.fecha) = {0} and MONTH(Turnos.fecha) BETWEEN {1}) as Cancelaciones from  Especialidades e order by Cancelaciones desc";
            return String.Format(query, anio.Text, getSemestreInterval());
        }

        private String constructQuery()
        {
            String listado = tipoDeListado.Text;
            String query = "";

            if (listado == "Especialidades más canceladas")
            {
                query = especialidadesMasCanceladas();
            }
            if (listado == "Profesionales más consultados")
            {
                query = profesionalesMAsConsultados();
            }
            if (listado == "Profesionales con menos horas trabajadas")
            {
                query = listProfesionalesMenosHoras();
            }
            if (listado == "Afiliados con más bonos comprados")
            {
                query = afiliadosConMasBonos();
            }
            if (listado == "Especialidades con más bonos de consulta utilizados")
            {
                query = especialidadesConMasBonos();

            }
            return query;
        }

        private void hidePlanYEspeciaidadFilters(){
            planLabel.Hide();
            planMedico.Hide();
            especialidadLabel.Hide();
            especialidadCombo.Hide();
        }

        private void showPlanYEspeciaidadFilters()
        {
            planLabel.Show();
            planMedico.Show();
            especialidadLabel.Show();
            especialidadCombo.Show();
        }

        private void tipoDeListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            String listado = tipoDeListado.Text;

            if (listado == "Profesionales con menos horas trabajadas")
            {
                showPlanYEspeciaidadFilters();
            }
            else
            {
                hidePlanYEspeciaidadFilters();
            }
        }

        private String getSemestreInterval()
        {
            String semestreText = semestre.Text;
            if (semestreText == "1") 
            {
                return "1 AND 6";
            } 
            else{
                return "7 AND 12";
            }
        }

    }
}
