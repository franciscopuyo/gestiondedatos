namespace ClinicaFrba.Registro_Llegada
{
    partial class SeleccionarTurno
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
            this.tournsGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tournsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tournsGrid
            // 
            this.tournsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tournsGrid.Location = new System.Drawing.Point(60, 67);
            this.tournsGrid.Name = "tournsGrid";
            this.tournsGrid.Size = new System.Drawing.Size(459, 260);
            this.tournsGrid.TabIndex = 0;
            this.tournsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Turnos asignados para el dia de la fecha";
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(60, 374);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 23);
            this.volver.TabIndex = 5;
            this.volver.Text = "Cancelar";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // SeleccionarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 433);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tournsGrid);
            this.Name = "SeleccionarTurno";
            this.Text = "Seleccionar turno";
            this.Load += new System.EventHandler(this.SeleccionarTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tournsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tournsGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button volver;

    }
}