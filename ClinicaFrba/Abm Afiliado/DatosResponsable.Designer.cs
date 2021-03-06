﻿namespace ClinicaFrba.Abm_Afiliado
{
    partial class DatosResponsable
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
            this.telefono = new System.Windows.Forms.TextBox();
            this.telefonoLabel = new System.Windows.Forms.Label();
            this.guardar = new System.Windows.Forms.Button();
            this.fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.fechaNacLabel = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.mailLabel = new System.Windows.Forms.Label();
            this.sexo = new System.Windows.Forms.ComboBox();
            this.sexoLabel = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.tipoDoc = new System.Windows.Forms.ComboBox();
            this.documento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tipoDocLabel = new System.Windows.Forms.Label();
            this.ApellidoLabel = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.errorProviderNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderApellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDocumento = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDireccion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFechaNacimiento = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFechaNacimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelefono)).BeginInit();
            this.SuspendLayout();
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(330, 271);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(100, 20);
            this.telefono.TabIndex = 56;
            // 
            // telefonoLabel
            // 
            this.telefonoLabel.AutoSize = true;
            this.telefonoLabel.Location = new System.Drawing.Point(332, 253);
            this.telefonoLabel.Name = "telefonoLabel";
            this.telefonoLabel.Size = new System.Drawing.Size(56, 13);
            this.telefonoLabel.TabIndex = 55;
            this.telefonoLabel.Text = "Telefono *";
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(263, 385);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(75, 23);
            this.guardar.TabIndex = 54;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.Location = new System.Drawing.Point(330, 206);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.fechaNacimiento.TabIndex = 53;
            // 
            // fechaNacLabel
            // 
            this.fechaNacLabel.AutoSize = true;
            this.fechaNacLabel.Location = new System.Drawing.Point(330, 180);
            this.fechaNacLabel.Name = "fechaNacLabel";
            this.fechaNacLabel.Size = new System.Drawing.Size(113, 13);
            this.fechaNacLabel.TabIndex = 52;
            this.fechaNacLabel.Text = "Fecha de nacimiento *";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(330, 150);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(100, 20);
            this.mail.TabIndex = 51;
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Location = new System.Drawing.Point(332, 123);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(33, 13);
            this.mailLabel.TabIndex = 50;
            this.mailLabel.Text = "Mail *";
            // 
            // sexo
            // 
            this.sexo.FormattingEnabled = true;
            this.sexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.sexo.Location = new System.Drawing.Point(330, 60);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(121, 21);
            this.sexo.TabIndex = 49;
            // 
            // sexoLabel
            // 
            this.sexoLabel.AutoSize = true;
            this.sexoLabel.Location = new System.Drawing.Point(327, 44);
            this.sexoLabel.Name = "sexoLabel";
            this.sexoLabel.Size = new System.Drawing.Size(38, 13);
            this.sexoLabel.TabIndex = 48;
            this.sexoLabel.Text = "Sexo *";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(85, 308);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(100, 20);
            this.direccion.TabIndex = 47;
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.Location = new System.Drawing.Point(83, 281);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(105, 13);
            this.direccionLabel.TabIndex = 46;
            this.direccionLabel.Text = "Direccion completa *";
            // 
            // tipoDoc
            // 
            this.tipoDoc.FormattingEnabled = true;
            this.tipoDoc.Items.AddRange(new object[] {
            "DNI",
            "LE"});
            this.tipoDoc.Location = new System.Drawing.Point(82, 189);
            this.tipoDoc.Name = "tipoDoc";
            this.tipoDoc.Size = new System.Drawing.Size(121, 21);
            this.tipoDoc.TabIndex = 45;
            // 
            // documento
            // 
            this.documento.Location = new System.Drawing.Point(85, 246);
            this.documento.Name = "documento";
            this.documento.Size = new System.Drawing.Size(100, 20);
            this.documento.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Documento *";
            // 
            // tipoDocLabel
            // 
            this.tipoDocLabel.AutoSize = true;
            this.tipoDocLabel.Location = new System.Drawing.Point(82, 163);
            this.tipoDocLabel.Name = "tipoDocLabel";
            this.tipoDocLabel.Size = new System.Drawing.Size(106, 13);
            this.tipoDocLabel.TabIndex = 42;
            this.tipoDocLabel.Text = "Tipo de documento *";
            // 
            // ApellidoLabel
            // 
            this.ApellidoLabel.AutoSize = true;
            this.ApellidoLabel.Location = new System.Drawing.Point(82, 104);
            this.ApellidoLabel.Name = "ApellidoLabel";
            this.ApellidoLabel.Size = new System.Drawing.Size(51, 13);
            this.ApellidoLabel.TabIndex = 41;
            this.ApellidoLabel.Text = "Apellido *";
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(82, 123);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(100, 20);
            this.apellido.TabIndex = 40;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(82, 44);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(51, 13);
            this.nombreLabel.TabIndex = 39;
            this.nombreLabel.Text = "Nombre *";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(82, 63);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 38;
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
            // errorProviderMail
            // 
            this.errorProviderMail.ContainerControl = this;
            // 
            // errorProviderFechaNacimiento
            // 
            this.errorProviderFechaNacimiento.ContainerControl = this;
            // 
            // errorProviderTelefono
            // 
            this.errorProviderTelefono.ContainerControl = this;
            // 
            // DatosResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 420);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.telefonoLabel);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.fechaNacimiento);
            this.Controls.Add(this.fechaNacLabel);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.sexoLabel);
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
            this.Name = "DatosResponsable";
            this.Text = "Datos Responsable";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFechaNacimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelefono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label telefonoLabel;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.DateTimePicker fechaNacimiento;
        private System.Windows.Forms.Label fechaNacLabel;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.ComboBox sexo;
        private System.Windows.Forms.Label sexoLabel;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.ComboBox tipoDoc;
        private System.Windows.Forms.TextBox documento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tipoDocLabel;
        private System.Windows.Forms.Label ApellidoLabel;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.ErrorProvider errorProviderNombre;
        private System.Windows.Forms.ErrorProvider errorProviderApellido;
        private System.Windows.Forms.ErrorProvider errorProviderDocumento;
        private System.Windows.Forms.ErrorProvider errorProviderDireccion;
        private System.Windows.Forms.ErrorProvider errorProviderMail;
        private System.Windows.Forms.ErrorProvider errorProviderFechaNacimiento;
        private System.Windows.Forms.ErrorProvider errorProviderTelefono;
    }
}