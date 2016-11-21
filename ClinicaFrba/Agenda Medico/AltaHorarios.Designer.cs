namespace ClinicaFrba.Agenda_Medico
{
    partial class AltaHorarios
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
            this.label2 = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.mondayFrom = new System.Windows.Forms.DateTimePicker();
            this.mondayTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tuesdayTo = new System.Windows.Forms.DateTimePicker();
            this.tuesdayFrom = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.wednesdayTo = new System.Windows.Forms.DateTimePicker();
            this.wednesdayFrom = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.mondayEnabled = new System.Windows.Forms.CheckBox();
            this.tuesdayEnabled = new System.Windows.Forms.CheckBox();
            this.wednesdayEnabled = new System.Windows.Forms.CheckBox();
            this.thursdayEnabled = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.thursdayTo = new System.Windows.Forms.DateTimePicker();
            this.thursdayFrom = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.fridayEnabled = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.fridayTo = new System.Windows.Forms.DateTimePicker();
            this.fridayFrom = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.saturdayEnabled = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.saturdayTo = new System.Windows.Forms.DateTimePicker();
            this.saturdayFrom = new System.Windows.Forms.DateTimePicker();
            this.label_sabado = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.errorProviderFrom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMondayFrom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMondayTo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTuesdayTo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTuesdayFrom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderWednesdayFrom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderWednesdayTo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderThursdayFrom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderThursdayTo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFridayFrom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFridayTo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSaturdayFrom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSaturdayTo = new System.Windows.Forms.ErrorProvider(this.components);
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.labelProfesional = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.especialidadesCombo = new System.Windows.Forms.ComboBox();
            this.labelEspecialidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMondayFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMondayTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTuesdayTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTuesdayFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWednesdayFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWednesdayTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderThursdayFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderThursdayTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFridayFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFridayTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSaturdayFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSaturdayTo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta Agenda";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desde";
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(58, 106);
            this.from.MinDate = new System.DateTime(2016, 11, 2, 0, 0, 0, 0);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(200, 20);
            this.from.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hasta";
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(315, 106);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(200, 20);
            this.to.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lunes";
            // 
            // mondayFrom
            // 
            this.mondayFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mondayFrom.Location = new System.Drawing.Point(58, 181);
            this.mondayFrom.Name = "mondayFrom";
            this.mondayFrom.ShowUpDown = true;
            this.mondayFrom.Size = new System.Drawing.Size(200, 20);
            this.mondayFrom.TabIndex = 6;
            this.mondayFrom.ValueChanged += new System.EventHandler(this.mondayFrom_ValueChanged);
            // 
            // mondayTo
            // 
            this.mondayTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mondayTo.Location = new System.Drawing.Point(315, 181);
            this.mondayTo.Name = "mondayTo";
            this.mondayTo.ShowUpDown = true;
            this.mondayTo.Size = new System.Drawing.Size(200, 20);
            this.mondayTo.TabIndex = 7;
            this.mondayTo.ValueChanged += new System.EventHandler(this.mondayTo_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hasta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Desde";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Hasta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Desde";
            // 
            // tuesdayTo
            // 
            this.tuesdayTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tuesdayTo.Location = new System.Drawing.Point(315, 238);
            this.tuesdayTo.Name = "tuesdayTo";
            this.tuesdayTo.ShowUpDown = true;
            this.tuesdayTo.Size = new System.Drawing.Size(200, 20);
            this.tuesdayTo.TabIndex = 12;
            this.tuesdayTo.ValueChanged += new System.EventHandler(this.tuesdayTo_ValueChanged);
            // 
            // tuesdayFrom
            // 
            this.tuesdayFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tuesdayFrom.Location = new System.Drawing.Point(58, 238);
            this.tuesdayFrom.Name = "tuesdayFrom";
            this.tuesdayFrom.ShowUpDown = true;
            this.tuesdayFrom.Size = new System.Drawing.Size(200, 20);
            this.tuesdayFrom.TabIndex = 11;
            this.tuesdayFrom.ValueChanged += new System.EventHandler(this.tuesdayFrom_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Martes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(272, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Hasta";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Desde";
            // 
            // wednesdayTo
            // 
            this.wednesdayTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.wednesdayTo.Location = new System.Drawing.Point(315, 296);
            this.wednesdayTo.Name = "wednesdayTo";
            this.wednesdayTo.ShowUpDown = true;
            this.wednesdayTo.Size = new System.Drawing.Size(200, 20);
            this.wednesdayTo.TabIndex = 17;
            this.wednesdayTo.ValueChanged += new System.EventHandler(this.wednesdayTo_ValueChanged);
            // 
            // wednesdayFrom
            // 
            this.wednesdayFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.wednesdayFrom.Location = new System.Drawing.Point(58, 296);
            this.wednesdayFrom.Name = "wednesdayFrom";
            this.wednesdayFrom.ShowUpDown = true;
            this.wednesdayFrom.Size = new System.Drawing.Size(200, 20);
            this.wednesdayFrom.TabIndex = 16;
            this.wednesdayFrom.ValueChanged += new System.EventHandler(this.wednesdayFrom_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Miercoles";
            // 
            // mondayEnabled
            // 
            this.mondayEnabled.AutoSize = true;
            this.mondayEnabled.Location = new System.Drawing.Point(72, 155);
            this.mondayEnabled.Name = "mondayEnabled";
            this.mondayEnabled.Size = new System.Drawing.Size(73, 17);
            this.mondayEnabled.TabIndex = 20;
            this.mondayEnabled.Text = "Habilitado";
            this.mondayEnabled.UseVisualStyleBackColor = true;
            // 
            // tuesdayEnabled
            // 
            this.tuesdayEnabled.AutoSize = true;
            this.tuesdayEnabled.Location = new System.Drawing.Point(72, 215);
            this.tuesdayEnabled.Name = "tuesdayEnabled";
            this.tuesdayEnabled.Size = new System.Drawing.Size(73, 17);
            this.tuesdayEnabled.TabIndex = 21;
            this.tuesdayEnabled.Text = "Habilitado";
            this.tuesdayEnabled.UseVisualStyleBackColor = true;
            // 
            // wednesdayEnabled
            // 
            this.wednesdayEnabled.AutoSize = true;
            this.wednesdayEnabled.Location = new System.Drawing.Point(72, 275);
            this.wednesdayEnabled.Name = "wednesdayEnabled";
            this.wednesdayEnabled.Size = new System.Drawing.Size(73, 17);
            this.wednesdayEnabled.TabIndex = 22;
            this.wednesdayEnabled.Text = "Habilitado";
            this.wednesdayEnabled.UseVisualStyleBackColor = true;
            // 
            // thursdayEnabled
            // 
            this.thursdayEnabled.AutoSize = true;
            this.thursdayEnabled.Location = new System.Drawing.Point(72, 337);
            this.thursdayEnabled.Name = "thursdayEnabled";
            this.thursdayEnabled.Size = new System.Drawing.Size(73, 17);
            this.thursdayEnabled.TabIndex = 28;
            this.thursdayEnabled.Text = "Habilitado";
            this.thursdayEnabled.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(272, 364);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Hasta";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 364);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Desde";
            // 
            // thursdayTo
            // 
            this.thursdayTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.thursdayTo.Location = new System.Drawing.Point(315, 358);
            this.thursdayTo.Name = "thursdayTo";
            this.thursdayTo.ShowUpDown = true;
            this.thursdayTo.Size = new System.Drawing.Size(200, 20);
            this.thursdayTo.TabIndex = 25;
            this.thursdayTo.ValueChanged += new System.EventHandler(this.thursdayTo_ValueChanged);
            // 
            // thursdayFrom
            // 
            this.thursdayFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.thursdayFrom.Location = new System.Drawing.Point(58, 358);
            this.thursdayFrom.Name = "thursdayFrom";
            this.thursdayFrom.ShowUpDown = true;
            this.thursdayFrom.Size = new System.Drawing.Size(200, 20);
            this.thursdayFrom.TabIndex = 24;
            this.thursdayFrom.ValueChanged += new System.EventHandler(this.thursdayFrom_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 341);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Jueves";
            // 
            // fridayEnabled
            // 
            this.fridayEnabled.AutoSize = true;
            this.fridayEnabled.Location = new System.Drawing.Point(72, 403);
            this.fridayEnabled.Name = "fridayEnabled";
            this.fridayEnabled.Size = new System.Drawing.Size(73, 17);
            this.fridayEnabled.TabIndex = 34;
            this.fridayEnabled.Text = "Habilitado";
            this.fridayEnabled.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(272, 430);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Hasta";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 430);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Desde";
            // 
            // fridayTo
            // 
            this.fridayTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fridayTo.Location = new System.Drawing.Point(315, 424);
            this.fridayTo.Name = "fridayTo";
            this.fridayTo.ShowUpDown = true;
            this.fridayTo.Size = new System.Drawing.Size(200, 20);
            this.fridayTo.TabIndex = 31;
            this.fridayTo.ValueChanged += new System.EventHandler(this.fridayTo_ValueChanged);
            // 
            // fridayFrom
            // 
            this.fridayFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fridayFrom.Location = new System.Drawing.Point(58, 424);
            this.fridayFrom.Name = "fridayFrom";
            this.fridayFrom.ShowUpDown = true;
            this.fridayFrom.Size = new System.Drawing.Size(200, 20);
            this.fridayFrom.TabIndex = 30;
            this.fridayFrom.ValueChanged += new System.EventHandler(this.fridayFrom_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 407);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "Viernes";
            // 
            // saturdayEnabled
            // 
            this.saturdayEnabled.AutoSize = true;
            this.saturdayEnabled.Location = new System.Drawing.Point(72, 471);
            this.saturdayEnabled.Name = "saturdayEnabled";
            this.saturdayEnabled.Size = new System.Drawing.Size(73, 17);
            this.saturdayEnabled.TabIndex = 40;
            this.saturdayEnabled.Text = "Habilitado";
            this.saturdayEnabled.UseVisualStyleBackColor = true;
            this.saturdayEnabled.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(272, 498);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "Hasta";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 498);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 13);
            this.label20.TabIndex = 38;
            this.label20.Text = "Desde";
            // 
            // saturdayTo
            // 
            this.saturdayTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.saturdayTo.Location = new System.Drawing.Point(315, 492);
            this.saturdayTo.Name = "saturdayTo";
            this.saturdayTo.ShowUpDown = true;
            this.saturdayTo.Size = new System.Drawing.Size(200, 20);
            this.saturdayTo.TabIndex = 37;
            this.saturdayTo.ValueChanged += new System.EventHandler(this.saturdayTo_ValueChanged);
            // 
            // saturdayFrom
            // 
            this.saturdayFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.saturdayFrom.Location = new System.Drawing.Point(58, 492);
            this.saturdayFrom.Name = "saturdayFrom";
            this.saturdayFrom.ShowUpDown = true;
            this.saturdayFrom.Size = new System.Drawing.Size(200, 20);
            this.saturdayFrom.TabIndex = 36;
            this.saturdayFrom.ValueChanged += new System.EventHandler(this.saturdayFrom_ValueChanged);
            // 
            // label_sabado
            // 
            this.label_sabado.AutoSize = true;
            this.label_sabado.Location = new System.Drawing.Point(14, 475);
            this.label_sabado.Name = "label_sabado";
            this.label_sabado.Size = new System.Drawing.Size(44, 13);
            this.label_sabado.TabIndex = 35;
            this.label_sabado.Text = "Sabado";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(286, 554);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(123, 23);
            this.save.TabIndex = 42;
            this.save.Text = "Generar Agenda";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // errorProviderFrom
            // 
            this.errorProviderFrom.ContainerControl = this;
            // 
            // errorProviderTo
            // 
            this.errorProviderTo.ContainerControl = this;
            // 
            // errorProviderMondayFrom
            // 
            this.errorProviderMondayFrom.ContainerControl = this;
            // 
            // errorProviderMondayTo
            // 
            this.errorProviderMondayTo.ContainerControl = this;
            // 
            // errorProviderTuesdayTo
            // 
            this.errorProviderTuesdayTo.ContainerControl = this;
            // 
            // errorProviderTuesdayFrom
            // 
            this.errorProviderTuesdayFrom.ContainerControl = this;
            // 
            // errorProviderWednesdayFrom
            // 
            this.errorProviderWednesdayFrom.ContainerControl = this;
            // 
            // errorProviderWednesdayTo
            // 
            this.errorProviderWednesdayTo.ContainerControl = this;
            // 
            // errorProviderThursdayFrom
            // 
            this.errorProviderThursdayFrom.ContainerControl = this;
            // 
            // errorProviderThursdayTo
            // 
            this.errorProviderThursdayTo.ContainerControl = this;
            // 
            // errorProviderFridayFrom
            // 
            this.errorProviderFridayFrom.ContainerControl = this;
            // 
            // errorProviderFridayTo
            // 
            this.errorProviderFridayTo.ContainerControl = this;
            // 
            // errorProviderSaturdayFrom
            // 
            this.errorProviderSaturdayFrom.ContainerControl = this;
            // 
            // errorProviderSaturdayTo
            // 
            this.errorProviderSaturdayTo.ContainerControl = this;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(14, 36);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 13);
            this.label21.TabIndex = 43;
            this.label21.Text = "Profesional: ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(14, 77);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 13);
            this.label22.TabIndex = 44;
            this.label22.Text = "Especialidad: ";
            // 
            // labelProfesional
            // 
            this.labelProfesional.AutoSize = true;
            this.labelProfesional.Location = new System.Drawing.Point(122, 36);
            this.labelProfesional.Name = "labelProfesional";
            this.labelProfesional.Size = new System.Drawing.Size(32, 13);
            this.labelProfesional.TabIndex = 45;
            this.labelProfesional.Text = "xxxxx";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(125, 554);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 47;
            this.back.Text = "Volver";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // especialidadesCombo
            // 
            this.especialidadesCombo.FormattingEnabled = true;
            this.especialidadesCombo.Location = new System.Drawing.Point(125, 69);
            this.especialidadesCombo.Name = "especialidadesCombo";
            this.especialidadesCombo.Size = new System.Drawing.Size(121, 21);
            this.especialidadesCombo.TabIndex = 48;
            // 
            // labelEspecialidad
            // 
            this.labelEspecialidad.AutoSize = true;
            this.labelEspecialidad.Location = new System.Drawing.Point(125, 76);
            this.labelEspecialidad.Name = "labelEspecialidad";
            this.labelEspecialidad.Size = new System.Drawing.Size(41, 13);
            this.labelEspecialidad.TabIndex = 49;
            this.labelEspecialidad.Text = "label23";
            this.labelEspecialidad.Visible = false;
            // 
            // AltaHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 646);
            this.Controls.Add(this.labelEspecialidad);
            this.Controls.Add(this.especialidadesCombo);
            this.Controls.Add(this.back);
            this.Controls.Add(this.labelProfesional);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.save);
            this.Controls.Add(this.saturdayEnabled);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.saturdayTo);
            this.Controls.Add(this.saturdayFrom);
            this.Controls.Add(this.label_sabado);
            this.Controls.Add(this.fridayEnabled);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.fridayTo);
            this.Controls.Add(this.fridayFrom);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.thursdayEnabled);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.thursdayTo);
            this.Controls.Add(this.thursdayFrom);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.wednesdayEnabled);
            this.Controls.Add(this.tuesdayEnabled);
            this.Controls.Add(this.mondayEnabled);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.wednesdayTo);
            this.Controls.Add(this.wednesdayFrom);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tuesdayTo);
            this.Controls.Add(this.tuesdayFrom);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mondayTo);
            this.Controls.Add(this.mondayFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.to);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.from);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaHorarios";
            this.Text = "Alta Agenda";
            this.Load += new System.EventHandler(this.AltaHorarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMondayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMondayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTuesdayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTuesdayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWednesdayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWednesdayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderThursdayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderThursdayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFridayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFridayTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSaturdayFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSaturdayTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker from;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker to;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker mondayFrom;
        private System.Windows.Forms.DateTimePicker mondayTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker tuesdayTo;
        private System.Windows.Forms.DateTimePicker tuesdayFrom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker wednesdayTo;
        private System.Windows.Forms.DateTimePicker wednesdayFrom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox mondayEnabled;
        private System.Windows.Forms.CheckBox tuesdayEnabled;
        private System.Windows.Forms.CheckBox wednesdayEnabled;
        private System.Windows.Forms.CheckBox thursdayEnabled;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker thursdayTo;
        private System.Windows.Forms.DateTimePicker thursdayFrom;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox fridayEnabled;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker fridayTo;
        private System.Windows.Forms.DateTimePicker fridayFrom;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox saturdayEnabled;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker saturdayTo;
        private System.Windows.Forms.DateTimePicker saturdayFrom;
        private System.Windows.Forms.Label label_sabado;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ErrorProvider errorProviderFrom;
        private System.Windows.Forms.ErrorProvider errorProviderTo;
        private System.Windows.Forms.ErrorProvider errorProviderMondayFrom;
        private System.Windows.Forms.ErrorProvider errorProviderMondayTo;
        private System.Windows.Forms.ErrorProvider errorProviderTuesdayTo;
        private System.Windows.Forms.ErrorProvider errorProviderTuesdayFrom;
        private System.Windows.Forms.ErrorProvider errorProviderWednesdayFrom;
        private System.Windows.Forms.ErrorProvider errorProviderWednesdayTo;
        private System.Windows.Forms.ErrorProvider errorProviderThursdayFrom;
        private System.Windows.Forms.ErrorProvider errorProviderThursdayTo;
        private System.Windows.Forms.ErrorProvider errorProviderFridayFrom;
        private System.Windows.Forms.ErrorProvider errorProviderFridayTo;
        private System.Windows.Forms.ErrorProvider errorProviderSaturdayFrom;
        private System.Windows.Forms.ErrorProvider errorProviderSaturdayTo;
        private System.Windows.Forms.Label labelProfesional;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox especialidadesCombo;
        private System.Windows.Forms.Label labelEspecialidad;
    }
}