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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRegistro));
            this.lblRegistroCliente = new System.Windows.Forms.Label();
            this.btnLoginBack = new System.Windows.Forms.Button();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDatosObligatorios = new System.Windows.Forms.Label();
            this.txtClave = new testForms.pkgInterfaz.placeHolderBox();
            this.txtUsuario = new testForms.pkgInterfaz.placeHolderBox();
            this.txtId = new testForms.pkgInterfaz.placeHolderBox();
            this.txtCorreo = new testForms.pkgInterfaz.placeHolderBox();
            this.txtNombre = new testForms.pkgInterfaz.placeHolderBox();
            this.pDegradado1 = new testForms.pkgInterfaz.pDegradado();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistroCliente
            // 
            this.lblRegistroCliente.AutoSize = true;
            this.lblRegistroCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistroCliente.Font = new System.Drawing.Font("Codec Pro Bold", 20F);
            this.lblRegistroCliente.ForeColor = System.Drawing.Color.Black;
            this.lblRegistroCliente.Location = new System.Drawing.Point(257, 265);
            this.lblRegistroCliente.Name = "lblRegistroCliente";
            this.lblRegistroCliente.Size = new System.Drawing.Size(278, 42);
            this.lblRegistroCliente.TabIndex = 1;
            this.lblRegistroCliente.Text = "Registro Cliente";
            this.lblRegistroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoginBack
            // 
            this.btnLoginBack.AutoSize = true;
            this.btnLoginBack.BackColor = System.Drawing.Color.Orange;
            this.btnLoginBack.Location = new System.Drawing.Point(349, 666);
            this.btnLoginBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoginBack.Name = "btnLoginBack";
            this.btnLoginBack.Size = new System.Drawing.Size(95, 34);
            this.btnLoginBack.TabIndex = 3;
            this.btnLoginBack.Text = "Iniciar sesion";
            this.btnLoginBack.UseVisualStyleBackColor = false;
            this.btnLoginBack.Click += new System.EventHandler(this.btnLoginBack_Click);
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpFechaNac.CustomFormat = "\'Fecha de nacimiento\'     dd MMM yyyy";
            this.dtpFechaNac.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNac.Location = new System.Drawing.Point(269, 541);
            this.dtpFechaNac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaNac.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(250, 19);
            this.dtpFechaNac.TabIndex = 10;
            this.dtpFechaNac.Value = new System.DateTime(2025, 9, 22, 20, 39, 38, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Codec Pro Bold", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(293, 630);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ya tiene una cuenta?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AutoSize = true;
            this.btnRegistrar.BackColor = System.Drawing.Color.DimGray;
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.Font = new System.Drawing.Font("Codec Pro Bold", 7F);
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Location = new System.Drawing.Point(321, 573);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(150, 34);
            this.btnRegistrar.TabIndex = 16;
            this.btnRegistrar.Text = "Registrarse";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(322, 123);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(148, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // lblDatosObligatorios
            // 
            this.lblDatosObligatorios.AutoSize = true;
            this.lblDatosObligatorios.CausesValidation = false;
            this.lblDatosObligatorios.Enabled = false;
            this.lblDatosObligatorios.Font = new System.Drawing.Font("Codec Pro", 7F);
            this.lblDatosObligatorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDatosObligatorios.Location = new System.Drawing.Point(237, 609);
            this.lblDatosObligatorios.Name = "lblDatosObligatorios";
            this.lblDatosObligatorios.Size = new System.Drawing.Size(319, 14);
            this.lblDatosObligatorios.TabIndex = 21;
            this.lblDatosObligatorios.Text = "Ingrese todos los campos obligatorios para continuar";
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtClave.ForeColor = System.Drawing.Color.Black;
            this.txtClave.Location = new System.Drawing.Point(269, 499);
            this.txtClave.Name = "txtClave";
            this.txtClave.PlaceHolder = "Contraseña";
            this.txtClave.Size = new System.Drawing.Size(250, 19);
            this.txtClave.TabIndex = 26;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(269, 457);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceHolder = "Usuario";
            this.txtUsuario.Size = new System.Drawing.Size(250, 19);
            this.txtUsuario.TabIndex = 25;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.Location = new System.Drawing.Point(269, 415);
            this.txtId.Name = "txtId";
            this.txtId.PlaceHolder = "Numero de Identificacion";
            this.txtId.Size = new System.Drawing.Size(250, 19);
            this.txtId.TabIndex = 24;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtCorreo.ForeColor = System.Drawing.Color.Black;
            this.txtCorreo.Location = new System.Drawing.Point(269, 373);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PlaceHolder = "Correo Electronico";
            this.txtCorreo.Size = new System.Drawing.Size(250, 19);
            this.txtCorreo.TabIndex = 23;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(269, 331);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceHolder = "Nombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 19);
            this.txtNombre.TabIndex = 22;
            // 
            // pDegradado1
            // 
            this.pDegradado1.Angle = 45F;
            this.pDegradado1.HexColor1 = "#00000";
            this.pDegradado1.HexColor2 = "#5C69F5";
            this.pDegradado1.Location = new System.Drawing.Point(0, 0);
            this.pDegradado1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pDegradado1.Name = "pDegradado1";
            this.pDegradado1.Size = new System.Drawing.Size(803, 100);
            this.pDegradado1.TabIndex = 17;
            // 
            // formRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 709);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDatosObligatorios);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pDegradado1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.btnLoginBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRegistroCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formRegistro";
            this.Text = "formRegistro";
            this.Load += new System.EventHandler(this.formRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistroCliente;
        private System.Windows.Forms.Button btnLoginBack;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
        private pkgInterfaz.pDegradado pDegradado1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDatosObligatorios;
        private pkgInterfaz.placeHolderBox txtNombre;
        private pkgInterfaz.placeHolderBox txtCorreo;
        private pkgInterfaz.placeHolderBox txtId;
        private pkgInterfaz.placeHolderBox txtUsuario;
        private pkgInterfaz.placeHolderBox txtClave;
    }
}