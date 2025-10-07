using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testForms.pkgInterfaz;
using testForms.pkgLogica;

namespace testForms
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            formRegistro frmReg = new formRegistro(this);
            this.Hide();
            frmReg.Show();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;
            int resultado = 0;

            Usuario u = new Usuario();
            resultado = u.fnc_loginUsuario(usuario, clave);

            if (resultado != 0)
            {
                formHome frmHome = new formHome(resultado);
                this.Hide();
                frmHome.Show();
            }
            else if (resultado == 0)
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
