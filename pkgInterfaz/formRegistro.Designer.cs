namespace testForms
{
    partial class formRegistro
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
            this.lblRegistroCliente = new System.Windows.Forms.Label();
            this.btnLoginBack = new System.Windows.Forms.Button();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtContraseña = new testForms.pkgInterfaz.phTextBox();
            this.txtUsuario = new testForms.pkgInterfaz.phTextBox();
            this.txtId = new testForms.pkgInterfaz.phTextBox();
            this.txtCorreo = new testForms.pkgInterfaz.phTextBox();
            this.txtNombre = new testForms.pkgInterfaz.phTextBox();
            this.SuspendLayout();
            // 
            // lblRegistroCliente
            // 
            this.lblRegistroCliente.AutoSize = true;
            this.lblRegistroCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistroCliente.Font = new System.Drawing.Font("Codec Pro Bold", 40F);
            this.lblRegistroCliente.ForeColor = System.Drawing.Color.White;
            this.lblRegistroCliente.Location = new System.Drawing.Point(121, 245);
            this.lblRegistroCliente.Name = "lblRegistroCliente";
            this.lblRegistroCliente.Size = new System.Drawing.Size(543, 82);
            this.lblRegistroCliente.TabIndex = 1;
            this.lblRegistroCliente.Text = "Registro Cliente";
            this.lblRegistroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoginBack
            // 
            this.btnLoginBack.BackColor = System.Drawing.Color.Orange;
            this.btnLoginBack.Location = new System.Drawing.Point(346, 733);
            this.btnLoginBack.Name = "btnLoginBack";
            this.btnLoginBack.Size = new System.Drawing.Size(93, 35);
            this.btnLoginBack.TabIndex = 3;
            this.btnLoginBack.Text = "Iniciar sesion";
            this.btnLoginBack.UseVisualStyleBackColor = false;
            this.btnLoginBack.Click += new System.EventHandler(this.btnLoginBack_Click);
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpFechaNac.CustomFormat = "\'Fecha de nacimiento\'  dd MMM yyyy";
            this.dtpFechaNac.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNac.Location = new System.Drawing.Point(265, 550);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(255, 19);
            this.dtpFechaNac.TabIndex = 10;
            this.dtpFechaNac.Value = new System.DateTime(2025, 9, 22, 20, 39, 38, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Codec Pro Bold", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(289, 696);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ya tiene una cuenta?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Orange;
            this.btnRegistrar.Location = new System.Drawing.Point(346, 590);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(93, 35);
            this.btnRegistrar.TabIndex = 16;
            this.btnRegistrar.Text = "Registrarse";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txtContraseña.Location = new System.Drawing.Point(267, 506);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PlaceHolder = "Contraseña";
            this.txtContraseña.Size = new System.Drawing.Size(250, 19);
            this.txtContraseña.TabIndex = 15;
            this.txtContraseña.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuario.Location = new System.Drawing.Point(267, 462);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceHolder = "Usuario";
            this.txtUsuario.Size = new System.Drawing.Size(250, 19);
            this.txtUsuario.TabIndex = 14;
            this.txtUsuario.Text = "Usuario";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtId.ForeColor = System.Drawing.Color.DimGray;
            this.txtId.Location = new System.Drawing.Point(267, 418);
            this.txtId.Name = "txtId";
            this.txtId.PlaceHolder = "Identificacion";
            this.txtId.Size = new System.Drawing.Size(250, 19);
            this.txtId.TabIndex = 13;
            this.txtId.Text = "Identificacion";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtCorreo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCorreo.Location = new System.Drawing.Point(267, 374);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PlaceHolder = "Correo electronico";
            this.txtCorreo.Size = new System.Drawing.Size(250, 19);
            this.txtCorreo.TabIndex = 12;
            this.txtCorreo.Text = "Correo electronico";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(267, 330);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceHolder = "Nombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 19);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.Text = "Nombre";
            // 
            // formRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 809);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.btnLoginBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRegistroCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formRegistro";
            this.Text = "formRegistro";
            this.Load += new System.EventHandler(this.formRegistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistroCliente;
        private System.Windows.Forms.Button btnLoginBack;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private pkgInterfaz.phTextBox txtNombre;
        private pkgInterfaz.phTextBox txtCorreo;
        private pkgInterfaz.phTextBox txtId;
        private pkgInterfaz.phTextBox txtUsuario;
        private pkgInterfaz.phTextBox txtContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
    }
}