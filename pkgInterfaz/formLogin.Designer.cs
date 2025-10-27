namespace testForms
{
    partial class formLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.lblEntrar = new System.Windows.Forms.Label();
            this.lblNoRegistrado = new System.Windows.Forms.Label();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblErrorUsuario = new System.Windows.Forms.Label();
            this.lblErrorClave = new System.Windows.Forms.Label();
            this.picMostrarClave = new System.Windows.Forms.PictureBox();
            this.picOcultarClave = new System.Windows.Forms.PictureBox();
            this.txtClave = new testForms.pkgInterfaz.placeHolderBox();
            this.txtUsuario = new testForms.pkgInterfaz.placeHolderBox();
            this.pDegradado1 = new testForms.pkgInterfaz.pDegradado();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrarClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOcultarClave)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEntrar
            // 
            this.lblEntrar.AutoSize = true;
            this.lblEntrar.BackColor = System.Drawing.Color.Transparent;
            this.lblEntrar.Font = new System.Drawing.Font("Codec Pro Bold", 40F);
            this.lblEntrar.ForeColor = System.Drawing.Color.Black;
            this.lblEntrar.Location = new System.Drawing.Point(155, 223);
            this.lblEntrar.Name = "lblEntrar";
            this.lblEntrar.Size = new System.Drawing.Size(234, 82);
            this.lblEntrar.TabIndex = 0;
            this.lblEntrar.Text = "Entrar";
            // 
            // lblNoRegistrado
            // 
            this.lblNoRegistrado.AutoSize = true;
            this.lblNoRegistrado.BackColor = System.Drawing.Color.Transparent;
            this.lblNoRegistrado.Font = new System.Drawing.Font("Codec Pro Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRegistrado.ForeColor = System.Drawing.Color.Black;
            this.lblNoRegistrado.Location = new System.Drawing.Point(208, 511);
            this.lblNoRegistrado.Name = "lblNoRegistrado";
            this.lblNoRegistrado.Size = new System.Drawing.Size(126, 16);
            this.lblNoRegistrado.TabIndex = 3;
            this.lblNoRegistrado.Text = "No esta registrado?";
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.AutoSize = true;
            this.btnRegistrarse.BackColor = System.Drawing.Color.Orange;
            this.btnRegistrarse.Font = new System.Drawing.Font("Codec Pro Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.Location = new System.Drawing.Point(221, 530);
            this.btnRegistrarse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(108, 43);
            this.btnRegistrarse.TabIndex = 4;
            this.btnRegistrarse.Text = "Registrarme";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.AutoSize = true;
            this.btnIniciarSesion.BackColor = System.Drawing.Color.Orange;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Codec Pro Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(221, 427);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(119, 43);
            this.btnIniciarSesion.TabIndex = 5;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(197, 108);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(148, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // lblErrorUsuario
            // 
            this.lblErrorUsuario.AutoSize = true;
            this.lblErrorUsuario.CausesValidation = false;
            this.lblErrorUsuario.Font = new System.Drawing.Font("Codec Pro", 7F);
            this.lblErrorUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrorUsuario.Location = new System.Drawing.Point(143, 364);
            this.lblErrorUsuario.Name = "lblErrorUsuario";
            this.lblErrorUsuario.Size = new System.Drawing.Size(151, 14);
            this.lblErrorUsuario.TabIndex = 24;
            this.lblErrorUsuario.Text = "Ingrese un usuario valido";
            // 
            // lblErrorClave
            // 
            this.lblErrorClave.AutoSize = true;
            this.lblErrorClave.CausesValidation = false;
            this.lblErrorClave.Font = new System.Drawing.Font("Codec Pro", 7F);
            this.lblErrorClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrorClave.Location = new System.Drawing.Point(143, 405);
            this.lblErrorClave.Name = "lblErrorClave";
            this.lblErrorClave.Size = new System.Drawing.Size(145, 14);
            this.lblErrorClave.TabIndex = 25;
            this.lblErrorClave.Text = "Ingrese una contraseña";
            // 
            // picMostrarClave
            // 
            this.picMostrarClave.Image = ((System.Drawing.Image)(resources.GetObject("picMostrarClave.Image")));
            this.picMostrarClave.Location = new System.Drawing.Point(365, 383);
            this.picMostrarClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMostrarClave.Name = "picMostrarClave";
            this.picMostrarClave.Size = new System.Drawing.Size(31, 18);
            this.picMostrarClave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMostrarClave.TabIndex = 28;
            this.picMostrarClave.TabStop = false;
            this.picMostrarClave.Click += new System.EventHandler(this.picMostrarClave_Click);
            // 
            // picOcultarClave
            // 
            this.picOcultarClave.Enabled = false;
            this.picOcultarClave.Image = ((System.Drawing.Image)(resources.GetObject("picOcultarClave.Image")));
            this.picOcultarClave.Location = new System.Drawing.Point(365, 383);
            this.picOcultarClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picOcultarClave.Name = "picOcultarClave";
            this.picOcultarClave.Size = new System.Drawing.Size(31, 18);
            this.picOcultarClave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOcultarClave.TabIndex = 29;
            this.picOcultarClave.TabStop = false;
            this.picOcultarClave.Visible = false;
            this.picOcultarClave.Click += new System.EventHandler(this.picOcultarClave_Click);
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtClave.Location = new System.Drawing.Point(147, 383);
            this.txtClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClave.Name = "txtClave";
            this.txtClave.PlaceHolder = "Contraseña";
            this.txtClave.Size = new System.Drawing.Size(213, 19);
            this.txtClave.TabIndex = 23;
            this.txtClave.Text = "juan";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtUsuario.Location = new System.Drawing.Point(147, 342);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceHolder = "Usuario";
            this.txtUsuario.Size = new System.Drawing.Size(249, 19);
            this.txtUsuario.TabIndex = 22;
            this.txtUsuario.Text = "juan";
            // 
            // pDegradado1
            // 
            this.pDegradado1.Angle = 45F;
            this.pDegradado1.AutoSize = true;
            this.pDegradado1.HexColor1 = "#000000";
            this.pDegradado1.HexColor2 = "#5C69F5";
            this.pDegradado1.Location = new System.Drawing.Point(-3, -1);
            this.pDegradado1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pDegradado1.Name = "pDegradado1";
            this.pDegradado1.Size = new System.Drawing.Size(549, 103);
            this.pDegradado1.TabIndex = 8;
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 628);
            this.Controls.Add(this.picOcultarClave);
            this.Controls.Add(this.picMostrarClave);
            this.Controls.Add(this.lblErrorClave);
            this.Controls.Add(this.lblErrorUsuario);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pDegradado1);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.lblNoRegistrado);
            this.Controls.Add(this.lblEntrar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrarClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOcultarClave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntrar;
        private System.Windows.Forms.Label lblNoRegistrado;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Button btnIniciarSesion;
        private pkgInterfaz.pDegradado pDegradado1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private pkgInterfaz.placeHolderBox txtUsuario;
        private pkgInterfaz.placeHolderBox txtClave;
        private System.Windows.Forms.Label lblErrorUsuario;
        private System.Windows.Forms.Label lblErrorClave;
        private System.Windows.Forms.PictureBox picMostrarClave;
        private System.Windows.Forms.PictureBox picOcultarClave;
    }
}

