namespace ClinicaFrba.Registrar_Atencion
{
    partial class SeleccionConsulta
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
            this.especialidadesCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.atentionsGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.atentionsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // especialidadesCombo
            // 
            this.especialidadesCombo.FormattingEnabled = true;
            this.especialidadesCombo.Location = new System.Drawing.Point(109, 79);
            this.especialidadesCombo.Name = "especialidadesCombo";
            this.especialidadesCombo.Size = new System.Drawing.Size(121, 21);
            this.especialidadesCombo.TabIndex = 0;
            this.especialidadesCombo.SelectedIndexChanged += new System.EventHandler(this.especialidadesCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestion de consultas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Busca la consulta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Especialidad";
            // 
            // atentionsGrid
            // 
            this.atentionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.atentionsGrid.Location = new System.Drawing.Point(0, 120);
            this.atentionsGrid.Name = "atentionsGrid";
            this.atentionsGrid.Size = new System.Drawing.Size(693, 215);
            this.atentionsGrid.TabIndex = 4;
            this.atentionsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.atentionsGrid_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SeleccionConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.atentionsGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.especialidadesCombo);
            this.Name = "SeleccionConsulta";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SeleccionConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.atentionsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox especialidadesCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView atentionsGrid;
        private System.Windows.Forms.Button button1;
    }
}