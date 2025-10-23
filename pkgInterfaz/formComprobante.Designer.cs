namespace testForms.pkgInterfaz
{
    partial class formComprobante
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
            this.lblTransferencia = new System.Windows.Forms.Label();
            this.lblCuentaDestino = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pDegradado1 = new testForms.pkgInterfaz.pDegradado();
            this.SuspendLayout();
            // 
            // lblTransferencia
            // 
            this.lblTransferencia.AutoSize = true;
            this.lblTransferencia.Font = new System.Drawing.Font("Codec Pro Bold", 30F);
            this.lblTransferencia.Location = new System.Drawing.Point(51, 81);
            this.lblTransferencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTransferencia.Name = "lblTransferencia";
            this.lblTransferencia.Size = new System.Drawing.Size(433, 49);
            this.lblTransferencia.TabIndex = 1;
            this.lblTransferencia.Text = "Transferencia exitosa";
            // 
            // lblCuentaDestino
            // 
            this.lblCuentaDestino.AutoSize = true;
            this.lblCuentaDestino.BackColor = System.Drawing.Color.Transparent;
            this.lblCuentaDestino.Font = new System.Drawing.Font("Codec Pro", 10F);
            this.lblCuentaDestino.ForeColor = System.Drawing.Color.Black;
            this.lblCuentaDestino.Location = new System.Drawing.Point(69, 159);
            this.lblCuentaDestino.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCuentaDestino.Name = "lblCuentaDestino";
            this.lblCuentaDestino.Size = new System.Drawing.Size(109, 17);
            this.lblCuentaDestino.TabIndex = 34;
            this.lblCuentaDestino.Text = "CuentaDestino";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.BackColor = System.Drawing.Color.Transparent;
            this.lblMonto.Font = new System.Drawing.Font("Codec Pro", 10F);
            this.lblMonto.ForeColor = System.Drawing.Color.Black;
            this.lblMonto.Location = new System.Drawing.Point(69, 205);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(51, 17);
            this.lblMonto.TabIndex = 35;
            this.lblMonto.Text = "Monto";
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.BackColor = System.Drawing.Color.Transparent;
            this.lblReferencia.Font = new System.Drawing.Font("Codec Pro", 10F);
            this.lblReferencia.ForeColor = System.Drawing.Color.Black;
            this.lblReferencia.Location = new System.Drawing.Point(69, 297);
            this.lblReferencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(80, 17);
            this.lblReferencia.TabIndex = 36;
            this.lblReferencia.Text = "Referencia";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Codec Pro", 10F);
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(69, 251);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(49, 17);
            this.lblFecha.TabIndex = 37;
            this.lblFecha.Text = "Fecha";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Codec Pro Bold", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(201, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 43);
            this.button1.TabIndex = 38;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pDegradado1
            // 
            this.pDegradado1.Angle = 45F;
            this.pDegradado1.HexColor1 = "#00000";
            this.pDegradado1.HexColor2 = "#5C69F5";
            this.pDegradado1.Location = new System.Drawing.Point(-39, -2);
            this.pDegradado1.Margin = new System.Windows.Forms.Padding(2);
            this.pDegradado1.Name = "pDegradado1";
            this.pDegradado1.Size = new System.Drawing.Size(602, 81);
            this.pDegradado1.TabIndex = 39;
            // 
            // formComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.pDegradado1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblReferencia);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblCuentaDestino);
            this.Controls.Add(this.lblTransferencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formComprobante";
            this.Text = "formComprobante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTransferencia;
        private System.Windows.Forms.Label lblCuentaDestino;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button button1;
        private pDegradado pDegradado1;
    }
}