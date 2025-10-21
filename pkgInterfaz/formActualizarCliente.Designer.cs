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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.picOcultarClaveActual = new System.Windows.Forms.PictureBox();
            this.picMostrarClaveActual = new System.Windows.Forms.PictureBox();
            this.picMostrarClaveNueva = new System.Windows.Forms.PictureBox();
            this.picOcultarClaveNueva = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new testForms.pkgInterfaz.placeHolderBox();
            this.txtClaveNueva = new testForms.pkgInterfaz.placeHolderBox();
            this.txtClaveActual = new testForms.pkgInterfaz.placeHolderBox();
            this.txtCorreo = new testForms.pkgInterfaz.placeHolderBox();
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
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 52);
            this.label1.TabIndex = 23;
            this.label1.Text = "Actualizacion de datos";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.Font = new System.Drawing.Font("Codec Pro", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(355, 265);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 55);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.AutoSize = true;
            this.btnVolver.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVolver.Font = new System.Drawing.Font("Codec Pro", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(668, 9);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(124, 55);
            this.btnVolver.TabIndex = 28;
            this.btnVolver.Text = " <-- Volver al menu";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Codec Pro", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(174, 137);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(77, 20);
            this.lblUsuario.TabIndex = 33;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Codec Pro", 10F, System.Drawing.FontStyle.Bold);
            this.lblCorreo.ForeColor = System.Drawing.Color.Black;
            this.lblCorreo.Location = new System.Drawing.Point(174, 162);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(70, 20);
            this.lblCorreo.TabIndex = 34;
            this.lblCorreo.Text = "Correo";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.BackColor = System.Drawing.Color.Transparent;
            this.lblClave.Font = new System.Drawing.Font("Codec Pro", 10F, System.Drawing.FontStyle.Bold);
            this.lblClave.ForeColor = System.Drawing.Color.Black;
            this.lblClave.Location = new System.Drawing.Point(151, 186);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(117, 20);
            this.lblClave.TabIndex = 35;
            this.lblClave.Text = "Contraseña";
            // 
            // picOcultarClaveActual
            // 
            this.picOcultarClaveActual.Enabled = false;
            this.picOcultarClaveActual.Image = ((System.Drawing.Image)(resources.GetObject("picOcultarClaveActual.Image")));
            this.picOcultarClaveActual.Location = new System.Drawing.Point(514, 186);
            this.picOcultarClaveActual.Name = "picOcultarClaveActual";
            this.picOcultarClaveActual.Size = new System.Drawing.Size(31, 19);
            this.picOcultarClaveActual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOcultarClaveActual.TabIndex = 36;
            this.picOcultarClaveActual.TabStop = false;
            this.picOcultarClaveActual.Visible = false;
            this.picOcultarClaveActual.Click += new System.EventHandler(this.picOcultarClaveActual_Click);
            // 
            // picMostrarClaveActual
            // 
            this.picMostrarClaveActual.Image = ((System.Drawing.Image)(resources.GetObject("picMostrarClaveActual.Image")));
            this.picMostrarClaveActual.Location = new System.Drawing.Point(514, 186);
            this.picMostrarClaveActual.Name = "picMostrarClaveActual";
            this.picMostrarClaveActual.Size = new System.Drawing.Size(31, 19);
            this.picMostrarClaveActual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMostrarClaveActual.TabIndex = 37;
            this.picMostrarClaveActual.TabStop = false;
            this.picMostrarClaveActual.Click += new System.EventHandler(this.picMostrarClaveActual_Click);
            // 
            // picMostrarClaveNueva
            // 
            this.picMostrarClaveNueva.Image = ((System.Drawing.Image)(resources.GetObject("picMostrarClaveNueva.Image")));
            this.picMostrarClaveNueva.Location = new System.Drawing.Point(514, 212);
            this.picMostrarClaveNueva.Name = "picMostrarClaveNueva";
            this.picMostrarClaveNueva.Size = new System.Drawing.Size(31, 19);
            this.picMostrarClaveNueva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMostrarClaveNueva.TabIndex = 39;
            this.picMostrarClaveNueva.TabStop = false;
            this.picMostrarClaveNueva.Click += new System.EventHandler(this.picMostrarClaveNueva_Click);
            // 
            // picOcultarClaveNueva
            // 
            this.picOcultarClaveNueva.Enabled = false;
            this.picOcultarClaveNueva.Image = ((System.Drawing.Image)(resources.GetObject("picOcultarClaveNueva.Image")));
            this.picOcultarClaveNueva.Location = new System.Drawing.Point(514, 212);
            this.picOcultarClaveNueva.Name = "picOcultarClaveNueva";
            this.picOcultarClaveNueva.Size = new System.Drawing.Size(31, 19);
            this.picOcultarClaveNueva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOcultarClaveNueva.TabIndex = 38;
            this.picOcultarClaveNueva.TabStop = false;
            this.picOcultarClaveNueva.Visible = false;
            this.picOcultarClaveNueva.Click += new System.EventHandler(this.picOcultarClaveNueva_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtUsuario.Location = new System.Drawing.Point(295, 137);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceHolder = "Usuario";
            this.txtUsuario.Size = new System.Drawing.Size(250, 19);
            this.txtUsuario.TabIndex = 32;
            // 
            // txtClaveNueva
            // 
            this.txtClaveNueva.Enabled = false;
            this.txtClaveNueva.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtClaveNueva.Location = new System.Drawing.Point(295, 212);
            this.txtClaveNueva.Name = "txtClaveNueva";
            this.txtClaveNueva.PlaceHolder = "Contraseña nueva";
            this.txtClaveNueva.Size = new System.Drawing.Size(213, 19);
            this.txtClaveNueva.TabIndex = 31;
            // 
            // txtClaveActual
            // 
            this.txtClaveActual.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtClaveActual.Location = new System.Drawing.Point(295, 187);
            this.txtClaveActual.Name = "txtClaveActual";
            this.txtClaveActual.PlaceHolder = "Contraseña actual";
            this.txtClaveActual.Size = new System.Drawing.Size(213, 19);
            this.txtClaveActual.TabIndex = 30;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtCorreo.Location = new System.Drawing.Point(295, 162);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PlaceHolder = "Correo electronico";
            this.txtCorreo.Size = new System.Drawing.Size(250, 19);
            this.txtCorreo.TabIndex = 29;
            // 
            // formActualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picMostrarClaveNueva);
            this.Controls.Add(this.picOcultarClaveNueva);
            this.Controls.Add(this.picMostrarClaveActual);
            this.Controls.Add(this.picOcultarClaveActual);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtClaveNueva);
            this.Controls.Add(this.txtClaveActual);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
        private placeHolderBox txtCorreo;
        private placeHolderBox txtClaveActual;
        private placeHolderBox txtClaveNueva;
        private placeHolderBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.PictureBox picOcultarClaveActual;
        private System.Windows.Forms.PictureBox picMostrarClaveActual;
        private System.Windows.Forms.PictureBox picMostrarClaveNueva;
        private System.Windows.Forms.PictureBox picOcultarClaveNueva;
    }
}