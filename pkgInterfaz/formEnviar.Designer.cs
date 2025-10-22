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
            this.txtMonto = new testForms.pkgInterfaz.placeHolderBox();
            this.txtNumeroCuenta = new testForms.pkgInterfaz.placeHolderBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Codec Pro Bold", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 42);
            this.label1.TabIndex = 24;
            this.label1.Text = "Enviar dinero";
            // 
            // btnEnviar
            // 
            this.btnEnviar.AutoSize = true;
            this.btnEnviar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEnviar.Enabled = false;
            this.btnEnviar.Font = new System.Drawing.Font("Codec Pro", 10F);
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(75, 201);
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
            this.lblSaldo.Font = new System.Drawing.Font("Codec Pro", 10F);
            this.lblSaldo.Location = new System.Drawing.Point(13, 103);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(45, 17);
            this.lblSaldo.TabIndex = 28;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblErrorMonto
            // 
            this.lblErrorMonto.AutoSize = true;
            this.lblErrorMonto.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.lblErrorMonto.ForeColor = System.Drawing.Color.Brown;
            this.lblErrorMonto.Location = new System.Drawing.Point(13, 185);
            this.lblErrorMonto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorMonto.Name = "lblErrorMonto";
            this.lblErrorMonto.Size = new System.Drawing.Size(134, 13);
            this.lblErrorMonto.TabIndex = 29;
            this.lblErrorMonto.Text = "Ingrese un monto valido";
            this.lblErrorMonto.Visible = false;
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtMonto.Location = new System.Drawing.Point(16, 165);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.PlaceHolder = "Monto";
            this.txtMonto.Size = new System.Drawing.Size(200, 17);
            this.txtMonto.TabIndex = 26;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtNumeroCuenta.Location = new System.Drawing.Point(16, 133);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.PlaceHolder = "Numero de cuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(200, 17);
            this.txtNumeroCuenta.TabIndex = 25;
            // 
            // formEnviar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 393);
            this.Controls.Add(this.lblErrorMonto);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtNumeroCuenta);
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
        private placeHolderBox txtNumeroCuenta;
        private placeHolderBox txtMonto;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblErrorMonto;
    }
}