namespace ClinicaFrba.Compra_Bono
{
    partial class CompraAdministrativo
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.continuar = new System.Windows.Forms.Button();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nroAfiliado = new System.Windows.Forms.TextBox();
            this.errorProviderAfiliado = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCantidad = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAfiliado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de afiliado";
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(160, 140);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 7;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // continuar
            // 
            this.continuar.Location = new System.Drawing.Point(63, 140);
            this.continuar.Name = "continuar";
            this.continuar.Size = new System.Drawing.Size(75, 23);
            this.continuar.TabIndex = 6;
            this.continuar.Text = "Continuar";
            this.continuar.UseVisualStyleBackColor = true;
            this.continuar.Click += new System.EventHandler(this.continuar_Click);
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(177, 62);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(58, 20);
            this.cantidad.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad de bonos a comprar";
            // 
            // nroAfiliado
            // 
            this.nroAfiliado.Location = new System.Drawing.Point(177, 20);
            this.nroAfiliado.Name = "nroAfiliado";
            this.nroAfiliado.Size = new System.Drawing.Size(100, 20);
            this.nroAfiliado.TabIndex = 8;
            // 
            // errorProviderAfiliado
            // 
            this.errorProviderAfiliado.ContainerControl = this;
            // 
            // errorProviderCantidad
            // 
            this.errorProviderCantidad.ContainerControl = this;
            // 
            // CompraAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 191);
            this.Controls.Add(this.nroAfiliado);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.continuar);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CompraAdministrativo";
            this.Text = "Compra de bono";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAfiliado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button continuar;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nroAfiliado;
        private System.Windows.Forms.ErrorProvider errorProviderAfiliado;
        private System.Windows.Forms.ErrorProvider errorProviderCantidad;
    }
}