namespace ClinicaFrba.Listados
{
    partial class Statistics
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
            this.volver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.anio = new System.Windows.Forms.ComboBox();
            this.semestre = new System.Windows.Forms.ComboBox();
            this.consultar = new System.Windows.Forms.Button();
            this.tipoDeListado = new System.Windows.Forms.ComboBox();
            this.listado = new System.Windows.Forms.Label();
            this.planLabel = new System.Windows.Forms.Label();
            this.especialidadLabel = new System.Windows.Forms.Label();
            this.planMedico = new System.Windows.Forms.ComboBox();
            this.especialidadCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(396, 212);
            this.dataGridView1.TabIndex = 0;
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(37, 319);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 23);
            this.volver.TabIndex = 1;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Semestre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Año";
            // 
            // anio
            // 
            this.anio.FormattingEnabled = true;
            this.anio.Location = new System.Drawing.Point(73, 35);
            this.anio.Name = "anio";
            this.anio.Size = new System.Drawing.Size(57, 21);
            this.anio.TabIndex = 4;
            // 
            // semestre
            // 
            this.semestre.FormattingEnabled = true;
            this.semestre.Items.AddRange(new object[] {
            "1",
            "2"});
            this.semestre.Location = new System.Drawing.Point(193, 35);
            this.semestre.Name = "semestre";
            this.semestre.Size = new System.Drawing.Size(44, 21);
            this.semestre.TabIndex = 5;
            // 
            // consultar
            // 
            this.consultar.Location = new System.Drawing.Point(358, 319);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(75, 23);
            this.consultar.TabIndex = 6;
            this.consultar.Text = "Consultar";
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // tipoDeListado
            // 
            this.tipoDeListado.FormattingEnabled = true;
            this.tipoDeListado.Items.AddRange(new object[] {
            "1",
            "2"});
            this.tipoDeListado.Location = new System.Drawing.Point(73, 7);
            this.tipoDeListado.Name = "tipoDeListado";
            this.tipoDeListado.Size = new System.Drawing.Size(360, 21);
            this.tipoDeListado.TabIndex = 7;
            this.tipoDeListado.SelectedIndexChanged += new System.EventHandler(this.tipoDeListado_SelectedIndexChanged);
            // 
            // listado
            // 
            this.listado.AutoSize = true;
            this.listado.Location = new System.Drawing.Point(26, 11);
            this.listado.Name = "listado";
            this.listado.Size = new System.Drawing.Size(41, 13);
            this.listado.TabIndex = 8;
            this.listado.Text = "Listado";
            // 
            // planLabel
            // 
            this.planLabel.AutoSize = true;
            this.planLabel.Location = new System.Drawing.Point(37, 69);
            this.planLabel.Name = "planLabel";
            this.planLabel.Size = new System.Drawing.Size(28, 13);
            this.planLabel.TabIndex = 9;
            this.planLabel.Text = "Plan";
            // 
            // especialidadLabel
            // 
            this.especialidadLabel.AutoSize = true;
            this.especialidadLabel.Location = new System.Drawing.Point(190, 69);
            this.especialidadLabel.Name = "especialidadLabel";
            this.especialidadLabel.Size = new System.Drawing.Size(67, 13);
            this.especialidadLabel.TabIndex = 10;
            this.especialidadLabel.Text = "Especialidad";
            // 
            // planMedico
            // 
            this.planMedico.FormattingEnabled = true;
            this.planMedico.Location = new System.Drawing.Point(73, 66);
            this.planMedico.Name = "planMedico";
            this.planMedico.Size = new System.Drawing.Size(111, 21);
            this.planMedico.TabIndex = 11;
            // 
            // especialidadCombo
            // 
            this.especialidadCombo.FormattingEnabled = true;
            this.especialidadCombo.Location = new System.Drawing.Point(263, 66);
            this.especialidadCombo.Name = "especialidadCombo";
            this.especialidadCombo.Size = new System.Drawing.Size(111, 21);
            this.especialidadCombo.TabIndex = 12;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 366);
            this.Controls.Add(this.especialidadCombo);
            this.Controls.Add(this.planMedico);
            this.Controls.Add(this.especialidadLabel);
            this.Controls.Add(this.planLabel);
            this.Controls.Add(this.listado);
            this.Controls.Add(this.tipoDeListado);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.semestre);
            this.Controls.Add(this.anio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Statistics";
            this.Text = "Consulta de listados";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox anio;
        private System.Windows.Forms.ComboBox semestre;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.ComboBox tipoDeListado;
        private System.Windows.Forms.Label listado;
        private System.Windows.Forms.Label planLabel;
        private System.Windows.Forms.Label especialidadLabel;
        private System.Windows.Forms.ComboBox planMedico;
        private System.Windows.Forms.ComboBox especialidadCombo;
    }
}