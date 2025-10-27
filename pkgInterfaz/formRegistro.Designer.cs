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
            this.picMostrarClave = new System.Windows.Forms.PictureBox();
            this.picOcultarClave = new System.Windows.Forms.PictureBox();
            this.txtClave = new testForms.pkgInterfaz.placeHolderBox();
            this.txtUsuario = new testForms.pkgInterfaz.placeHolderBox();
            this.txtId = new testForms.pkgInterfaz.placeHolderBox();
            this.txtCorreo = new testForms.pkgInterfaz.placeHolderBox();
            this.txtPrimerNombre = new testForms.pkgInterfaz.placeHolderBox();
            this.pDegradado1 = new testForms.pkgInterfaz.pDegradado();
            this.lblClaveUsuario = new System.Windows.Forms.Label();
            this.txtPrimerApellido = new testForms.pkgInterfaz.placeHolderBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrarClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOcultarClave)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistroCliente
            // 
            this.lblRegistroCliente.AutoSize = true;
            this.lblRegistroCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistroCliente.Font = new System.Drawing.Font("Codec Pro Bold", 20F);
            this.lblRegistroCliente.ForeColor = System.Drawing.Color.Black;
            this.lblRegistroCliente.Location = new System.Drawing.Point(193, 215);
            this.lblRegistroCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistroCliente.Name = "lblRegistroCliente";
            this.lblRegistroCliente.Size = new System.Drawing.Size(217, 33);
            this.lblRegistroCliente.TabIndex = 1;
            this.lblRegistroCliente.Text = "Registro Cliente";
            this.lblRegistroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoginBack
            // 
            this.btnLoginBack.AutoSize = true;
            this.btnLoginBack.BackColor = System.Drawing.Color.Orange;
            this.btnLoginBack.Location = new System.Drawing.Point(338, 482);
            this.btnLoginBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoginBack.Name = "btnLoginBack";
            this.btnLoginBack.Size = new System.Drawing.Size(78, 28);
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
            this.dtpFechaNac.Location = new System.Drawing.Point(202, 374);
            this.dtpFechaNac.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaNac.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(324, 17);
            this.dtpFechaNac.TabIndex = 10;
            this.dtpFechaNac.Value = new System.DateTime(2025, 9, 22, 20, 39, 38, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Codec Pro Bold", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(296, 452);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
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
            this.btnRegistrar.Location = new System.Drawing.Point(321, 405);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(112, 28);
            this.btnRegistrar.TabIndex = 16;
            this.btnRegistrar.Text = "Registrarse";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(242, 100);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // lblDatosObligatorios
            // 
            this.lblDatosObligatorios.AutoSize = true;
            this.lblDatosObligatorios.CausesValidation = false;
            this.lblDatosObligatorios.Font = new System.Drawing.Font("Codec Pro", 7F);
            this.lblDatosObligatorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDatosObligatorios.Location = new System.Drawing.Point(254, 435);
            this.lblDatosObligatorios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatosObligatorios.Name = "lblDatosObligatorios";
            this.lblDatosObligatorios.Size = new System.Drawing.Size(255, 12);
            this.lblDatosObligatorios.TabIndex = 21;
            this.lblDatosObligatorios.Text = "Ingrese todos los campos obligatorios para continuar";
            // 
            // picMostrarClave
            // 
            this.picMostrarClave.Image = ((System.Drawing.Image)(resources.GetObject("picMostrarClave.Image")));
            this.picMostrarClave.Location = new System.Drawing.Point(503, 353);
            this.picMostrarClave.Margin = new System.Windows.Forms.Padding(2);
            this.picMostrarClave.Name = "picMostrarClave";
            this.picMostrarClave.Size = new System.Drawing.Size(23, 15);
            this.picMostrarClave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMostrarClave.TabIndex = 27;
            this.picMostrarClave.TabStop = false;
            this.picMostrarClave.Click += new System.EventHandler(this.picMostrarClave_Click);
            // 
            // picOcultarClave
            // 
            this.picOcultarClave.Enabled = false;
            this.picOcultarClave.Image = ((System.Drawing.Image)(resources.GetObject("picOcultarClave.Image")));
            this.picOcultarClave.Location = new System.Drawing.Point(503, 353);
            this.picOcultarClave.Margin = new System.Windows.Forms.Padding(2);
            this.picOcultarClave.Name = "picOcultarClave";
            this.picOcultarClave.Size = new System.Drawing.Size(23, 15);
            this.picOcultarClave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOcultarClave.TabIndex = 28;
            this.picOcultarClave.TabStop = false;
            this.picOcultarClave.Visible = false;
            this.picOcultarClave.Click += new System.EventHandler(this.picOcultarClave_Click);
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtClave.ForeColor = System.Drawing.Color.Black;
            this.txtClave.Location = new System.Drawing.Point(202, 353);
            this.txtClave.Margin = new System.Windows.Forms.Padding(2);
            this.txtClave.MaxLength = 50;
            this.txtClave.Name = "txtClave";
            this.txtClave.PlaceHolder = "Contraseña";
            this.txtClave.Size = new System.Drawing.Size(297, 17);
            this.txtClave.TabIndex = 26;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(202, 332);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceHolder = "Usuario";
            this.txtUsuario.Size = new System.Drawing.Size(324, 17);
            this.txtUsuario.TabIndex = 25;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.Location = new System.Drawing.Point(202, 311);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.MaxLength = 15;
            this.txtId.Name = "txtId";
            this.txtId.PlaceHolder = "Numero de Identificacion";
            this.txtId.Size = new System.Drawing.Size(324, 17);
            this.txtId.TabIndex = 24;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtCorreo.ForeColor = System.Drawing.Color.Black;
            this.txtCorreo.Location = new System.Drawing.Point(202, 290);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PlaceHolder = "Correo Electronico";
            this.txtCorreo.Size = new System.Drawing.Size(324, 17);
            this.txtCorreo.TabIndex = 23;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtPrimerNombre.ForeColor = System.Drawing.Color.Black;
            this.txtPrimerNombre.Location = new System.Drawing.Point(202, 269);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrimerNombre.MaxLength = 20;
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.PlaceHolder = "Primer nombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(160, 17);
            this.txtPrimerNombre.TabIndex = 22;
            // 
            // pDegradado1
            // 
            this.pDegradado1.Angle = 45F;
            this.pDegradado1.HexColor1 = "#00000";
            this.pDegradado1.HexColor2 = "#5C69F5";
            this.pDegradado1.Location = new System.Drawing.Point(0, 0);
            this.pDegradado1.Margin = new System.Windows.Forms.Padding(2);
            this.pDegradado1.Name = "pDegradado1";
            this.pDegradado1.Size = new System.Drawing.Size(602, 81);
            this.pDegradado1.TabIndex = 17;
            // 
            // lblClaveUsuario
            // 
            this.lblClaveUsuario.CausesValidation = false;
            this.lblClaveUsuario.Font = new System.Drawing.Font("Codec Pro", 7F);
            this.lblClaveUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblClaveUsuario.Location = new System.Drawing.Point(530, 353);
            this.lblClaveUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClaveUsuario.Name = "lblClaveUsuario";
            this.lblClaveUsuario.Size = new System.Drawing.Size(209, 32);
            this.lblClaveUsuario.TabIndex = 29;
            this.lblClaveUsuario.Text = "La contraseña no puede ser igual al nombre de usuario";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtPrimerApellido.ForeColor = System.Drawing.Color.Black;
            this.txtPrimerApellido.Location = new System.Drawing.Point(366, 269);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrimerApellido.MaxLength = 20;
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.PlaceHolder = "Primer apellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(160, 17);
            this.txtPrimerApellido.TabIndex = 31;
            // 
            // formRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 685);
            this.Controls.Add(this.txtPrimerApellido);
            this.Controls.Add(this.lblClaveUsuario);
            this.Controls.Add(this.picOcultarClave);
            this.Controls.Add(this.picMostrarClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtPrimerNombre);
            this.Controls.Add(this.lblDatosObligatorios);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pDegradado1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.btnLoginBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRegistroCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formRegistro";
            this.Text = "formRegistro";
            this.Load += new System.EventHandler(this.formRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrarClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOcultarClave)).EndInit();
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
        private pkgInterfaz.placeHolderBox txtPrimerNombre;
        private pkgInterfaz.placeHolderBox txtCorreo;
        private pkgInterfaz.placeHolderBox txtId;
        private pkgInterfaz.placeHolderBox txtUsuario;
        private pkgInterfaz.placeHolderBox txtClave;
        private System.Windows.Forms.PictureBox picMostrarClave;
        private System.Windows.Forms.PictureBox picOcultarClave;
        private System.Windows.Forms.Label lblClaveUsuario;
        private pkgInterfaz.placeHolderBox txtPrimerApellido;
    }
}