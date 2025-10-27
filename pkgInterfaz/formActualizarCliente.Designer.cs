namespace testForms.pkgInterfaz
{
    partial class formActualizarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formActualizarCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.picOcultarClaveActual = new System.Windows.Forms.PictureBox();
            this.picMostrarClaveActual = new System.Windows.Forms.PictureBox();
            this.picMostrarClaveNueva = new System.Windows.Forms.PictureBox();
            this.picOcultarClaveNueva = new System.Windows.Forms.PictureBox();
            this.txtClaveNueva = new testForms.pkgInterfaz.pLineaTextBox();
            this.txtClaveActual = new testForms.pkgInterfaz.pLineaTextBox();
            this.txtCorreo = new testForms.pkgInterfaz.pLineaTextBox();
            this.txtUsuario = new testForms.pkgInterfaz.pLineaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOcultarClaveActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrarClaveActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrarClaveNueva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOcultarClaveNueva)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Codec Pro Bold", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 42);
            this.label1.TabIndex = 23;
            this.label1.Text = "Actualizacion de datos";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Codec Pro", 12F);
            this.btnGuardar.ForeColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Location = new System.Drawing.Point(220, 292);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(154, 45);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.AutoSize = true;
            this.btnVolver.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.btnVolver.ForeColor = System.Drawing.Color.Transparent;
            this.btnVolver.Location = new System.Drawing.Point(532, 11);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(118, 38);
            this.btnVolver.TabIndex = 28;
            this.btnVolver.Text = "Volver al inicio";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // picOcultarClaveActual
            // 
            this.picOcultarClaveActual.Enabled = false;
            this.picOcultarClaveActual.Image = ((System.Drawing.Image)(resources.GetObject("picOcultarClaveActual.Image")));
            this.picOcultarClaveActual.Location = new System.Drawing.Point(472, 196);
            this.picOcultarClaveActual.Margin = new System.Windows.Forms.Padding(2);
            this.picOcultarClaveActual.Name = "picOcultarClaveActual";
            this.picOcultarClaveActual.Size = new System.Drawing.Size(32, 28);
            this.picOcultarClaveActual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOcultarClaveActual.TabIndex = 36;
            this.picOcultarClaveActual.TabStop = false;
            this.picOcultarClaveActual.Visible = false;
            this.picOcultarClaveActual.Click += new System.EventHandler(this.picOcultarClaveActual_Click);
            // 
            // picMostrarClaveActual
            // 
            this.picMostrarClaveActual.Image = ((System.Drawing.Image)(resources.GetObject("picMostrarClaveActual.Image")));
            this.picMostrarClaveActual.Location = new System.Drawing.Point(472, 196);
            this.picMostrarClaveActual.Margin = new System.Windows.Forms.Padding(2);
            this.picMostrarClaveActual.Name = "picMostrarClaveActual";
            this.picMostrarClaveActual.Size = new System.Drawing.Size(32, 28);
            this.picMostrarClaveActual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMostrarClaveActual.TabIndex = 37;
            this.picMostrarClaveActual.TabStop = false;
            this.picMostrarClaveActual.Click += new System.EventHandler(this.picMostrarClaveActual_Click);
            // 
            // picMostrarClaveNueva
            // 
            this.picMostrarClaveNueva.Image = ((System.Drawing.Image)(resources.GetObject("picMostrarClaveNueva.Image")));
            this.picMostrarClaveNueva.Location = new System.Drawing.Point(472, 246);
            this.picMostrarClaveNueva.Margin = new System.Windows.Forms.Padding(2);
            this.picMostrarClaveNueva.Name = "picMostrarClaveNueva";
            this.picMostrarClaveNueva.Size = new System.Drawing.Size(32, 28);
            this.picMostrarClaveNueva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMostrarClaveNueva.TabIndex = 39;
            this.picMostrarClaveNueva.TabStop = false;
            this.picMostrarClaveNueva.Click += new System.EventHandler(this.picMostrarClaveNueva_Click);
            // 
            // picOcultarClaveNueva
            // 
            this.picOcultarClaveNueva.Enabled = false;
            this.picOcultarClaveNueva.Image = ((System.Drawing.Image)(resources.GetObject("picOcultarClaveNueva.Image")));
            this.picOcultarClaveNueva.Location = new System.Drawing.Point(472, 246);
            this.picOcultarClaveNueva.Margin = new System.Windows.Forms.Padding(2);
            this.picOcultarClaveNueva.Name = "picOcultarClaveNueva";
            this.picOcultarClaveNueva.Size = new System.Drawing.Size(32, 28);
            this.picOcultarClaveNueva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOcultarClaveNueva.TabIndex = 38;
            this.picOcultarClaveNueva.TabStop = false;
            this.picOcultarClaveNueva.Visible = false;
            this.picOcultarClaveNueva.Click += new System.EventHandler(this.picOcultarClaveNueva_Click);
            // 
            // txtClaveNueva
            // 
            this.txtClaveNueva.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtClaveNueva.esClave = false;
            this.txtClaveNueva.label = "Nueva contraseña";
            this.txtClaveNueva.limiteCaracteres = 0;
            this.txtClaveNueva.Location = new System.Drawing.Point(128, 230);
            this.txtClaveNueva.Name = "txtClaveNueva";
            this.txtClaveNueva.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtClaveNueva.placeholder = "Puede contener numeros o @, #";
            this.txtClaveNueva.Size = new System.Drawing.Size(339, 44);
            this.txtClaveNueva.TabIndex = 43;
            this.txtClaveNueva.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Especial;
            // 
            // txtClaveActual
            // 
            this.txtClaveActual.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtClaveActual.esClave = false;
            this.txtClaveActual.label = "Confirmar contraseña";
            this.txtClaveActual.limiteCaracteres = 50;
            this.txtClaveActual.Location = new System.Drawing.Point(128, 180);
            this.txtClaveActual.Name = "txtClaveActual";
            this.txtClaveActual.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtClaveActual.placeholder = "Confirmar contraseña";
            this.txtClaveActual.Size = new System.Drawing.Size(339, 44);
            this.txtClaveActual.TabIndex = 42;
            this.txtClaveActual.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Especial;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtCorreo.esClave = false;
            this.txtCorreo.label = "Tu correo electronico";
            this.txtCorreo.limiteCaracteres = 254;
            this.txtCorreo.Location = new System.Drawing.Point(128, 130);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtCorreo.placeholder = "Correo electronico";
            this.txtCorreo.Size = new System.Drawing.Size(339, 44);
            this.txtCorreo.TabIndex = 41;
            this.txtCorreo.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Especial;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtUsuario.esClave = false;
            this.txtUsuario.label = "Tu usuario de ingreso";
            this.txtUsuario.limiteCaracteres = 50;
            this.txtUsuario.Location = new System.Drawing.Point(128, 80);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtUsuario.placeholder = "Usuario";
            this.txtUsuario.Size = new System.Drawing.Size(339, 44);
            this.txtUsuario.TabIndex = 40;
            this.txtUsuario.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Especial;
            // 
            // formActualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(659, 367);
            this.Controls.Add(this.txtClaveNueva);
            this.Controls.Add(this.txtClaveActual);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.picMostrarClaveNueva);
            this.Controls.Add(this.picOcultarClaveNueva);
            this.Controls.Add(this.picMostrarClaveActual);
            this.Controls.Add(this.picOcultarClaveActual);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formActualizarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.picOcultarClaveActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrarClaveActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrarClaveNueva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOcultarClaveNueva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox picOcultarClaveActual;
        private System.Windows.Forms.PictureBox picMostrarClaveActual;
        private System.Windows.Forms.PictureBox picMostrarClaveNueva;
        private System.Windows.Forms.PictureBox picOcultarClaveNueva;
        private pLineaTextBox txtUsuario;
        private pLineaTextBox txtCorreo;
        private pLineaTextBox txtClaveActual;
        private pLineaTextBox txtClaveNueva;
    }
}