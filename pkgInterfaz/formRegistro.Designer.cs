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
            this.lblClaveUsuario = new System.Windows.Forms.Label();
            this.pDegradado2 = new testForms.pkgInterfaz.pDegradado();
            this.txtClave = new testForms.pkgInterfaz.pLineaTextBox();
            this.txtUsuario = new testForms.pkgInterfaz.pLineaTextBox();
            this.txtId = new testForms.pkgInterfaz.pLineaTextBox();
            this.txtCorreo = new testForms.pkgInterfaz.pLineaTextBox();
            this.txtPrimerApellido = new testForms.pkgInterfaz.pLineaTextBox();
            this.txtPrimerNombre = new testForms.pkgInterfaz.pLineaTextBox();
            this.pDegradado1 = new testForms.pkgInterfaz.pDegradado();
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
            this.lblRegistroCliente.Location = new System.Drawing.Point(269, 224);
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
            this.btnLoginBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginBack.Font = new System.Drawing.Font("Codec Pro Bold", 8F, System.Drawing.FontStyle.Bold);
            this.btnLoginBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnLoginBack.Location = new System.Drawing.Point(332, 735);
            this.btnLoginBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoginBack.Name = "btnLoginBack";
            this.btnLoginBack.Size = new System.Drawing.Size(90, 32);
            this.btnLoginBack.TabIndex = 3;
            this.btnLoginBack.Text = "Iniciar sesion";
            this.btnLoginBack.UseVisualStyleBackColor = false;
            this.btnLoginBack.Click += new System.EventHandler(this.btnLoginBack_Click);
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.CalendarFont = new System.Drawing.Font("Codec Pro", 15F);
            this.dtpFechaNac.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpFechaNac.CustomFormat = "\'Fecha de nacimiento: \'  dd - MM - yyyy";
            this.dtpFechaNac.Font = new System.Drawing.Font("Codec Pro", 15F);
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNac.Location = new System.Drawing.Point(107, 552);
            this.dtpFechaNac.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaNac.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(540, 25);
            this.dtpFechaNac.TabIndex = 10;
            this.dtpFechaNac.Value = new System.DateTime(2025, 9, 22, 20, 39, 38, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Codec Pro Bold", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(292, 713);
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
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Codec Pro Bold", 15F);
            this.btnRegistrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.Location = new System.Drawing.Point(311, 619);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(132, 37);
            this.btnRegistrar.TabIndex = 16;
            this.btnRegistrar.Text = "Registrarse";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(322, 104);
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
            this.lblDatosObligatorios.Font = new System.Drawing.Font("Codec Pro", 10F);
            this.lblDatosObligatorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDatosObligatorios.Location = new System.Drawing.Point(237, 658);
            this.lblDatosObligatorios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatosObligatorios.Name = "lblDatosObligatorios";
            this.lblDatosObligatorios.Size = new System.Drawing.Size(280, 17);
            this.lblDatosObligatorios.TabIndex = 21;
            this.lblDatosObligatorios.Text = "Ingrese todos los campos para continuar";
            // 
            // picMostrarClave
            // 
            this.picMostrarClave.Image = ((System.Drawing.Image)(resources.GetObject("picMostrarClave.Image")));
            this.picMostrarClave.Location = new System.Drawing.Point(619, 496);
            this.picMostrarClave.Margin = new System.Windows.Forms.Padding(2);
            this.picMostrarClave.Name = "picMostrarClave";
            this.picMostrarClave.Size = new System.Drawing.Size(28, 29);
            this.picMostrarClave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMostrarClave.TabIndex = 27;
            this.picMostrarClave.TabStop = false;
            this.picMostrarClave.Click += new System.EventHandler(this.picMostrarClave_Click);
            // 
            // picOcultarClave
            // 
            this.picOcultarClave.Enabled = false;
            this.picOcultarClave.Image = ((System.Drawing.Image)(resources.GetObject("picOcultarClave.Image")));
            this.picOcultarClave.Location = new System.Drawing.Point(619, 496);
            this.picOcultarClave.Margin = new System.Windows.Forms.Padding(2);
            this.picOcultarClave.Name = "picOcultarClave";
            this.picOcultarClave.Size = new System.Drawing.Size(28, 29);
            this.picOcultarClave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOcultarClave.TabIndex = 28;
            this.picOcultarClave.TabStop = false;
            this.picOcultarClave.Visible = false;
            this.picOcultarClave.Click += new System.EventHandler(this.picOcultarClave_Click);
            // 
            // lblClaveUsuario
            // 
            this.lblClaveUsuario.CausesValidation = false;
            this.lblClaveUsuario.Font = new System.Drawing.Font("Codec Pro", 10F);
            this.lblClaveUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblClaveUsuario.Location = new System.Drawing.Point(104, 527);
            this.lblClaveUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClaveUsuario.Name = "lblClaveUsuario";
            this.lblClaveUsuario.Size = new System.Drawing.Size(510, 23);
            this.lblClaveUsuario.TabIndex = 29;
            this.lblClaveUsuario.Text = "La contraseña no puede ser igual al nombre de usuario";
            // 
            // pDegradado2
            // 
            this.pDegradado2.Angle = 45F;
            this.pDegradado2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pDegradado2.HexColor1 = "#00000";
            this.pDegradado2.HexColor2 = "#5C69F5";
            this.pDegradado2.Location = new System.Drawing.Point(0, 785);
            this.pDegradado2.Margin = new System.Windows.Forms.Padding(2);
            this.pDegradado2.Name = "pDegradado2";
            this.pDegradado2.Size = new System.Drawing.Size(735, 81);
            this.pDegradado2.TabIndex = 38;
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtClave.esClave = true;
            this.txtClave.label = "Contraseña";
            this.txtClave.limiteCaracteres = 50;
            this.txtClave.Location = new System.Drawing.Point(107, 477);
            this.txtClave.Name = "txtClave";
            this.txtClave.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtClave.placeholder = "Puede contener numeros o @, #";
            this.txtClave.Size = new System.Drawing.Size(507, 48);
            this.txtClave.TabIndex = 37;
            this.txtClave.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Especial;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtUsuario.esClave = false;
            this.txtUsuario.label = "Usuario";
            this.txtUsuario.limiteCaracteres = 50;
            this.txtUsuario.Location = new System.Drawing.Point(107, 422);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtUsuario.placeholder = "Ej: usuario123";
            this.txtUsuario.Size = new System.Drawing.Size(540, 48);
            this.txtUsuario.TabIndex = 36;
            this.txtUsuario.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Especial;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtId.esClave = false;
            this.txtId.label = "Numero de identificacion";
            this.txtId.limiteCaracteres = 15;
            this.txtId.Location = new System.Drawing.Point(107, 368);
            this.txtId.Name = "txtId";
            this.txtId.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtId.placeholder = "Maximo 15 digitos";
            this.txtId.Size = new System.Drawing.Size(540, 48);
            this.txtId.TabIndex = 35;
            this.txtId.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Numerico;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtCorreo.esClave = false;
            this.txtCorreo.label = "Correo electronico";
            this.txtCorreo.limiteCaracteres = 254;
            this.txtCorreo.Location = new System.Drawing.Point(107, 314);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtCorreo.placeholder = "Ej: ejemplo@mail.com";
            this.txtCorreo.Size = new System.Drawing.Size(540, 48);
            this.txtCorreo.TabIndex = 34;
            this.txtCorreo.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Especial;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtPrimerApellido.esClave = false;
            this.txtPrimerApellido.label = "Apellido";
            this.txtPrimerApellido.limiteCaracteres = 30;
            this.txtPrimerApellido.Location = new System.Drawing.Point(384, 260);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtPrimerApellido.placeholder = "Primer apellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(263, 48);
            this.txtPrimerApellido.TabIndex = 33;
            this.txtPrimerApellido.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Texto;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtPrimerNombre.esClave = false;
            this.txtPrimerNombre.label = "Nombre";
            this.txtPrimerNombre.limiteCaracteres = 30;
            this.txtPrimerNombre.Location = new System.Drawing.Point(107, 260);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtPrimerNombre.placeholder = "Primer nombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(263, 48);
            this.txtPrimerNombre.TabIndex = 32;
            this.txtPrimerNombre.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Texto;
            // 
            // pDegradado1
            // 
            this.pDegradado1.Angle = 45F;
            this.pDegradado1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pDegradado1.HexColor1 = "#00000";
            this.pDegradado1.HexColor2 = "#5C69F5";
            this.pDegradado1.Location = new System.Drawing.Point(0, 0);
            this.pDegradado1.Margin = new System.Windows.Forms.Padding(2);
            this.pDegradado1.Name = "pDegradado1";
            this.pDegradado1.Size = new System.Drawing.Size(735, 81);
            this.pDegradado1.TabIndex = 17;
            // 
            // formRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 866);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.pDegradado2);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtPrimerApellido);
            this.Controls.Add(this.txtPrimerNombre);
            this.Controls.Add(this.lblClaveUsuario);
            this.Controls.Add(this.picOcultarClave);
            this.Controls.Add(this.picMostrarClave);
            this.Controls.Add(this.lblDatosObligatorios);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pDegradado1);
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
        private System.Windows.Forms.PictureBox picMostrarClave;
        private System.Windows.Forms.PictureBox picOcultarClave;
        private System.Windows.Forms.Label lblClaveUsuario;
        private pkgInterfaz.pLineaTextBox txtPrimerNombre;
        private pkgInterfaz.pLineaTextBox txtPrimerApellido;
        private pkgInterfaz.pLineaTextBox txtCorreo;
        private pkgInterfaz.pLineaTextBox txtId;
        private pkgInterfaz.pLineaTextBox txtUsuario;
        private pkgInterfaz.pLineaTextBox txtClave;
        private pkgInterfaz.pDegradado pDegradado2;
    }
}