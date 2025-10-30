namespace testForms.pkgInterfaz
{
    partial class formEnviar
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblErrorMonto = new System.Windows.Forms.Label();
            this.lblErrorCuenta = new System.Windows.Forms.Label();
            this.txtMonto = new testForms.pkgInterfaz.pLineaTextBox();
            this.txtNumeroCuenta = new testForms.pkgInterfaz.pLineaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnviar = new testForms.pkgInterfaz.pBoton();
            this.label3 = new System.Windows.Forms.Label();
            this.pBoton2 = new testForms.pkgInterfaz.pBoton();
            this.pBoton1 = new testForms.pkgInterfaz.pBoton();
            this.lblMismaCuenta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Codec Pro Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 99);
            this.label1.TabIndex = 24;
            this.label1.Text = "Enviar dinero";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldo.Font = new System.Drawing.Font("Codec Pro", 15F);
            this.lblSaldo.ForeColor = System.Drawing.Color.Black;
            this.lblSaldo.Location = new System.Drawing.Point(288, 138);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(81, 30);
            this.lblSaldo.TabIndex = 28;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblErrorMonto
            // 
            this.lblErrorMonto.AutoSize = true;
            this.lblErrorMonto.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMonto.Font = new System.Drawing.Font("Codec Pro", 10F);
            this.lblErrorMonto.ForeColor = System.Drawing.Color.Brown;
            this.lblErrorMonto.Location = new System.Drawing.Point(384, 374);
            this.lblErrorMonto.Name = "lblErrorMonto";
            this.lblErrorMonto.Size = new System.Drawing.Size(198, 20);
            this.lblErrorMonto.TabIndex = 29;
            this.lblErrorMonto.Text = "Ingrese un monto valido";
            this.lblErrorMonto.Visible = false;
            // 
            // lblErrorCuenta
            // 
            this.lblErrorCuenta.AutoSize = true;
            this.lblErrorCuenta.Font = new System.Drawing.Font("Codec Pro", 10F);
            this.lblErrorCuenta.ForeColor = System.Drawing.Color.Brown;
            this.lblErrorCuenta.Location = new System.Drawing.Point(384, 276);
            this.lblErrorCuenta.Name = "lblErrorCuenta";
            this.lblErrorCuenta.Size = new System.Drawing.Size(290, 20);
            this.lblErrorCuenta.TabIndex = 32;
            this.lblErrorCuenta.Text = "Ingrese un numero de cuenta valido";
            this.lblErrorCuenta.Visible = false;
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtMonto.esClave = false;
            this.txtMonto.label = "Monto";
            this.txtMonto.limiteCaracteres = 10;
            this.txtMonto.Location = new System.Drawing.Point(373, 305);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(5);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtMonto.placeholder = "Cantidad a enviar";
            this.txtMonto.Radius = 8;
            this.txtMonto.Size = new System.Drawing.Size(333, 68);
            this.txtMonto.TabIndex = 31;
            this.txtMonto.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Numerico;
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtNumeroCuenta.esClave = false;
            this.txtNumeroCuenta.label = "Cuenta destino";
            this.txtNumeroCuenta.limiteCaracteres = 8;
            this.txtNumeroCuenta.Location = new System.Drawing.Point(373, 207);
            this.txtNumeroCuenta.Margin = new System.Windows.Forms.Padding(5);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtNumeroCuenta.placeholder = "Numero de cuenta";
            this.txtNumeroCuenta.Radius = 8;
            this.txtNumeroCuenta.Size = new System.Drawing.Size(333, 68);
            this.txtNumeroCuenta.TabIndex = 30;
            this.txtNumeroCuenta.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Numerico;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Codec Pro Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 33);
            this.label2.TabIndex = 33;
            this.label2.Text = "$";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.btnEnviar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.btnEnviar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(176)))));
            this.btnEnviar.BorderRadius = 8;
            this.btnEnviar.BorderSize = 2;
            this.btnEnviar.Enabled = false;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Codec Pro Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(469, 414);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(128, 60);
            this.btnEnviar.TabIndex = 44;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextColor = System.Drawing.Color.White;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Codec Pro Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 33);
            this.label3.TabIndex = 45;
            this.label3.Text = "Tu saldo disponible:";
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
            this.pBoton2.Location = new System.Drawing.Point(949, 10);
            this.pBoton2.Margin = new System.Windows.Forms.Padding(4);
            this.pBoton2.Name = "pBoton2";
            this.pBoton2.Size = new System.Drawing.Size(51, 30);
            this.pBoton2.TabIndex = 54;
            this.pBoton2.Text = "-";
            this.pBoton2.TextColor = System.Drawing.Color.White;
            this.pBoton2.UseVisualStyleBackColor = false;
            this.pBoton2.Click += new System.EventHandler(this.pBoton2_Click_1);
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
            this.pBoton1.Location = new System.Drawing.Point(1003, 10);
            this.pBoton1.Margin = new System.Windows.Forms.Padding(4);
            this.pBoton1.Name = "pBoton1";
            this.pBoton1.Size = new System.Drawing.Size(51, 30);
            this.pBoton1.TabIndex = 53;
            this.pBoton1.Text = "X";
            this.pBoton1.TextColor = System.Drawing.Color.White;
            this.pBoton1.UseVisualStyleBackColor = false;
            this.pBoton1.Click += new System.EventHandler(this.pBoton1_Click);
            // 
            // lblMismaCuenta
            // 
            this.lblMismaCuenta.AutoSize = true;
            this.lblMismaCuenta.Font = new System.Drawing.Font("Codec Pro", 10F);
            this.lblMismaCuenta.ForeColor = System.Drawing.Color.Brown;
            this.lblMismaCuenta.Location = new System.Drawing.Point(384, 276);
            this.lblMismaCuenta.Name = "lblMismaCuenta";
            this.lblMismaCuenta.Size = new System.Drawing.Size(351, 20);
            this.lblMismaCuenta.TabIndex = 55;
            this.lblMismaCuenta.Text = "No puedes enviar dinero a tu misma cuenta";
            this.lblMismaCuenta.Visible = false;
            // 
            // formEnviar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1067, 492);
            this.Controls.Add(this.lblMismaCuenta);
            this.Controls.Add(this.pBoton2);
            this.Controls.Add(this.pBoton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblErrorMonto);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblErrorCuenta);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtNumeroCuenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formEnviar";
            this.Text = "formEnviar";
            this.Load += new System.EventHandler(this.formEnviar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblErrorMonto;
        private pLineaTextBox txtNumeroCuenta;
        private pLineaTextBox txtMonto;
        private System.Windows.Forms.Label lblErrorCuenta;
        private System.Windows.Forms.Label label2;
        private pBoton btnEnviar;
        private System.Windows.Forms.Label label3;
        private pBoton pBoton2;
        private pBoton pBoton1;
        private System.Windows.Forms.Label lblMismaCuenta;
    }
}