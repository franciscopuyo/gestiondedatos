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
using ClinicaFrba.util;

namespace ClinicaFrba.Registro_Llegada
{
    public partial class SeleccionarTurno : Form
    {
        private BindingSource bindingSource;
        private SqlDataAdapter adapter;

        private string dniProfesional;
        private int esp;

        public SeleccionarTurno(string dni, int esp)
        {
            InitializeComponent();
            this.dniProfesional = dni;
            this.esp = esp;
        }

        private void loadTurnos()
        {
            SqlConnection connection = util.Sql.connect("gd");

            String query = "select nombre as Nombre, apellido as Apellido, t.afiliado_dni as DNI_Afiliado,t.numero as Numero_Turno, 'Seleccionar' as Seleccionar from group_by.Turnos t JOIN group_by.Personas_Detalle pd ON (pd.dni = t.afiliado_dni) LEFT JOIN group_by.Cancelaciones c ON (c.turno_nro = t.numero) LEFT JOIN group_by.Atencion_medica am ON (am.turno_numero = t.numero) where am.turno_numero IS NULL AND c.turno_nro IS NULL AND t.profesional_dni = {0} and t.especialidad_codigo = {1} and CONVERT(DATE, fecha) = CONVERT(DATE, group_by.GETDATECUSTOM())";
            query = String.Format(query, dniProfesional, esp);
            adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            tournsGrid.DataSource = bindingSource;

            adapter.Update(dataTable);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SeleccionarTurno_Load(object sender, EventArgs e)
        {
            loadTurnos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String nroTurno = tournsGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            String dniAfiliado = tournsGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.Hide();

            SeleccionarBono s = new SeleccionarBono(nroTurno, dniAfiliado);
            s.Show();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            Session.mainMenu(this);
        }
    }
}
