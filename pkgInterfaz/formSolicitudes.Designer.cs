﻿namespace testForms.pkgInterfaz
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
            this.btnGenerarExtracto = new System.Windows.Forms.Button();
            this.lblErrorAnio = new System.Windows.Forms.Label();
            this.lblErrorMes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.lblEntrar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVolver = new testForms.pkgInterfaz.pBoton();
            this.pDegradado3 = new testForms.pkgInterfaz.pDegradado();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabExtracto.SuspendLayout();
            this.pDegradado3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabExtracto);
            this.tabControl1.Font = new System.Drawing.Font("Codec Pro Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 120);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 472);
            this.tabControl1.TabIndex = 0;
            // 
            // tabExtracto
            // 
            this.tabExtracto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tabExtracto.Controls.Add(this.label3);
            this.tabExtracto.Controls.Add(this.btnGenerarExtracto);
            this.tabExtracto.Controls.Add(this.lblErrorAnio);
            this.tabExtracto.Controls.Add(this.lblErrorMes);
            this.tabExtracto.Controls.Add(this.label1);
            this.tabExtracto.Controls.Add(this.cmbAnio);
            this.tabExtracto.Controls.Add(this.cmbMes);
            this.tabExtracto.Controls.Add(this.lblEntrar);
            this.tabExtracto.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabExtracto.Font = new System.Drawing.Font("Codec Pro Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabExtracto.ForeColor = System.Drawing.Color.Black;
            this.tabExtracto.Location = new System.Drawing.Point(4, 34);
            this.tabExtracto.Name = "tabExtracto";
            this.tabExtracto.Padding = new System.Windows.Forms.Padding(3);
            this.tabExtracto.Size = new System.Drawing.Size(768, 434);
            this.tabExtracto.TabIndex = 0;
            this.tabExtracto.Text = "Extracto de cuenta";
            this.tabExtracto.Enter += new System.EventHandler(this.tabExtracto_Enter);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Codec Pro Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(56, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 26);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Codec Pro Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(56, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 26);
            this.label3.TabIndex = 33;
            this.label3.Text = "Año";
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.btnVolver.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(105)))), ((int)(((byte)(245)))));
            this.btnVolver.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(176)))));
            this.btnVolver.BorderRadius = 8;
            this.btnVolver.BorderSize = 2;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Codec Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(664, 8);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(128, 32);
            this.btnVolver.TabIndex = 53;
            this.btnVolver.Text = "Volver al inicio";
            this.btnVolver.TextColor = System.Drawing.Color.White;
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // pDegradado3
            // 
            this.pDegradado3.Angle = 90F;
            this.pDegradado3.BackColor = System.Drawing.Color.Transparent;
            this.pDegradado3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pDegradado3.Controls.Add(this.label4);
            this.pDegradado3.Controls.Add(this.btnVolver);
            this.pDegradado3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pDegradado3.HexColor1 = "#4450c9";
            this.pDegradado3.HexColor2 = "#5C69F5";
            this.pDegradado3.Location = new System.Drawing.Point(0, 0);
            this.pDegradado3.Margin = new System.Windows.Forms.Padding(0);
            this.pDegradado3.Name = "pDegradado3";
            this.pDegradado3.Size = new System.Drawing.Size(800, 116);
            this.pDegradado3.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Codec Pro Bold", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 65);
            this.label4.TabIndex = 54;
            this.label4.Text = "Solicitudes";
            // 
            // formSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pDegradado3);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formSolicitudes";
            this.Text = "formSolicitudes";
            this.tabControl1.ResumeLayout(false);
            this.tabExtracto.ResumeLayout(false);
            this.tabExtracto.PerformLayout();
            this.pDegradado3.ResumeLayout(false);
            this.pDegradado3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabExtracto;
        private System.Windows.Forms.Label lblEntrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAnio;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label lblErrorAnio;
        private System.Windows.Forms.Label lblErrorMes;
        private System.Windows.Forms.Button btnGenerarExtracto;
        private System.Windows.Forms.Label label3;
        private pBoton btnVolver;
        private pDegradado pDegradado3;
        private System.Windows.Forms.Label label4;
    }
}