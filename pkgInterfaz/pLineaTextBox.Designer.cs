using System;
using System.Windows.Forms;

namespace testForms.pkgInterfaz
{
    partial class pLineaTextBox
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.placeHolderBox1 = new testForms.pkgInterfaz.placeHolderBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.placeHolderBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 43);
            this.panel1.TabIndex = 0;
            // 
            // placeHolderBox1
            // 
            this.placeHolderBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.placeHolderBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.placeHolderBox1.Font = new System.Drawing.Font("Codec Pro", 15F);
            this.placeHolderBox1.ForeColor = System.Drawing.Color.Black;
            this.placeHolderBox1.Location = new System.Drawing.Point(0, 18);
            this.placeHolderBox1.MinimumSize = new System.Drawing.Size(250, 10);
            this.placeHolderBox1.Name = "placeHolderBox1";
            this.placeHolderBox1.PlaceHolder = null;
            this.placeHolderBox1.Size = new System.Drawing.Size(250, 25);
            this.placeHolderBox1.TabIndex = 2;
            this.placeHolderBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.placeHolderBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Codec Pro Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // pLineaTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.panel1);
            this.Name = "pLineaTextBox";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.Size = new System.Drawing.Size(250, 44);
            this.Load += new System.EventHandler(this.pLineaTextBox_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.pLineaTextBox_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private placeHolderBox placeHolderBox1;
    }
}
