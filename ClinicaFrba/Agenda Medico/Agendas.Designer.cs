namespace ClinicaFrba.Agenda_Medico
{
    partial class Agendas
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
            this.timetablesGrid = new System.Windows.Forms.DataGridView();
            this.labelProfesional = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timetablesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // timetablesGrid
            // 
            this.timetablesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timetablesGrid.Location = new System.Drawing.Point(1, 70);
            this.timetablesGrid.Name = "timetablesGrid";
            this.timetablesGrid.Size = new System.Drawing.Size(626, 226);
            this.timetablesGrid.TabIndex = 0;
            this.timetablesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelProfesional
            // 
            this.labelProfesional.AutoSize = true;
            this.labelProfesional.Location = new System.Drawing.Point(115, 44);
            this.labelProfesional.Name = "labelProfesional";
            this.labelProfesional.Size = new System.Drawing.Size(32, 13);
            this.labelProfesional.TabIndex = 52;
            this.labelProfesional.Text = "xxxxx";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(7, 44);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 13);
            this.label21.TabIndex = 51;
            this.label21.Text = "Profesional: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Agendas";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(283, 313);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 53;
            this.back.Text = "Volver";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Agendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 352);
            this.Controls.Add(this.back);
            this.Controls.Add(this.labelProfesional);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timetablesGrid);
            this.Name = "Agendas";
            this.Text = "Agendas";
            this.Load += new System.EventHandler(this.Agendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timetablesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView timetablesGrid;
        private System.Windows.Forms.Label labelProfesional;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
    }
}