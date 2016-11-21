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
            this.to = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.DateTimePicker();
            this.periodGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tournsGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.especialidadesCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timetablesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // timetablesGrid
            // 
            this.timetablesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timetablesGrid.Location = new System.Drawing.Point(15, 119);
            this.timetablesGrid.Name = "timetablesGrid";
            this.timetablesGrid.Size = new System.Drawing.Size(506, 109);
            this.timetablesGrid.TabIndex = 0;
            this.timetablesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelProfesional
            // 
            this.labelProfesional.AutoSize = true;
            this.labelProfesional.Location = new System.Drawing.Point(118, 44);
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
            this.back.Location = new System.Drawing.Point(358, 573);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 53;
            this.back.Text = "Volver";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(321, 416);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(200, 20);
            this.to.TabIndex = 77;
            this.to.ValueChanged += new System.EventHandler(this.to_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "Hasta: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Desde:";
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(59, 417);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(200, 20);
            this.from.TabIndex = 74;
            this.from.ValueChanged += new System.EventHandler(this.from_ValueChanged);
            // 
            // periodGrid
            // 
            this.periodGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.periodGrid.Location = new System.Drawing.Point(15, 281);
            this.periodGrid.Name = "periodGrid";
            this.periodGrid.Size = new System.Drawing.Size(506, 88);
            this.periodGrid.TabIndex = 73;
            this.periodGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.periodGrid_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Periodos Cancelados";
            // 
            // tournsGrid
            // 
            this.tournsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tournsGrid.Location = new System.Drawing.Point(15, 449);
            this.tournsGrid.Name = "tournsGrid";
            this.tournsGrid.Size = new System.Drawing.Size(506, 101);
            this.tournsGrid.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Filtrar Turnos";
            // 
            // especialidadesCombo
            // 
            this.especialidadesCombo.FormattingEnabled = true;
            this.especialidadesCombo.Location = new System.Drawing.Point(118, 77);
            this.especialidadesCombo.Name = "especialidadesCombo";
            this.especialidadesCombo.Size = new System.Drawing.Size(151, 21);
            this.especialidadesCombo.TabIndex = 78;
            this.especialidadesCombo.SelectedIndexChanged += new System.EventHandler(this.especialidadesCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Especialidad:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 573);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 80;
            this.button1.Text = "Agregar Agenda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(310, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 28);
            this.button2.TabIndex = 81;
            this.button2.Text = "Cancelar periodo para este especialidad";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Agendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 620);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.especialidadesCombo);
            this.Controls.Add(this.to);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.from);
            this.Controls.Add(this.periodGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tournsGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.back);
            this.Controls.Add(this.labelProfesional);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timetablesGrid);
            this.Name = "Agendas";
            this.Text = "Agendas";
            this.Load += new System.EventHandler(this.Agendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timetablesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView timetablesGrid;
        private System.Windows.Forms.Label labelProfesional;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DateTimePicker to;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker from;
        private System.Windows.Forms.DataGridView periodGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tournsGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox especialidadesCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}