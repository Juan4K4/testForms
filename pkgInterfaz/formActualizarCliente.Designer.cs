namespace testForms.pkgInterfaz
{
    partial class formActualizarCliente
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
            this.txtEmail = new testForms.pkgInterfaz.phTextBox();
            this.txtClaveAnterior = new testForms.pkgInterfaz.phTextBox();
            this.txtClaveNueva = new testForms.pkgInterfaz.phTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Codec Pro Bold", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 52);
            this.label1.TabIndex = 23;
            this.label1.Text = "Actualizacion de datos";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(288, 149);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceHolder = "E-mail";
            this.txtEmail.Size = new System.Drawing.Size(250, 19);
            this.txtEmail.TabIndex = 24;
            this.txtEmail.Text = "E-mail";
            // 
            // txtClaveAnterior
            // 
            this.txtClaveAnterior.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtClaveAnterior.ForeColor = System.Drawing.Color.DimGray;
            this.txtClaveAnterior.Location = new System.Drawing.Point(288, 174);
            this.txtClaveAnterior.Name = "txtClaveAnterior";
            this.txtClaveAnterior.PlaceHolder = "Clave actual";
            this.txtClaveAnterior.Size = new System.Drawing.Size(250, 19);
            this.txtClaveAnterior.TabIndex = 25;
            this.txtClaveAnterior.Text = "Clave actual";
            // 
            // txtClaveNueva
            // 
            this.txtClaveNueva.Font = new System.Drawing.Font("Codec Pro", 8F);
            this.txtClaveNueva.ForeColor = System.Drawing.Color.DimGray;
            this.txtClaveNueva.Location = new System.Drawing.Point(288, 199);
            this.txtClaveNueva.Name = "txtClaveNueva";
            this.txtClaveNueva.PlaceHolder = "Clave nueva";
            this.txtClaveNueva.Size = new System.Drawing.Size(250, 19);
            this.txtClaveNueva.TabIndex = 26;
            this.txtClaveNueva.Text = "Clave nueva";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.Font = new System.Drawing.Font("Codec Pro", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(355, 265);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 55);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            this.btnVolver.AutoSize = true;
            this.btnVolver.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVolver.Font = new System.Drawing.Font("Codec Pro", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(668, 9);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(124, 55);
            this.btnVolver.TabIndex = 28;
            this.btnVolver.Text = " <-- Volver al menu";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // formActualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtClaveNueva);
            this.Controls.Add(this.txtClaveAnterior);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formActualizarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private phTextBox txtEmail;
        private phTextBox txtClaveAnterior;
        private phTextBox txtClaveNueva;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVolver;
    }
}