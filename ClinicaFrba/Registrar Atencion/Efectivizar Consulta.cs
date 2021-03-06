﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registrar_Atencion
{
    public partial class Form1 : Form
    {
        private int atentionCode;
        private int dni;
        public Form1(int atentionCode, int dni)
        {
            this.atentionCode = atentionCode;
            this.dni = dni;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }

        private void simpthompsView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void addSimpthom_Click(object sender, EventArgs e)
        {
            simpthompsView.Items.Add(simpthomsInput.Text);
            simpthomsInput.Text = "";
        }

        private void addDiagnostic_Click(object sender, EventArgs e)
        {
            diagnosticView.Items.Add(diagnosticInput.Text);
            diagnosticInput.Text = "";
        }

        private void save_Click(object sender, EventArgs e)
        {
            MedicalAtention.update(atentionCode, doneCheckbox.Checked, dateTimePicker1.Value, simpthompsView.Items, diagnosticView.Items);
            MessageBox.Show("Atencion médica actualizada correctamente");
            this.Hide();
            SeleccionConsulta seleccion = new SeleccionConsulta(dni);
            seleccion.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeleccionConsulta seleccion = new SeleccionConsulta(dni);
            seleccion.Show();
        }
    }
}
