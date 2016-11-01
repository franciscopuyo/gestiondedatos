namespace ClinicaFrba.Abm_Afiliado
{
    partial class Edit
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
            this.guardar = new System.Windows.Forms.Button();
            this.planMedico = new System.Windows.Forms.ComboBox();
            this.planMedicoLabel = new System.Windows.Forms.Label();
            this.estadoCivil = new System.Windows.Forms.ComboBox();
            this.estadoCivilLabel = new System.Windows.Forms.Label();
            this.sexo = new System.Windows.Forms.ComboBox();
            this.sexoLabel = new System.Windows.Forms.Label();
            this.fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.fechaNacLabel = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.mailLabel = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.telefonoLabel = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.ApellidoLabel = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.errorProviderNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderApellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDocumento = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDireccion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFechaNacimiento = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCantidadResponsables = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFechaNacimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCantidadResponsables)).BeginInit();
            this.SuspendLayout();
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(234, 471);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(75, 23);
            this.guardar.TabIndex = 50;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // planMedico
            // 
            this.planMedico.FormattingEnabled = true;
            this.planMedico.Location = new System.Drawing.Point(296, 225);
            this.planMedico.Name = "planMedico";
            this.planMedico.Size = new System.Drawing.Size(121, 21);
            this.planMedico.TabIndex = 49;
            // 
            // planMedicoLabel
            // 
            this.planMedicoLabel.AutoSize = true;
            this.planMedicoLabel.Location = new System.Drawing.Point(293, 207);
            this.planMedicoLabel.Name = "planMedicoLabel";
            this.planMedicoLabel.Size = new System.Drawing.Size(72, 13);
            this.planMedicoLabel.TabIndex = 48;
            this.planMedicoLabel.Text = "Plan medico *";
            // 
            // estadoCivil
            // 
            this.estadoCivil.FormattingEnabled = true;
            this.estadoCivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Viudo",
            "Concubinato",
            "Divorciado"});
            this.estadoCivil.Location = new System.Drawing.Point(296, 163);
            this.estadoCivil.Name = "estadoCivil";
            this.estadoCivil.Size = new System.Drawing.Size(121, 21);
            this.estadoCivil.TabIndex = 45;
            // 
            // estadoCivilLabel
            // 
            this.estadoCivilLabel.AutoSize = true;
            this.estadoCivilLabel.Location = new System.Drawing.Point(293, 147);
            this.estadoCivilLabel.Name = "estadoCivilLabel";
            this.estadoCivilLabel.Size = new System.Drawing.Size(68, 13);
            this.estadoCivilLabel.TabIndex = 44;
            this.estadoCivilLabel.Text = "Estado civil *";
            // 
            // sexo
            // 
            this.sexo.FormattingEnabled = true;
            this.sexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.sexo.Location = new System.Drawing.Point(296, 103);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(121, 21);
            this.sexo.TabIndex = 43;
            // 
            // sexoLabel
            // 
            this.sexoLabel.AutoSize = true;
            this.sexoLabel.Location = new System.Drawing.Point(293, 87);
            this.sexoLabel.Name = "sexoLabel";
            this.sexoLabel.Size = new System.Drawing.Size(38, 13);
            this.sexoLabel.TabIndex = 42;
            this.sexoLabel.Text = "Sexo *";
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.Location = new System.Drawing.Point(58, 409);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.fechaNacimiento.TabIndex = 41;
            // 
            // fechaNacLabel
            // 
            this.fechaNacLabel.AutoSize = true;
            this.fechaNacLabel.Location = new System.Drawing.Point(58, 383);
            this.fechaNacLabel.Name = "fechaNacLabel";
            this.fechaNacLabel.Size = new System.Drawing.Size(113, 13);
            this.fechaNacLabel.TabIndex = 40;
            this.fechaNacLabel.Text = "Fecha de nacimiento *";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(58, 353);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(100, 20);
            this.mail.TabIndex = 39;
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Location = new System.Drawing.Point(60, 326);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(33, 13);
            this.mailLabel.TabIndex = 38;
            this.mailLabel.Text = "Mail *";
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(58, 285);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(100, 20);
            this.telefono.TabIndex = 37;
            // 
            // telefonoLabel
            // 
            this.telefonoLabel.AutoSize = true;
            this.telefonoLabel.Location = new System.Drawing.Point(60, 267);
            this.telefonoLabel.Name = "telefonoLabel";
            this.telefonoLabel.Size = new System.Drawing.Size(56, 13);
            this.telefonoLabel.TabIndex = 36;
            this.telefonoLabel.Text = "Telefono *";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(58, 225);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(100, 20);
            this.direccion.TabIndex = 35;
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.Location = new System.Drawing.Point(60, 207);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(105, 13);
            this.direccionLabel.TabIndex = 34;
            this.direccionLabel.Text = "Direccion completa *";
            // 
            // ApellidoLabel
            // 
            this.ApellidoLabel.AutoSize = true;
            this.ApellidoLabel.Location = new System.Drawing.Point(58, 144);
            this.ApellidoLabel.Name = "ApellidoLabel";
            this.ApellidoLabel.Size = new System.Drawing.Size(51, 13);
            this.ApellidoLabel.TabIndex = 29;
            this.ApellidoLabel.Text = "Apellido *";
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(58, 163);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(100, 20);
            this.apellido.TabIndex = 28;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(58, 84);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(51, 13);
            this.nombreLabel.TabIndex = 27;
            this.nombreLabel.Text = "Nombre *";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(58, 103);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 26;
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
            // errorProviderMail
            // 
            this.errorProviderMail.ContainerControl = this;
            // 
            // errorProviderFechaNacimiento
            // 
            this.errorProviderFechaNacimiento.ContainerControl = this;
            // 
            // errorProviderCantidadResponsables
            // 
            this.errorProviderCantidadResponsables.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Editando afiliado con documento xxxxxxxx";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 524);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.planMedico);
            this.Controls.Add(this.planMedicoLabel);
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
            this.Controls.Add(this.ApellidoLabel);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.nombre);
            this.Name = "Edit";
            this.Text = "Editar afiliado";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFechaNacimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCantidadResponsables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.ComboBox planMedico;
        private System.Windows.Forms.Label planMedicoLabel;
        private System.Windows.Forms.ComboBox estadoCivil;
        private System.Windows.Forms.Label estadoCivilLabel;
        private System.Windows.Forms.ComboBox sexo;
        private System.Windows.Forms.Label sexoLabel;
        private System.Windows.Forms.DateTimePicker fechaNacimiento;
        private System.Windows.Forms.Label fechaNacLabel;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label telefonoLabel;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.Label ApellidoLabel;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.ErrorProvider errorProviderNombre;
        private System.Windows.Forms.ErrorProvider errorProviderApellido;
        private System.Windows.Forms.ErrorProvider errorProviderDocumento;
        private System.Windows.Forms.ErrorProvider errorProviderDireccion;
        private System.Windows.Forms.ErrorProvider errorProviderTelefono;
        private System.Windows.Forms.ErrorProvider errorProviderMail;
        private System.Windows.Forms.ErrorProvider errorProviderFechaNacimiento;
        private System.Windows.Forms.ErrorProvider errorProviderCantidadResponsables;
        private System.Windows.Forms.Label label1;
    }
}