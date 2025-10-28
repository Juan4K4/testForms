namespace testForms.pkgInterfaz
{
    partial class formSolicitudes
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabExtracto = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.lblEntrar = new System.Windows.Forms.Label();
            this.lblErrorMes = new System.Windows.Forms.Label();
            this.lblErrorAnio = new System.Windows.Forms.Label();
            this.btnGenerarExtracto = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabExtracto.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabExtracto);
            this.tabControl1.Font = new System.Drawing.Font("Codec Pro Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabExtracto
            // 
            this.tabExtracto.Controls.Add(this.btnGenerarExtracto);
            this.tabExtracto.Controls.Add(this.lblErrorAnio);
            this.tabExtracto.Controls.Add(this.lblErrorMes);
            this.tabExtracto.Controls.Add(this.label2);
            this.tabExtracto.Controls.Add(this.label1);
            this.tabExtracto.Controls.Add(this.cmbAnio);
            this.tabExtracto.Controls.Add(this.cmbMes);
            this.tabExtracto.Controls.Add(this.lblEntrar);
            this.tabExtracto.Font = new System.Drawing.Font("Codec Pro Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabExtracto.Location = new System.Drawing.Point(4, 34);
            this.tabExtracto.Name = "tabExtracto";
            this.tabExtracto.Padding = new System.Windows.Forms.Padding(3);
            this.tabExtracto.Size = new System.Drawing.Size(768, 388);
            this.tabExtracto.TabIndex = 0;
            this.tabExtracto.Text = "Extracto de cuenta";
            this.tabExtracto.UseVisualStyleBackColor = true;
            this.tabExtracto.Enter += new System.EventHandler(this.tabExtracto_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Codec Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(63, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Año";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Codec Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(63, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mes";
            // 
            // cmbAnio
            // 
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.Location = new System.Drawing.Point(116, 149);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(134, 33);
            this.cmbAnio.TabIndex = 3;
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiempre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbMes.Location = new System.Drawing.Point(116, 89);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(134, 33);
            this.cmbMes.TabIndex = 2;
            // 
            // lblEntrar
            // 
            this.lblEntrar.BackColor = System.Drawing.Color.Transparent;
            this.lblEntrar.Font = new System.Drawing.Font("Codec Pro Bold", 30F);
            this.lblEntrar.ForeColor = System.Drawing.Color.Black;
            this.lblEntrar.Location = new System.Drawing.Point(2, 3);
            this.lblEntrar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEntrar.Name = "lblEntrar";
            this.lblEntrar.Size = new System.Drawing.Size(574, 119);
            this.lblEntrar.TabIndex = 1;
            this.lblEntrar.Text = "Generar extracto de cuenta";
            // 
            // lblErrorMes
            // 
            this.lblErrorMes.CausesValidation = false;
            this.lblErrorMes.Font = new System.Drawing.Font("Codec Pro", 10F);
            this.lblErrorMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrorMes.Location = new System.Drawing.Point(116, 125);
            this.lblErrorMes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorMes.Name = "lblErrorMes";
            this.lblErrorMes.Size = new System.Drawing.Size(134, 23);
            this.lblErrorMes.TabIndex = 30;
            this.lblErrorMes.Text = "Seleccione un mes";
            this.lblErrorMes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblErrorAnio
            // 
            this.lblErrorAnio.CausesValidation = false;
            this.lblErrorAnio.Font = new System.Drawing.Font("Codec Pro", 10F);
            this.lblErrorAnio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrorAnio.Location = new System.Drawing.Point(116, 185);
            this.lblErrorAnio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorAnio.Name = "lblErrorAnio";
            this.lblErrorAnio.Size = new System.Drawing.Size(134, 23);
            this.lblErrorAnio.TabIndex = 31;
            this.lblErrorAnio.Text = "Seleccione un año";
            this.lblErrorAnio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGenerarExtracto
            // 
            this.btnGenerarExtracto.AutoSize = true;
            this.btnGenerarExtracto.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerarExtracto.Enabled = false;
            this.btnGenerarExtracto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarExtracto.Font = new System.Drawing.Font("Codec Pro", 12F);
            this.btnGenerarExtracto.ForeColor = System.Drawing.Color.Transparent;
            this.btnGenerarExtracto.Location = new System.Drawing.Point(116, 210);
            this.btnGenerarExtracto.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarExtracto.Name = "btnGenerarExtracto";
            this.btnGenerarExtracto.Size = new System.Drawing.Size(285, 50);
            this.btnGenerarExtracto.TabIndex = 32;
            this.btnGenerarExtracto.Text = "Generar extracto";
            this.btnGenerarExtracto.UseVisualStyleBackColor = false;
            this.btnGenerarExtracto.Click += new System.EventHandler(this.btnGenerarExtracto_Click);
            // 
            // formSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "formSolicitudes";
            this.Text = "formSolicitudes";
            this.tabControl1.ResumeLayout(false);
            this.tabExtracto.ResumeLayout(false);
            this.tabExtracto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabExtracto;
        private System.Windows.Forms.Label lblEntrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAnio;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label lblErrorAnio;
        private System.Windows.Forms.Label lblErrorMes;
        private System.Windows.Forms.Button btnGenerarExtracto;
    }
}