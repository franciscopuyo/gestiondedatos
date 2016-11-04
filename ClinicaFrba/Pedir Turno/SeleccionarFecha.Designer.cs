namespace ClinicaFrba.Pedir_Turno
{
    partial class SeleccionarFecha
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
            this.titulo = new System.Windows.Forms.Label();
            this.volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Location = new System.Drawing.Point(40, 37);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(312, 13);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Pidiendo turno con medico ALBERTO JUAREZ DE LAS ROSAS";
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(59, 342);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 23);
            this.volver.TabIndex = 1;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // SeleccionarFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 409);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.titulo);
            this.Name = "SeleccionarFecha";
            this.Text = "Seleccionar fecha";
            this.Load += new System.EventHandler(this.SeleccionarFecha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button volver;
    }
}