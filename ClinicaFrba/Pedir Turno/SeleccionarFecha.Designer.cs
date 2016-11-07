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
            this.components = new System.ComponentModel.Container();
            this.titulo = new System.Windows.Forms.Label();
            this.volver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timetableGrid = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.nroAfiliado = new System.Windows.Forms.TextBox();
            this.labelAfiliado = new System.Windows.Forms.Label();
            this.errorProviderAfiliado = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.timetableGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAfiliado)).BeginInit();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Horarios de atención";
            // 
            // timetableGrid
            // 
            this.timetableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timetableGrid.Location = new System.Drawing.Point(83, 132);
            this.timetableGrid.Name = "timetableGrid";
            this.timetableGrid.Size = new System.Drawing.Size(403, 132);
            this.timetableGrid.TabIndex = 52;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(128, 281);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Elegir fecha:";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(377, 342);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 56;
            this.save.Text = "Pedir Turno";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // nroAfiliado
            // 
            this.nroAfiliado.Location = new System.Drawing.Point(108, 66);
            this.nroAfiliado.Name = "nroAfiliado";
            this.nroAfiliado.Size = new System.Drawing.Size(171, 20);
            this.nroAfiliado.TabIndex = 57;
            // 
            // labelAfiliado
            // 
            this.labelAfiliado.AutoSize = true;
            this.labelAfiliado.Location = new System.Drawing.Point(43, 73);
            this.labelAfiliado.Name = "labelAfiliado";
            this.labelAfiliado.Size = new System.Drawing.Size(59, 13);
            this.labelAfiliado.TabIndex = 58;
            this.labelAfiliado.Text = "Nº Afiliado:";
            // 
            // errorProviderAfiliado
            // 
            this.errorProviderAfiliado.ContainerControl = this;
            // 
            // SeleccionarFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 409);
            this.Controls.Add(this.labelAfiliado);
            this.Controls.Add(this.nroAfiliado);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timetableGrid);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.titulo);
            this.Name = "SeleccionarFecha";
            this.Text = "Seleccionar fecha";
            this.Load += new System.EventHandler(this.SeleccionarFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timetableGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAfiliado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView timetableGrid;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox nroAfiliado;
        private System.Windows.Forms.Label labelAfiliado;
        private System.Windows.Forms.ErrorProvider errorProviderAfiliado;
    }
}