﻿namespace ClinicaFrba.Registrar_Atencion
{
    partial class Form1
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
            this.doneCheckbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.simpthomsInput = new System.Windows.Forms.TextBox();
            this.addSimpthom = new System.Windows.Forms.Button();
            this.simpthomsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addDiagnostic = new System.Windows.Forms.Button();
            this.diagnosticInput = new System.Windows.Forms.TextBox();
            this.diagnosticView = new System.Windows.Forms.ListView();
            this.simpthompsView = new System.Windows.Forms.ListView();
            this.save = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // doneCheckbox
            // 
            this.doneCheckbox.AutoSize = true;
            this.doneCheckbox.Location = new System.Drawing.Point(12, 52);
            this.doneCheckbox.Name = "doneCheckbox";
            this.doneCheckbox.Size = new System.Drawing.Size(73, 17);
            this.doneCheckbox.TabIndex = 0;
            this.doneCheckbox.Text = "Realizada";
            this.doneCheckbox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Efectivizar Consulta";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 102);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(322, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de realización";
            // 
            // simpthomsInput
            // 
            this.simpthomsInput.Location = new System.Drawing.Point(121, 254);
            this.simpthomsInput.Name = "simpthomsInput";
            this.simpthomsInput.Size = new System.Drawing.Size(388, 20);
            this.simpthomsInput.TabIndex = 5;
            this.simpthomsInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addSimpthom
            // 
            this.addSimpthom.Location = new System.Drawing.Point(525, 251);
            this.addSimpthom.Name = "addSimpthom";
            this.addSimpthom.Size = new System.Drawing.Size(28, 23);
            this.addSimpthom.TabIndex = 6;
            this.addSimpthom.Text = "+";
            this.addSimpthom.UseVisualStyleBackColor = true;
            this.addSimpthom.Click += new System.EventHandler(this.addSimpthom_Click);
            // 
            // simpthomsLabel
            // 
            this.simpthomsLabel.AutoSize = true;
            this.simpthomsLabel.Location = new System.Drawing.Point(12, 165);
            this.simpthomsLabel.Name = "simpthomsLabel";
            this.simpthomsLabel.Size = new System.Drawing.Size(88, 13);
            this.simpthomsLabel.TabIndex = 7;
            this.simpthomsLabel.Text = "Lista de sintomas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lista de Diagnósticos";
            // 
            // addDiagnostic
            // 
            this.addDiagnostic.Location = new System.Drawing.Point(525, 388);
            this.addDiagnostic.Name = "addDiagnostic";
            this.addDiagnostic.Size = new System.Drawing.Size(28, 23);
            this.addDiagnostic.TabIndex = 10;
            this.addDiagnostic.Text = "+";
            this.addDiagnostic.UseVisualStyleBackColor = true;
            this.addDiagnostic.Click += new System.EventHandler(this.addDiagnostic_Click);
            // 
            // diagnosticInput
            // 
            this.diagnosticInput.Location = new System.Drawing.Point(121, 388);
            this.diagnosticInput.Name = "diagnosticInput";
            this.diagnosticInput.Size = new System.Drawing.Size(388, 20);
            this.diagnosticInput.TabIndex = 9;
            // 
            // diagnosticView
            // 
            this.diagnosticView.Location = new System.Drawing.Point(12, 321);
            this.diagnosticView.Name = "diagnosticView";
            this.diagnosticView.Size = new System.Drawing.Size(541, 61);
            this.diagnosticView.TabIndex = 12;
            this.diagnosticView.UseCompatibleStateImageBehavior = false;
            // 
            // simpthompsView
            // 
            this.simpthompsView.Location = new System.Drawing.Point(12, 187);
            this.simpthompsView.Name = "simpthompsView";
            this.simpthompsView.Size = new System.Drawing.Size(541, 61);
            this.simpthompsView.TabIndex = 11;
            this.simpthompsView.UseCompatibleStateImageBehavior = false;
            this.simpthompsView.SelectedIndexChanged += new System.EventHandler(this.simpthompsView_SelectedIndexChanged);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(362, 428);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 13;
            this.save.Text = "Guardar";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(90, 428);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 14;
            this.back.Text = "Volver";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Agregar Sintoma:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Agregar Diagnostico:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 463);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.back);
            this.Controls.Add(this.save);
            this.Controls.Add(this.diagnosticView);
            this.Controls.Add(this.simpthompsView);
            this.Controls.Add(this.addDiagnostic);
            this.Controls.Add(this.diagnosticInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.simpthomsLabel);
            this.Controls.Add(this.addSimpthom);
            this.Controls.Add(this.simpthomsInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doneCheckbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox doneCheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox simpthomsInput;
        private System.Windows.Forms.Button addSimpthom;
        private System.Windows.Forms.Label simpthomsLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addDiagnostic;
        private System.Windows.Forms.TextBox diagnosticInput;
        private System.Windows.Forms.ListView diagnosticView;
        private System.Windows.Forms.ListView simpthompsView;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}