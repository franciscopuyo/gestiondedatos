﻿using ClinicaFrba.util;
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
using ClinicaFrba.Abm_Especialidades_Medicas;
namespace ClinicaFrba.Registro_Llegada
{
    public partial class RegistroLlegada : Form
    {
        private BindingSource bindingSource;
        private SqlDataAdapter adapter;

        public RegistroLlegada()
        {
            InitializeComponent();
        }

        private void RegistroLlegada_Load(object sender, EventArgs e)
        {
            loadEspecialidades();
            loadProfesionales();
        }

        private void loadProfesionales()
        {
            SqlConnection connection = util.Sql.connect("gd");

            String query = "select nombre as Nombre, apellido as Apellido, Especialidades.descripcion, Profesionales.profesional_dni as Documento,'Seleccionar' as Seleccionar from  group_by.Profesionales, group_by.Especialidades, group_by.Medico_Especialidad, group_by.Personas_Detalle where Medico_Especialidad.profesional_dni = Profesionales.profesional_dni and Medico_Especialidad.especialidad_codigo = Especialidades.codigo and Personas_Detalle.dni = Profesionales.profesional_dni and Especialidades.descripcion = '{0}'";
            query = String.Format(query, especialidadesCombo.Text);
            adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            dataGridView1.DataSource = bindingSource;

            adapter.Update(dataTable);
        }

        private void loadEspecialidades()
        {
            DataTable especialidades = util.Sql.query("select descripcion from group_by.Especialidades order by descripcion ASC");
            List<String> options = new List<string>();
            for (int i = 0; i < especialidades.Rows.Count; i++)
            {
                options.Add(especialidades.Rows[i][0].ToString());
            }
            especialidadesCombo.DataSource = options;
        }

        private void volver_Click(object sender, EventArgs e)
        {
            Session.mainMenu(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String accion = dataGridView1.Columns[e.ColumnIndex].HeaderText.ToString();
            String dni = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            String nombre = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            String apellido = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.Hide();

            SeleccionarTurno select = new SeleccionarTurno(dni, Profession.getCodeByDescription(especialidadesCombo.Text));
            select.Show();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            loadProfesionales();
        }
    }
}
