namespace ClinicaFrba.Abm_Afiliado
{
    partial class PreguntarDatosResponsables
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
            this.label1 = new System.Windows.Forms.Label();
            this.cargados = new System.Windows.Forms.Label();
            this.SI = new System.Windows.Forms.Button();
            this.NO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cargar afiliado a cargo?";
            // 
            // cargados
            // 
            this.cargados.AutoSize = true;
            this.cargados.Location = new System.Drawing.Point(157, 43);
            this.cargados.Name = "cargados";
            this.cargados.Size = new System.Drawing.Size(88, 13);
            this.cargados.TabIndex = 1;
            this.cargados.Text = "(x de x cargados)";
            // 
            // SI
            // 
            this.SI.Location = new System.Drawing.Point(49, 98);
            this.SI.Name = "SI";
            this.SI.Size = new System.Drawing.Size(75, 23);
            this.SI.TabIndex = 2;
            this.SI.Text = "SI";
            this.SI.UseVisualStyleBackColor = true;
            this.SI.Click += new System.EventHandler(this.SI_Click);
            // 
            // NO
            // 
            this.NO.Location = new System.Drawing.Point(160, 98);
            this.NO.Name = "NO";
            this.NO.Size = new System.Drawing.Size(75, 23);
            this.NO.TabIndex = 3;
            this.NO.Text = "NO";
            this.NO.UseVisualStyleBackColor = true;
            this.NO.Click += new System.EventHandler(this.NO_Click);
            // 
            // PreguntarDatosResponsables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 161);
            this.Controls.Add(this.NO);
            this.Controls.Add(this.SI);
            this.Controls.Add(this.cargados);
            this.Controls.Add(this.label1);
            this.Name = "PreguntarDatosResponsables";
            this.Text = "PreguntarDatosResponsables";
            this.Load += new System.EventHandler(this.PreguntarDatosResponsables_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cargados;
        private System.Windows.Forms.Button SI;
        private System.Windows.Forms.Button NO;
    }
}