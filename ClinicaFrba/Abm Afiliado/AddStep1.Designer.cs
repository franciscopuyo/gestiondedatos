namespace ClinicaFrba.Abm_Afiliado
{
    partial class Add
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
            this.nombre = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.ApellidoLabel = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.tipoDocLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.documento = new System.Windows.Forms.TextBox();
            this.tipoDoc = new System.Windows.Forms.ComboBox();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.telefonoLabel = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.mailLabel = new System.Windows.Forms.Label();
            this.fechaNacLabel = new System.Windows.Forms.Label();
            this.fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.sexo = new System.Windows.Forms.ComboBox();
            this.sexoLabel = new System.Windows.Forms.Label();
            this.estadoCivil = new System.Windows.Forms.ComboBox();
            this.estadoCivilLabel = new System.Windows.Forms.Label();
            this.cantResponsables = new System.Windows.Forms.TextBox();
            this.cantHijosLabel = new System.Windows.Forms.Label();
            this.planMedico = new System.Windows.Forms.ComboBox();
            this.planMedicoLabel = new System.Windows.Forms.Label();
            this.guardar = new System.Windows.Forms.Button();
            this.errorProviderNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderApellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDocumento = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDireccion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCantResponsables = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMail = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCantResponsables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMail)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(13, 66);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 0;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(13, 47);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(51, 13);
            this.nombreLabel.TabIndex = 1;
            this.nombreLabel.Text = "Nombre *";
            // 
            // ApellidoLabel
            // 
            this.ApellidoLabel.AutoSize = true;
            this.ApellidoLabel.Location = new System.Drawing.Point(13, 107);
            this.ApellidoLabel.Name = "ApellidoLabel";
            this.ApellidoLabel.Size = new System.Drawing.Size(51, 13);
            this.ApellidoLabel.TabIndex = 3;
            this.ApellidoLabel.Text = "Apellido *";
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(13, 126);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(100, 20);
            this.apellido.TabIndex = 2;
            // 
            // tipoDocLabel
            // 
            this.tipoDocLabel.AutoSize = true;
            this.tipoDocLabel.Location = new System.Drawing.Point(13, 166);
            this.tipoDocLabel.Name = "tipoDocLabel";
            this.tipoDocLabel.Size = new System.Drawing.Size(106, 13);
            this.tipoDocLabel.TabIndex = 5;
            this.tipoDocLabel.Text = "Tipo de documento *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Documento *";
            // 
            // documento
            // 
            this.documento.Location = new System.Drawing.Point(16, 249);
            this.documento.Name = "documento";
            this.documento.Size = new System.Drawing.Size(100, 20);
            this.documento.TabIndex = 7;
            // 
            // tipoDoc
            // 
            this.tipoDoc.FormattingEnabled = true;
            this.tipoDoc.Items.AddRange(new object[] {
            "DNI",
            "LE"});
            this.tipoDoc.Location = new System.Drawing.Point(13, 192);
            this.tipoDoc.Name = "tipoDoc";
            this.tipoDoc.Size = new System.Drawing.Size(121, 21);
            this.tipoDoc.TabIndex = 8;
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.Location = new System.Drawing.Point(14, 284);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(105, 13);
            this.direccionLabel.TabIndex = 9;
            this.direccionLabel.Text = "Direccion completa *";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(12, 302);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(100, 20);
            this.direccion.TabIndex = 10;
            this.direccion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(12, 362);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(100, 20);
            this.telefono.TabIndex = 12;
            this.telefono.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // telefonoLabel
            // 
            this.telefonoLabel.AutoSize = true;
            this.telefonoLabel.Location = new System.Drawing.Point(14, 344);
            this.telefonoLabel.Name = "telefonoLabel";
            this.telefonoLabel.Size = new System.Drawing.Size(56, 13);
            this.telefonoLabel.TabIndex = 11;
            this.telefonoLabel.Text = "Telefono *";
            this.telefonoLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(12, 430);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(100, 20);
            this.mail.TabIndex = 14;
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Location = new System.Drawing.Point(14, 403);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(33, 13);
            this.mailLabel.TabIndex = 13;
            this.mailLabel.Text = "Mail *";
            // 
            // fechaNacLabel
            // 
            this.fechaNacLabel.AutoSize = true;
            this.fechaNacLabel.Location = new System.Drawing.Point(12, 460);
            this.fechaNacLabel.Name = "fechaNacLabel";
            this.fechaNacLabel.Size = new System.Drawing.Size(113, 13);
            this.fechaNacLabel.TabIndex = 15;
            this.fechaNacLabel.Text = "Fecha de nacimiento *";
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.Location = new System.Drawing.Point(12, 486);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.fechaNacimiento.TabIndex = 16;
            // 
            // sexo
            // 
            this.sexo.FormattingEnabled = true;
            this.sexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.sexo.Location = new System.Drawing.Point(261, 63);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(121, 21);
            this.sexo.TabIndex = 18;
            this.sexo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sexoLabel
            // 
            this.sexoLabel.AutoSize = true;
            this.sexoLabel.Location = new System.Drawing.Point(258, 47);
            this.sexoLabel.Name = "sexoLabel";
            this.sexoLabel.Size = new System.Drawing.Size(38, 13);
            this.sexoLabel.TabIndex = 17;
            this.sexoLabel.Text = "Sexo *";
            this.sexoLabel.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // estadoCivil
            // 
            this.estadoCivil.FormattingEnabled = true;
            this.estadoCivil.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a",
            "Viudo/a",
            "Concubinato",
            "Divorciado/a"});
            this.estadoCivil.Location = new System.Drawing.Point(261, 123);
            this.estadoCivil.Name = "estadoCivil";
            this.estadoCivil.Size = new System.Drawing.Size(121, 21);
            this.estadoCivil.TabIndex = 20;
            // 
            // estadoCivilLabel
            // 
            this.estadoCivilLabel.AutoSize = true;
            this.estadoCivilLabel.Location = new System.Drawing.Point(258, 107);
            this.estadoCivilLabel.Name = "estadoCivilLabel";
            this.estadoCivilLabel.Size = new System.Drawing.Size(68, 13);
            this.estadoCivilLabel.TabIndex = 19;
            this.estadoCivilLabel.Text = "Estado civil *";
            // 
            // cantResponsables
            // 
            this.cantResponsables.Location = new System.Drawing.Point(261, 192);
            this.cantResponsables.Name = "cantResponsables";
            this.cantResponsables.Size = new System.Drawing.Size(100, 20);
            this.cantResponsables.TabIndex = 22;
            // 
            // cantHijosLabel
            // 
            this.cantHijosLabel.AutoSize = true;
            this.cantHijosLabel.Location = new System.Drawing.Point(258, 166);
            this.cantHijosLabel.Name = "cantHijosLabel";
            this.cantHijosLabel.Size = new System.Drawing.Size(182, 13);
            this.cantHijosLabel.TabIndex = 21;
            this.cantHijosLabel.Text = "Cantidad de hijos o familiares a cargo";
            // 
            // planMedico
            // 
            this.planMedico.FormattingEnabled = true;
            this.planMedico.Location = new System.Drawing.Point(258, 249);
            this.planMedico.Name = "planMedico";
            this.planMedico.Size = new System.Drawing.Size(121, 21);
            this.planMedico.TabIndex = 24;
            // 
            // planMedicoLabel
            // 
            this.planMedicoLabel.AutoSize = true;
            this.planMedicoLabel.Location = new System.Drawing.Point(258, 223);
            this.planMedicoLabel.Name = "planMedicoLabel";
            this.planMedicoLabel.Size = new System.Drawing.Size(72, 13);
            this.planMedicoLabel.TabIndex = 23;
            this.planMedicoLabel.Text = "Plan medico *";
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(244, 550);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(75, 23);
            this.guardar.TabIndex = 25;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // errorProviderNombre
            // 
            this.errorProviderNombre.ContainerControl = this;
            // 
            // errorProviderApellido
            // 
            this.errorProviderApellido.ContainerControl = this;
            // 
            // errorProviderDocumento
            // 
            this.errorProviderDocumento.ContainerControl = this;
            // 
            // errorProviderDireccion
            // 
            this.errorProviderDireccion.ContainerControl = this;
            // 
            // errorProviderTelefono
            // 
            this.errorProviderTelefono.ContainerControl = this;
            // 
            // errorProviderCantResponsables
            // 
            this.errorProviderCantResponsables.ContainerControl = this;
            // 
            // errorProviderMail
            // 
            this.errorProviderMail.ContainerControl = this;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 599);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.planMedico);
            this.Controls.Add(this.planMedicoLabel);
            this.Controls.Add(this.cantResponsables);
            this.Controls.Add(this.cantHijosLabel);
            this.Controls.Add(this.estadoCivil);
            this.Controls.Add(this.estadoCivilLabel);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.sexoLabel);
            this.Controls.Add(this.fechaNacimiento);
            this.Controls.Add(this.fechaNacLabel);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.telefonoLabel);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.direccionLabel);
            this.Controls.Add(this.tipoDoc);
            this.Controls.Add(this.documento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipoDocLabel);
            this.Controls.Add(this.ApellidoLabel);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.nombre);
            this.Name = "Add";
            this.Text = "Alta Afiliado - Paso 1";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCantResponsables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label ApellidoLabel;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label tipoDocLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox documento;
        private System.Windows.Forms.ComboBox tipoDoc;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label telefonoLabel;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Label fechaNacLabel;
        private System.Windows.Forms.DateTimePicker fechaNacimiento;
        private System.Windows.Forms.ComboBox sexo;
        private System.Windows.Forms.Label sexoLabel;
        private System.Windows.Forms.ComboBox estadoCivil;
        private System.Windows.Forms.Label estadoCivilLabel;
        private System.Windows.Forms.TextBox cantResponsables;
        private System.Windows.Forms.Label cantHijosLabel;
        private System.Windows.Forms.ComboBox planMedico;
        private System.Windows.Forms.Label planMedicoLabel;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.ErrorProvider errorProviderNombre;
        private System.Windows.Forms.ErrorProvider errorProviderApellido;
        private System.Windows.Forms.ErrorProvider errorProviderDocumento;
        private System.Windows.Forms.ErrorProvider errorProviderDireccion;
        private System.Windows.Forms.ErrorProvider errorProviderTelefono;
        private System.Windows.Forms.ErrorProvider errorProviderCantResponsables;
        private System.Windows.Forms.ErrorProvider errorProviderMail;

    }
}