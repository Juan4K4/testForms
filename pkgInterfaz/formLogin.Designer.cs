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
            this.pDegradado1 = new testForms.pkgInterfaz.pDegradado();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new testForms.pkgInterfaz.placeHolderBox();
            this.txtClave = new testForms.pkgInterfaz.placeHolderBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEntrar
            // 
            this.lblEntrar.AutoSize = true;
            this.lblEntrar.BackColor = System.Drawing.Color.Transparent;
            this.lblEntrar.Font = new System.Drawing.Font("Codec Pro Bold", 40F);
            this.lblEntrar.ForeColor = System.Drawing.Color.Black;
            this.lblEntrar.Location = new System.Drawing.Point(154, 223);
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
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(100, 43);
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
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(100, 43);
            this.btnIniciarSesion.TabIndex = 5;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // pDegradado1
            // 
            this.pDegradado1.Angle = 45F;
            this.pDegradado1.AutoSize = true;
            this.pDegradado1.HexColor1 = "#000000";
            this.pDegradado1.HexColor2 = "#5C69F5";
            this.pDegradado1.Location = new System.Drawing.Point(-3, -1);
            this.pDegradado1.Name = "pDegradado1";
            this.pDegradado1.Size = new System.Drawing.Size(549, 104);
            this.pDegradado1.TabIndex = 8;
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
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtUsuario.Location = new System.Drawing.Point(146, 342);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceHolder = "Usuario";
            this.txtUsuario.Size = new System.Drawing.Size(250, 19);
            this.txtUsuario.TabIndex = 22;
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtClave.Location = new System.Drawing.Point(146, 383);
            this.txtClave.Name = "txtClave";
            this.txtClave.PlaceHolder = "Contraseña";
            this.txtClave.Size = new System.Drawing.Size(250, 19);
            this.txtClave.TabIndex = 23;
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(546, 723);
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
            this.Name = "formLogin";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
    }
}

