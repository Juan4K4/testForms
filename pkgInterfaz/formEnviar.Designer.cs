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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblErrorMonto = new System.Windows.Forms.Label();
            this.lblErrorCuenta = new System.Windows.Forms.Label();
            this.txtMonto = new testForms.pkgInterfaz.pLineaTextBox();
            this.txtNumeroCuenta = new testForms.pkgInterfaz.pLineaTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Codec Pro Bold", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 49);
            this.label1.TabIndex = 24;
            this.label1.Text = "Enviar dinero";
            // 
            // btnEnviar
            // 
            this.btnEnviar.AutoSize = true;
            this.btnEnviar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEnviar.Enabled = false;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Codec Pro", 10F);
            this.btnEnviar.ForeColor = System.Drawing.Color.Transparent;
            this.btnEnviar.Location = new System.Drawing.Point(92, 306);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(83, 40);
            this.btnEnviar.TabIndex = 27;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Visible = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Codec Pro", 15F);
            this.lblSaldo.Location = new System.Drawing.Point(8, 109);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(65, 24);
            this.lblSaldo.TabIndex = 28;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblErrorMonto
            // 
            this.lblErrorMonto.AutoSize = true;
            this.lblErrorMonto.Font = new System.Drawing.Font("Codec Pro", 10F);
            this.lblErrorMonto.ForeColor = System.Drawing.Color.Brown;
            this.lblErrorMonto.Location = new System.Drawing.Point(11, 258);
            this.lblErrorMonto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorMonto.Name = "lblErrorMonto";
            this.lblErrorMonto.Size = new System.Drawing.Size(167, 17);
            this.lblErrorMonto.TabIndex = 29;
            this.lblErrorMonto.Text = "Ingrese un monto valido";
            this.lblErrorMonto.Visible = false;
            // 
            // lblErrorCuenta
            // 
            this.lblErrorCuenta.AutoSize = true;
            this.lblErrorCuenta.Font = new System.Drawing.Font("Codec Pro", 10F);
            this.lblErrorCuenta.ForeColor = System.Drawing.Color.Brown;
            this.lblErrorCuenta.Location = new System.Drawing.Point(11, 192);
            this.lblErrorCuenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorCuenta.Name = "lblErrorCuenta";
            this.lblErrorCuenta.Size = new System.Drawing.Size(245, 17);
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
            this.txtMonto.Location = new System.Drawing.Point(8, 211);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtMonto.placeholder = "Cantidad a enviar";
            this.txtMonto.Size = new System.Drawing.Size(250, 44);
            this.txtMonto.TabIndex = 31;
            this.txtMonto.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Numerico;
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtNumeroCuenta.esClave = false;
            this.txtNumeroCuenta.label = "Cuenta destino";
            this.txtNumeroCuenta.limiteCaracteres = 6;
            this.txtNumeroCuenta.Location = new System.Drawing.Point(8, 145);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtNumeroCuenta.placeholder = "Numero de cuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(250, 44);
            this.txtNumeroCuenta.TabIndex = 30;
            this.txtNumeroCuenta.Tipo = testForms.pkgInterfaz.pLineaTextBox.TipoEntrada.Numerico;
            // 
            // formEnviar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 407);
            this.Controls.Add(this.lblErrorCuenta);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtNumeroCuenta);
            this.Controls.Add(this.lblErrorMonto);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formEnviar";
            this.Text = "formEnviar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblErrorMonto;
        private pLineaTextBox txtNumeroCuenta;
        private pLineaTextBox txtMonto;
        private System.Windows.Forms.Label lblErrorCuenta;
    }
}