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
using testForms.pkgBaseDatos;
using testForms.pkgInterfaz;
using testForms.pkgLogica;
using static System.Net.Mime.MediaTypeNames;

namespace testForms
{
    public partial class formLogin : Form
    {
        Datos data = new Datos();
        public formLogin()
        {
            InitializeComponent();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            lblErrorClave.Hide();
            lblErrorUsuario.Hide();
            txtClave.esClave = true;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is placeHolderBox txt)
                {
                    txt.TextChanged += fnc_validarCampos;
                }
            }

            btnIniciarSesion.Click += fnc_validarCampos;
        }
        private void fnc_validarCampos(object sender, EventArgs e)
        {
            if (txtUsuario.TextBoxInterno.Text == "")
            {
                lblErrorUsuario.Show();
            }
            else
            {
                lblErrorUsuario.Hide();
            }

            if (txtClave.TextBoxInterno.Text == "")
            {
                lblErrorClave.Show();
            }
            else
            {
                lblErrorClave.Hide();
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (formRegistro frmReg = new formRegistro(this))
            {
                frmReg.ShowDialog();
            }

            this.Show();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.TextBoxInterno.Text;
            string clave = txtClave.TextBoxInterno.Text;
            long idUsuario = 0;

            Usuario u = new Usuario();
            idUsuario = u.fnc_loginUsuario(usuario, clave);

            if (idUsuario > 0)
            {
                if(u.fnc_verificarAdmin(idUsuario) == "admin")
                {
                    this.Hide();
                    using (var frmHomeAdmin = new formHomeAdmin())
                    {
                        frmHomeAdmin.ShowDialog();
                    }
                    this.Show();
                }
                else
                {
                    this.Hide();
                    using (var frmHome = new formHomeCliente(idUsuario))
                    {
                        frmHome.ShowDialog();
                    }
                    this.Show();
                }
                     
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.",
                        "Error de autenticación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }

        private void picMostrarClave_Click(object sender, EventArgs e)
        {
            txtClave.esClave = false;

            picMostrarClave.Hide();
            picMostrarClave.Enabled = false;

            picOcultarClave.Show();
            picOcultarClave.Enabled = true;
        }

        private void picOcultarClave_Click(object sender, EventArgs e)
        {
            txtClave.esClave = true;

            picOcultarClave.Hide();
            picOcultarClave.Enabled = false;

            picMostrarClave.Show();
            picMostrarClave.Enabled = true;
        }
    }
}
