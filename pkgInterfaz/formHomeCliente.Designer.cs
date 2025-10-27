namespace testForms.pkgInterfaz
{
    partial class formHomeCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHomeCliente));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCuentaNum = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnMovimientos = new System.Windows.Forms.Button();
            this.btnSolicitudes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picFotoCliente = new System.Windows.Forms.PictureBox();
            this.pDegradado1 = new testForms.pkgInterfaz.pDegradado();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Codec Pro Bold", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(12, 231);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(75, 21);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "nombre";
            // 
            // lblCuentaNum
            // 
            this.lblCuentaNum.AutoSize = true;
            this.lblCuentaNum.BackColor = System.Drawing.Color.Transparent;
            this.lblCuentaNum.Font = new System.Drawing.Font("Codec Pro Bold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCuentaNum.ForeColor = System.Drawing.Color.Black;
            this.lblCuentaNum.Location = new System.Drawing.Point(12, 254);
            this.lblCuentaNum.Name = "lblCuentaNum";
            this.lblCuentaNum.Size = new System.Drawing.Size(71, 21);
            this.lblCuentaNum.TabIndex = 4;
            this.lblCuentaNum.Text = "Cuenta";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldo.Font = new System.Drawing.Font("Codec Pro Bold", 10F, System.Drawing.FontStyle.Bold);
            this.lblSaldo.ForeColor = System.Drawing.Color.Black;
            this.lblSaldo.Location = new System.Drawing.Point(12, 274);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(97, 21);
            this.lblSaldo.TabIndex = 5;
            this.lblSaldo.Text = "Disponible";
            // 
            // btnEnviar
            // 
            this.btnEnviar.AutoSize = true;
            this.btnEnviar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEnviar.Font = new System.Drawing.Font("Codec Pro", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(12, 318);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(117, 55);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar Dinero";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMovimientos
            // 
            this.btnMovimientos.AutoSize = true;
            this.btnMovimientos.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMovimientos.Font = new System.Drawing.Font("Codec Pro", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimientos.ForeColor = System.Drawing.Color.White;
            this.btnMovimientos.Location = new System.Drawing.Point(135, 318);
            this.btnMovimientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMovimientos.Name = "btnMovimientos";
            this.btnMovimientos.Size = new System.Drawing.Size(139, 55);
            this.btnMovimientos.TabIndex = 7;
            this.btnMovimientos.Text = "Ver movimientos";
            this.btnMovimientos.UseVisualStyleBackColor = false;
            this.btnMovimientos.Click += new System.EventHandler(this.btnMovimientos_Click);
            // 
            // btnSolicitudes
            // 
            this.btnSolicitudes.AutoSize = true;
            this.btnSolicitudes.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSolicitudes.Font = new System.Drawing.Font("Codec Pro", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitudes.ForeColor = System.Drawing.Color.White;
            this.btnSolicitudes.Location = new System.Drawing.Point(279, 318);
            this.btnSolicitudes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSolicitudes.Name = "btnSolicitudes";
            this.btnSolicitudes.Size = new System.Drawing.Size(139, 55);
            this.btnSolicitudes.TabIndex = 8;
            this.btnSolicitudes.Text = "Solicitudes";
            this.btnSolicitudes.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(487, 102);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // picFotoCliente
            // 
            this.picFotoCliente.Image = ((System.Drawing.Image)(resources.GetObject("picFotoCliente.Image")));
            this.picFotoCliente.Location = new System.Drawing.Point(12, 102);
            this.picFotoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picFotoCliente.Name = "picFotoCliente";
            this.picFotoCliente.Size = new System.Drawing.Size(113, 128);
            this.picFotoCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFotoCliente.TabIndex = 20;
            this.picFotoCliente.TabStop = false;
            this.picFotoCliente.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pDegradado1
            // 
            this.pDegradado1.Angle = 45F;
            this.pDegradado1.HexColor1 = "#00000";
            this.pDegradado1.HexColor2 = "#5C69F5";
            this.pDegradado1.Location = new System.Drawing.Point(-77, -7);
            this.pDegradado1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pDegradado1.Name = "pDegradado1";
            this.pDegradado1.Size = new System.Drawing.Size(803, 94);
            this.pDegradado1.TabIndex = 21;
            // 
            // formHomeCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(647, 391);
            this.Controls.Add(this.pDegradado1);
            this.Controls.Add(this.picFotoCliente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSolicitudes);
            this.Controls.Add(this.btnMovimientos);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblCuentaNum);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formHomeCliente";
            this.Text = "formHome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCuentaNum;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnMovimientos;
        private System.Windows.Forms.Button btnSolicitudes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picFotoCliente;
        private pDegradado pDegradado1;
    }
}