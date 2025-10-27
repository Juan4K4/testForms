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
            this.SuspendLayout();
            // 
            // lblTransferencia
            // 
            this.lblTransferencia.AutoSize = true;
            this.lblTransferencia.Font = new System.Drawing.Font("Codec Pro Bold", 30F);
            this.lblTransferencia.Location = new System.Drawing.Point(34, 32);
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
            this.lblCuentaDestino.Font = new System.Drawing.Font("Codec Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentaDestino.ForeColor = System.Drawing.Color.Black;
            this.lblCuentaDestino.Location = new System.Drawing.Point(50, 113);
            this.lblCuentaDestino.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCuentaDestino.Name = "lblCuentaDestino";
            this.lblCuentaDestino.Size = new System.Drawing.Size(153, 24);
            this.lblCuentaDestino.TabIndex = 34;
            this.lblCuentaDestino.Text = "CuentaDestino";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.BackColor = System.Drawing.Color.Transparent;
            this.lblMonto.Font = new System.Drawing.Font("Codec Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.Black;
            this.lblMonto.Location = new System.Drawing.Point(50, 159);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(71, 24);
            this.lblMonto.TabIndex = 35;
            this.lblMonto.Text = "Monto";
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.BackColor = System.Drawing.Color.Transparent;
            this.lblReferencia.Font = new System.Drawing.Font("Codec Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencia.ForeColor = System.Drawing.Color.Black;
            this.lblReferencia.Location = new System.Drawing.Point(50, 251);
            this.lblReferencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(112, 24);
            this.lblReferencia.TabIndex = 36;
            this.lblReferencia.Text = "Referencia";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Codec Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(50, 205);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(67, 24);
            this.lblFecha.TabIndex = 37;
            this.lblFecha.Text = "Fecha";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Codec Pro Bold", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(184, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 43);
            this.button1.TabIndex = 38;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 387);
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
    }
}