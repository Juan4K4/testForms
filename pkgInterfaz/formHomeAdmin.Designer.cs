namespace testForms.pkgInterfaz
{
    partial class formHomeAdmin
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
            this.tbcAdmin = new System.Windows.Forms.TabControl();
            this.tabActualizar = new System.Windows.Forms.TabPage();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.placeHolderBox1 = new testForms.pkgInterfaz.placeHolderBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSolicitudes = new System.Windows.Forms.TabPage();
            this.pDegradado1 = new testForms.pkgInterfaz.pDegradado();
            this.tbcAdmin.SuspendLayout();
            this.tabActualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcAdmin
            // 
            this.tbcAdmin.Controls.Add(this.tabActualizar);
            this.tbcAdmin.Controls.Add(this.tabSolicitudes);
            this.tbcAdmin.Font = new System.Drawing.Font("Codec Pro Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcAdmin.Location = new System.Drawing.Point(12, 99);
            this.tbcAdmin.Name = "tbcAdmin";
            this.tbcAdmin.SelectedIndex = 0;
            this.tbcAdmin.Size = new System.Drawing.Size(1174, 611);
            this.tbcAdmin.TabIndex = 23;
            this.tbcAdmin.Enter += new System.EventHandler(this.tbcAdmin_Enter);
            // 
            // tabActualizar
            // 
            this.tabActualizar.Controls.Add(this.dgvUsuarios);
            this.tabActualizar.Controls.Add(this.btnConsultar);
            this.tabActualizar.Controls.Add(this.placeHolderBox1);
            this.tabActualizar.Controls.Add(this.label1);
            this.tabActualizar.Font = new System.Drawing.Font("Codec Pro Bold", 10F);
            this.tabActualizar.Location = new System.Drawing.Point(4, 30);
            this.tabActualizar.Name = "tabActualizar";
            this.tabActualizar.Padding = new System.Windows.Forms.Padding(3);
            this.tabActualizar.Size = new System.Drawing.Size(1166, 577);
            this.tabActualizar.TabIndex = 0;
            this.tabActualizar.Text = "Actualizacion de datos";
            this.tabActualizar.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(14, 123);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(1133, 436);
            this.dgvUsuarios.TabIndex = 3;
            // 
            // btnConsultar
            // 
            this.btnConsultar.AutoSize = true;
            this.btnConsultar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(277, 73);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(106, 44);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // placeHolderBox1
            // 
            this.placeHolderBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.placeHolderBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.placeHolderBox1.Font = new System.Drawing.Font("Codec Pro", 15F);
            this.placeHolderBox1.Location = new System.Drawing.Point(14, 81);
            this.placeHolderBox1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.placeHolderBox1.Name = "placeHolderBox1";
            this.placeHolderBox1.PlaceHolder = "ID del cliente";
            this.placeHolderBox1.Size = new System.Drawing.Size(248, 29);
            this.placeHolderBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Codec Pro Bold", 30F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actualizacion de datos";
            // 
            // tabSolicitudes
            // 
            this.tabSolicitudes.Location = new System.Drawing.Point(4, 30);
            this.tabSolicitudes.Name = "tabSolicitudes";
            this.tabSolicitudes.Padding = new System.Windows.Forms.Padding(3);
            this.tabSolicitudes.Size = new System.Drawing.Size(1166, 577);
            this.tabSolicitudes.TabIndex = 1;
            this.tabSolicitudes.Text = "Consulta de solicitudes";
            this.tabSolicitudes.UseVisualStyleBackColor = true;
            // 
            // pDegradado1
            // 
            this.pDegradado1.Angle = 45F;
            this.pDegradado1.HexColor1 = "#00000";
            this.pDegradado1.HexColor2 = "#ffb700";
            this.pDegradado1.Location = new System.Drawing.Point(1, -5);
            this.pDegradado1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pDegradado1.Name = "pDegradado1";
            this.pDegradado1.Size = new System.Drawing.Size(1200, 99);
            this.pDegradado1.TabIndex = 22;
            // 
            // formHomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 722);
            this.Controls.Add(this.tbcAdmin);
            this.Controls.Add(this.pDegradado1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formHomeAdmin";
            this.Text = "formHomeAdmin";
            this.tbcAdmin.ResumeLayout(false);
            this.tabActualizar.ResumeLayout(false);
            this.tabActualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private pDegradado pDegradado1;
        private System.Windows.Forms.TabControl tbcAdmin;
        private System.Windows.Forms.TabPage tabActualizar;
        private System.Windows.Forms.TabPage tabSolicitudes;
        private placeHolderBox placeHolderBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
    }
}