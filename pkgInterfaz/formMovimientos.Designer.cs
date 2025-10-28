namespace testForms.pkgInterfaz
{
    partial class formMovimientos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblEntrar = new System.Windows.Forms.Label();
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.lblNoMovimientos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.AutoSize = true;
            this.btnVolver.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.btnVolver.ForeColor = System.Drawing.Color.Transparent;
            this.btnVolver.Location = new System.Drawing.Point(11, 11);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(95, 45);
            this.btnVolver.TabIndex = 29;
            this.btnVolver.Text = "Volver al inicio";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblEntrar
            // 
            this.lblEntrar.BackColor = System.Drawing.Color.Transparent;
            this.lblEntrar.Font = new System.Drawing.Font("Codec Pro Bold", 30F);
            this.lblEntrar.ForeColor = System.Drawing.Color.Black;
            this.lblEntrar.Location = new System.Drawing.Point(9, 57);
            this.lblEntrar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEntrar.Name = "lblEntrar";
            this.lblEntrar.Size = new System.Drawing.Size(353, 121);
            this.lblEntrar.TabIndex = 30;
            this.lblEntrar.Text = "Movimientos recientes";
            // 
            // dgvMovimientos
            // 
            this.dgvMovimientos.AllowUserToAddRows = false;
            this.dgvMovimientos.AllowUserToDeleteRows = false;
            this.dgvMovimientos.AllowUserToResizeColumns = false;
            this.dgvMovimientos.AllowUserToResizeRows = false;
            this.dgvMovimientos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovimientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMovimientos.BackgroundColor = System.Drawing.Color.White;
            this.dgvMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMovimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvMovimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Codec Pro", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMovimientos.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Codec Pro", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMovimientos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMovimientos.GridColor = System.Drawing.Color.White;
            this.dgvMovimientos.Location = new System.Drawing.Point(17, 180);
            this.dgvMovimientos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.ReadOnly = true;
            this.dgvMovimientos.RowHeadersWidth = 51;
            this.dgvMovimientos.RowTemplate.Height = 24;
            this.dgvMovimientos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMovimientos.Size = new System.Drawing.Size(1027, 278);
            this.dgvMovimientos.TabIndex = 31;
            // 
            // lblNoMovimientos
            // 
            this.lblNoMovimientos.AutoSize = true;
            this.lblNoMovimientos.Font = new System.Drawing.Font("Codec Pro Bold", 15F);
            this.lblNoMovimientos.Location = new System.Drawing.Point(13, 178);
            this.lblNoMovimientos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoMovimientos.Name = "lblNoMovimientos";
            this.lblNoMovimientos.Size = new System.Drawing.Size(297, 25);
            this.lblNoMovimientos.TabIndex = 51;
            this.lblNoMovimientos.Text = "No hay movimientos recientes";
            // 
            // formMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 479);
            this.Controls.Add(this.lblNoMovimientos);
            this.Controls.Add(this.dgvMovimientos);
            this.Controls.Add(this.lblEntrar);
            this.Controls.Add(this.btnVolver);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formMovimientos";
            this.Text = "fromMovimientos";
            this.Load += new System.EventHandler(this.formMovimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblEntrar;
        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.Label lblNoMovimientos;
    }
}