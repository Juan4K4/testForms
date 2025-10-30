﻿namespace testForms
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
            this.lblDatosObligatorios = new System.Windows.Forms.Label();
            this.lblClaveUsuario = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.lblFechaIncompleta = new System.Windows.Forms.Label();
            this.pBoton2 = new testForms.pkgInterfaz.pBoton();
            this.pBoton1 = new testForms.pkgInterfaz.pBoton();
            this.pDegradado1 = new testForms.pkgInterfaz.pDegradado();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoginBack = new testForms.pkgInterfaz.pBoton();
            this.btnRegistrar = new testForms.pkgInterfaz.pBoton();
            this.txtClave = new testForms.pkgInterfaz.pLineaTextBox();
            this.txtUsuario = new testForms.pkgInterfaz.pLineaTextBox();
            this.txtId = new testForms.pkgInterfaz.pLineaTextBox();
            this.txtCorreo = new testForms.pkgInterfaz.pLineaTextBox();
            this.txtPrimerApellido = new testForms.pkgInterfaz.pLineaTextBox();
            this.txtPrimerNombre = new testForms.pkgInterfaz.pLineaTextBox();
            this.picOcultarClave = new System.Windows.Forms.PictureBox();
            this.picMostrarClave = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pDegradado1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOcultarClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrarClave)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistroCliente
            // 
            this.lblRegistroCliente.AutoSize = true;
            this.lblRegistroCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistroCliente.Font = new System.Drawing.Font("Codec Pro Bold", 40F);
            this.lblRegistroCliente.ForeColor = System.Drawing.Color.Black;
            this.lblRegistroCliente.Location = new System.Drawing.Point(235, 188);
            this.lblRegistroCliente.Name = "lblRegistroCliente";
            this.lblRegistroCliente.Size = new System.Drawing.Size(543, 82);
            this.lblRegistroCliente.TabIndex = 1;
            this.lblRegistroCliente.Text = "Registro Cliente";
            this.lblRegistroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDatosObligatorios
            // 
            this.lblDatosObligatorios.AutoSize = true;
            this.lblDatosObligatorios.CausesValidation = false;
            this.lblDatosObligatorios.Font = new System.Drawing.Font("Codec Pro", 10F);
            this.lblDatosObligatorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDatosObligatorios.Location = new System.Drawing.Point(346, 882);
            this.lblDatosObligatorios.Name = "lblDatosObligatorios";
            this.lblDatosObligatorios.Size = new System.Drawing.Size(333, 20);
            this.lblDatosObligatorios.TabIndex = 21;
            this.lblDatosObligatorios.Text = "Ingrese todos los campos para continuar";
            // 
            // lblClaveUsuario
            // 
            this.lblClaveUsuario.CausesValidation = false;
            this.lblClaveUsuario.Font = new System.Drawing.Font("Codec Pro", 10F);
            this.lblClaveUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblClaveUsuario.Location = new System.Drawing.Point(119, 666);
            this.lblClaveUsuario.Name = "lblClaveUsuario";
            this.lblClaveUsuario.Size = new System.Drawing.Size(680, 28);
            this.lblClaveUsuario.TabIndex = 29;
            this.lblClaveUsuario.Text = "La contraseña no puede ser igual al nombre de usuario";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(427, 79);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(189, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // cmbMes
            // 
            this.cmbMes.Font = new System.Drawing.Font("Codec Pro Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbMes.Location = new System.Drawing.Point(452, 736);
            this.cmbMes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(159, 39);
            this.cmbMes.TabIndex = 45;
            this.cmbMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbMes_KeyPress);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.CausesValidation = false;
            this.lblFechaNac.Font = new System.Drawing.Font("Codec Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.ForeColor = System.Drawing.Color.Black;
            this.lblFechaNac.Location = new System.Drawing.Point(416, 704);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(232, 28);
            this.lblFechaNac.TabIndex = 46;
            this.lblFechaNac.Text = "Fecha de nacimiento:";
            // 
            // cmbDia
            // 
            this.cmbDia.Font = new System.Drawing.Font("Codec Pro Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbDia.Location = new System.Drawing.Point(334, 736);
            this.cmbDia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(108, 39);
            this.cmbDia.TabIndex = 47;
            this.cmbDia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDia_KeyPress);
            // 
            // cmbAnio
            // 
            this.cmbAnio.Font = new System.Drawing.Font("Codec Pro Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.Location = new System.Drawing.Point(620, 736);
            this.cmbAnio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(108, 39);
            this.cmbAnio.TabIndex = 48;
            this.cmbAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbAnio_KeyPress);
            // 
            // lblFechaIncompleta
            // 
            this.lblFechaIncompleta.AutoSize = true;
            this.lblFechaIncompleta.CausesValidation = false;
            this.lblFechaIncompleta.Font = new System.Drawing.Font("Codec Pro", 10F);
            this.lblFechaIncompleta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaIncompleta.Location = new System.Drawing.Point(336, 784);
            this.lblFechaIncompleta.Name = "lblFechaIncompleta";
            this.lblFechaIncompleta.Size = new System.Drawing.Size(213, 20);
            this.lblFechaIncompleta.TabIndex = 49;
            this.lblFechaIncompleta.Text = "La fecha esta incompleta";
            this.lblFechaIncompleta.Visible = false;
            // 
            // pBoton2
            // 
            this.pBoton2.BackColor = System.Drawing.Color.DimGray;
            this.pBoton2.BackgroundColor = System.Drawing.Color.DimGray;
            this.pBoton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pBoton2.BorderRadius = 5;
            this.pBoton2.BorderSize = 0;
            this.pBoton2.FlatAppearance.BorderSize = 0;
            this.pBoton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pBoton2.Font = new System.Drawing.Font("Codec Pro Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBoton2.ForeColor = System.Drawing.Color.White;
            this.pBoton2.Location = new System.Drawing.Point(928, 10);
            this.pBoton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pBoton2.Name = "pBoton2";
            this.pBoton2.Size = new System.Drawing.Size(51, 30);
            this.pBoton2.TabIndex = 52;
            this.pBoton2.Text = "-";
            this.pBoton2.TextColor = System.Drawing.Color.White;
            this.pBoton2.UseVisualStyleBackColor = false;
            this.pBoton2.Click += new System.EventHandler(this.pBoton2_Click);
            // 
            // pBoton1
            // 
            this.pBoton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pBoton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pBoton1.BorderColor = System.Drawing.Color.White;
            this.pBoton1.BorderRadius = 5;
            this.pBoton1.BorderSize = 0;
            this.pBoton1.FlatAppearance.BorderSize = 0;
            this.pBoton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pBoton1.Font = new System.Drawing.Font("Codec Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBoton1.ForeColor = System.Drawing.Color.White;
            this.pBoton1.Location = new System.Drawing.Point(981, 10);
            this.pBoton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pBoton1.Name = "pBoton1";
            this.pBoton1.Size = new System.Drawing.Size(51, 30);
            this.pBoton1.TabIndex = 51;
            this.pBoton1.Text = "X";
            this.pBoton1.TextColor = System.Drawing.Color.White;
            this.pBoton1.UseVisualStyleBackColor = false;
            this.pBoton1.Click += new System.EventHandler(this.pBoton1_Click_1);
            // 
            // pDegradado1
            // 
            this.pDegradado1.Angle = 90F;
            this.pDegradado1.Controls.Add(this.label1);
            this.pDegradado1.Controls.Add(this.btnLoginBack);
            this.pDegradado1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pDegradado1.HexColor1 = "#E6E6E6";
            this.pDegradado1.HexColor2 = "#5C69F5";
            this.pDegradado1.Location = new System.Drawing.Point(0, 946);
            this.pDegradado1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pDegradado1.Name = "pDegradado1";
            this.pDegradado1.Size = new System.Drawing.Size(1100, 154);
            this.pDegradado1.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Codec Pro Bold", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(413, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ya tiene una cuenta?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoginBack
            // 
            this.btnLoginBack.AutoSize = true;
            this.btnLoginBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(146)))), ((int)(((byte)(36)))));
            this.btnLoginBack.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(146)))), ((int)(((byte)(36)))));
            this.btnLoginBack.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLoginBack.BorderRadius = 8;
            this.btnLoginBack.BorderSize = 0;
            this.btnLoginBack.FlatAppearance.BorderSize = 0;
            this.btnLoginBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginBack.Font = new System.Drawing.Font("Codec Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginBack.ForeColor = System.Drawing.Color.White;
            this.btnLoginBack.Location = new System.Drawing.Point(447, 59);
            this.btnLoginBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoginBack.Name = "btnLoginBack";
            this.btnLoginBack.Size = new System.Drawing.Size(160, 46);
            this.btnLoginBack.TabIndex = 44;
            this.btnLoginBack.Text = "Iniciar Sesion";
            this.btnLoginBack.TextColor = System.Drawing.Color.White;
            this.btnLoginBack.UseVisualStyleBackColor = false;
            this.btnLoginBack.Click += new System.EventHandler(this.btnLoginBack_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AutoSize = true;
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.btnRegistrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.btnRegistrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRegistrar.BorderRadius = 8;
            this.btnRegistrar.BorderSize = 0;
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Codec Pro Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(432, 813);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(200, 60);
            this.btnRegistrar.TabIndex = 43;
            this.btnRegistrar.Text = "Registrarse";
            this.btnRegistrar.TextColor = System.Drawing.Color.White;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtClave.esClave = true;
            this.txtClave.label = "Contraseña";
            this.txtClave.limiteCaracteres = 50;
            this.txtClave.Location = new System.Drawing.Point(105, 594);
            this.txtClave.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtClave.Name = "txtClave";
            this.txtClave.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtClave.placeholder = "Puede contener numeros o @, #";
            this.txtClave.Radius = 8;
            this.txtClave.Size = new System.Drawing.Size(751, 68);
            this.txtClave.TabIndex = 37;
            this.txtClave.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Especial;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtUsuario.esClave = false;
            this.txtUsuario.label = "Usuario";
            this.txtUsuario.limiteCaracteres = 50;
            this.txtUsuario.Location = new System.Drawing.Point(105, 519);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtUsuario.placeholder = "Ej: usuario123";
            this.txtUsuario.Radius = 8;
            this.txtUsuario.Size = new System.Drawing.Size(843, 68);
            this.txtUsuario.TabIndex = 36;
            this.txtUsuario.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Especial;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtId.esClave = false;
            this.txtId.label = "Numero de identificacion";
            this.txtId.limiteCaracteres = 15;
            this.txtId.Location = new System.Drawing.Point(105, 444);
            this.txtId.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtId.Name = "txtId";
            this.txtId.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtId.placeholder = "Maximo 15 digitos";
            this.txtId.Radius = 8;
            this.txtId.Size = new System.Drawing.Size(843, 68);
            this.txtId.TabIndex = 35;
            this.txtId.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Numerico;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtCorreo.esClave = false;
            this.txtCorreo.label = "Correo electronico";
            this.txtCorreo.limiteCaracteres = 254;
            this.txtCorreo.Location = new System.Drawing.Point(105, 369);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtCorreo.placeholder = "Ej: ejemplo@mail.com";
            this.txtCorreo.Radius = 8;
            this.txtCorreo.Size = new System.Drawing.Size(843, 68);
            this.txtCorreo.TabIndex = 34;
            this.txtCorreo.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Especial;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtPrimerApellido.esClave = false;
            this.txtPrimerApellido.label = "Apellido";
            this.txtPrimerApellido.limiteCaracteres = 30;
            this.txtPrimerApellido.Location = new System.Drawing.Point(531, 294);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtPrimerApellido.placeholder = "Primer apellido";
            this.txtPrimerApellido.Radius = 8;
            this.txtPrimerApellido.Size = new System.Drawing.Size(417, 68);
            this.txtPrimerApellido.TabIndex = 33;
            this.txtPrimerApellido.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Texto;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtPrimerNombre.esClave = false;
            this.txtPrimerNombre.label = "Nombre";
            this.txtPrimerNombre.limiteCaracteres = 30;
            this.txtPrimerNombre.Location = new System.Drawing.Point(104, 296);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtPrimerNombre.placeholder = "Primer nombre";
            this.txtPrimerNombre.Radius = 8;
            this.txtPrimerNombre.Size = new System.Drawing.Size(417, 68);
            this.txtPrimerNombre.TabIndex = 32;
            this.txtPrimerNombre.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Texto;
            // 
            // picOcultarClave
            // 
            this.picOcultarClave.Enabled = false;
            this.picOcultarClave.Image = ((System.Drawing.Image)(resources.GetObject("picOcultarClave.Image")));
            this.picOcultarClave.Location = new System.Drawing.Point(864, 624);
            this.picOcultarClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picOcultarClave.Name = "picOcultarClave";
            this.picOcultarClave.Size = new System.Drawing.Size(48, 34);
            this.picOcultarClave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOcultarClave.TabIndex = 53;
            this.picOcultarClave.TabStop = false;
            this.picOcultarClave.Visible = false;
            this.picOcultarClave.Click += new System.EventHandler(this.picOcultarClave_Click);
            // 
            // picMostrarClave
            // 
            this.picMostrarClave.Image = ((System.Drawing.Image)(resources.GetObject("picMostrarClave.Image")));
            this.picMostrarClave.Location = new System.Drawing.Point(864, 624);
            this.picMostrarClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMostrarClave.Name = "picMostrarClave";
            this.picMostrarClave.Size = new System.Drawing.Size(48, 34);
            this.picMostrarClave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMostrarClave.TabIndex = 54;
            this.picMostrarClave.TabStop = false;
            this.picMostrarClave.Click += new System.EventHandler(this.picMostrarClave_Click);
            // 
            // formRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1100, 1100);
            this.Controls.Add(this.picMostrarClave);
            this.Controls.Add(this.picOcultarClave);
            this.Controls.Add(this.pBoton2);
            this.Controls.Add(this.pBoton1);
            this.Controls.Add(this.lblFechaIncompleta);
            this.Controls.Add(this.cmbAnio);
            this.Controls.Add(this.cmbDia);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtPrimerApellido);
            this.Controls.Add(this.txtPrimerNombre);
            this.Controls.Add(this.lblClaveUsuario);
            this.Controls.Add(this.lblDatosObligatorios);
            this.Controls.Add(this.lblRegistroCliente);
            this.Controls.Add(this.pDegradado1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formRegistro";
            this.Load += new System.EventHandler(this.formRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pDegradado1.ResumeLayout(false);
            this.pDegradado1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOcultarClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrarClave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistroCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDatosObligatorios;
        private System.Windows.Forms.Label lblClaveUsuario;
        private pkgInterfaz.pLineaTextBox txtPrimerNombre;
        private pkgInterfaz.pLineaTextBox txtPrimerApellido;
        private pkgInterfaz.pLineaTextBox txtCorreo;
        private pkgInterfaz.pLineaTextBox txtId;
        private pkgInterfaz.pLineaTextBox txtUsuario;
        private pkgInterfaz.pLineaTextBox txtClave;
        private System.Windows.Forms.PictureBox pictureBox2;
        private pkgInterfaz.pBoton btnRegistrar;
        private pkgInterfaz.pBoton btnLoginBack;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.ComboBox cmbAnio;
        private System.Windows.Forms.Label lblFechaIncompleta;
        private pkgInterfaz.pDegradado pDegradado1;
        private pkgInterfaz.pBoton pBoton2;
        private pkgInterfaz.pBoton pBoton1;
        private System.Windows.Forms.PictureBox picOcultarClave;
        private System.Windows.Forms.PictureBox picMostrarClave;
    }
}