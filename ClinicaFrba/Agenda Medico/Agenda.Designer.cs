namespace ClinicaFrba.Agenda_Medico
{
    partial class Agenda
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
            this.timetableGrid = new System.Windows.Forms.DataGridView();
            this.labelEspecialidad = new System.Windows.Forms.Label();
            this.labelProfesional = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tournsGrid = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.periodGrid = new System.Windows.Forms.DataGridView();
            this.from = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.timetableGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agenda";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timetableGrid
            // 
            this.timetableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timetableGrid.Location = new System.Drawing.Point(72, 86);
            this.timetableGrid.Name = "timetableGrid";
            this.timetableGrid.Size = new System.Drawing.Size(403, 132);
            this.timetableGrid.TabIndex = 0;
            this.timetableGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.timetableGrid_CellContentClick);
            // 
            // labelEspecialidad
            // 
            this.labelEspecialidad.AutoSize = true;
            this.labelEspecialidad.Location = new System.Drawing.Point(123, 59);
            this.labelEspecialidad.Name = "labelEspecialidad";
            this.labelEspecialidad.Size = new System.Drawing.Size(37, 13);
            this.labelEspecialidad.TabIndex = 50;
            this.labelEspecialidad.Text = "xxxxxx";
            this.labelEspecialidad.Click += new System.EventHandler(this.labelEspecialidad_Click);
            // 
            // labelProfesional
            // 
            this.labelProfesional.AutoSize = true;
            this.labelProfesional.Location = new System.Drawing.Point(120, 34);
            this.labelProfesional.Name = "labelProfesional";
            this.labelProfesional.Size = new System.Drawing.Size(32, 13);
            this.labelProfesional.TabIndex = 49;
            this.labelProfesional.Text = "xxxxx";
            this.labelProfesional.Click += new System.EventHandler(this.labelProfesional_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(12, 59);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 13);
            this.label22.TabIndex = 48;
            this.label22.Text = "Especialidad: ";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(12, 34);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 13);
            this.label21.TabIndex = 47;
            this.label21.Text = "Profesional: ";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Horarios disponibles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Turnos";
            // 
            // tournsGrid
            // 
            this.tournsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tournsGrid.Location = new System.Drawing.Point(72, 309);
            this.tournsGrid.Name = "tournsGrid";
            this.tournsGrid.Size = new System.Drawing.Size(403, 165);
            this.tournsGrid.TabIndex = 53;
            this.tournsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(72, 659);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 54;
            this.back.Text = "Volver";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(340, 659);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(135, 23);
            this.cancelButton.TabIndex = 55;
            this.cancelButton.Text = "Cancelar Periodo";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Periodos Cancelados";
            // 
            // periodGrid
            // 
            this.periodGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.periodGrid.Location = new System.Drawing.Point(72, 503);
            this.periodGrid.Name = "periodGrid";
            this.periodGrid.Size = new System.Drawing.Size(403, 150);
            this.periodGrid.TabIndex = 57;
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(60, 252);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(200, 20);
            this.from.TabIndex = 58;
            this.from.ValueChanged += new System.EventHandler(this.from_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Desde:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Hasta: ";
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(331, 251);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(200, 20);
            this.to.TabIndex = 61;
            this.to.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 695);
            this.Controls.Add(this.to);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.from);
            this.Controls.Add(this.periodGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.back);
            this.Controls.Add(this.tournsGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelEspecialidad);
            this.Controls.Add(this.labelProfesional);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timetableGrid);
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timetableGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView timetableGrid;
        private System.Windows.Forms.Label labelEspecialidad;
        private System.Windows.Forms.Label labelProfesional;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tournsGrid;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView periodGrid;
        private System.Windows.Forms.DateTimePicker from;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker to;
    }
}