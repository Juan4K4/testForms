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
            this.lblEntrar = new System.Windows.Forms.Label();
            this.lblNoRegistrado = new System.Windows.Forms.Label();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.txtContraseña = new testForms.pkgInterfaz.phTextBox();
            this.txtUsuario = new testForms.pkgInterfaz.phTextBox();
            this.SuspendLayout();
            // 
            // lblEntrar
            // 
            this.lblEntrar.AutoSize = true;
            this.lblEntrar.BackColor = System.Drawing.Color.Transparent;
            this.lblEntrar.Font = new System.Drawing.Font("Codec Pro Bold", 40F);
            this.lblEntrar.Location = new System.Drawing.Point(151, 144);
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
            this.lblNoRegistrado.Location = new System.Drawing.Point(205, 511);
            this.lblNoRegistrado.Name = "lblNoRegistrado";
            this.lblNoRegistrado.Size = new System.Drawing.Size(126, 16);
            this.lblNoRegistrado.TabIndex = 3;
            this.lblNoRegistrado.Text = "No esta registrado?";
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.Orange;
            this.btnRegistrarse.Font = new System.Drawing.Font("Codec Pro Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.Location = new System.Drawing.Point(218, 530);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(100, 43);
            this.btnRegistrarse.TabIndex = 4;
            this.btnRegistrarse.Text = "Registrarme";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.Orange;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Codec Pro Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(218, 348);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(100, 43);
            this.btnIniciarSesion.TabIndex = 5;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txtContraseña.Location = new System.Drawing.Point(143, 301);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PlaceHolder = "Contraseña";
            this.txtContraseña.Size = new System.Drawing.Size(250, 19);
            this.txtContraseña.TabIndex = 7;
            this.txtContraseña.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsuario.Location = new System.Drawing.Point(143, 254);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceHolder = "Usuario";
            this.txtUsuario.Size = new System.Drawing.Size(250, 19);
            this.txtUsuario.TabIndex = 6;
            this.txtUsuario.Text = "Usuario";
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(546, 723);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.lblNoRegistrado);
            this.Controls.Add(this.lblEntrar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntrar;
        private System.Windows.Forms.Label lblNoRegistrado;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Button btnIniciarSesion;
        private pkgInterfaz.phTextBox txtUsuario;
        private pkgInterfaz.phTextBox txtContraseña;
    }
}

