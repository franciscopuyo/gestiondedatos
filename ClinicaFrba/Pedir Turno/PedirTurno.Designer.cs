﻿namespace ClinicaFrba.Pedir_Turno
{
    partial class PedirTurno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buscar = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            this.especialidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.especialidadesCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(509, 242);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buscar
            // 
            this.buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buscar.Location = new System.Drawing.Point(468, 53);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 1;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(34, 355);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 23);
            this.volver.TabIndex = 2;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // especialidad
            // 
            this.especialidad.AutoSize = true;
            this.especialidad.Location = new System.Drawing.Point(31, 58);
            this.especialidad.Name = "especialidad";
            this.especialidad.Size = new System.Drawing.Size(67, 13);
            this.especialidad.TabIndex = 3;
            this.especialidad.Text = "Especialidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione el profesional con el que sera atendido";
            // 
            // especialidadesCombo
            // 
            this.especialidadesCombo.FormattingEnabled = true;
            this.especialidadesCombo.Location = new System.Drawing.Point(105, 53);
            this.especialidadesCombo.Name = "especialidadesCombo";
            this.especialidadesCombo.Size = new System.Drawing.Size(196, 21);
            this.especialidadesCombo.TabIndex = 5;
            // 
            // PedirTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 390);
            this.Controls.Add(this.especialidadesCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.especialidad);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PedirTurno";
            this.Text = "Pedir turno";
            this.Load += new System.EventHandler(this.PedirTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.Label especialidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox especialidadesCombo;
    }
}