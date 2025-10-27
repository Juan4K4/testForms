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
using static System.Net.Mime.MediaTypeNames;
using testForms.pkgLogica;
using testForms.pkgInterfaz;
using testForms.pkgBaseDatos;

namespace testForms
{
    public partial class formRegistro : Form
    {
        formLogin frmLogin = new formLogin();
        public formRegistro()
        {
            InitializeComponent();
        }

        public formRegistro(formLogin login)
        {
            InitializeComponent();
            frmLogin = login;
        }

        private void btnLoginBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formRegistro_Load(object sender, EventArgs e)
        {
            lblDatosObligatorios.Hide();
            lblClaveUsuario.Hide();

            DateTime fechaMaxima = DateTime.Today.AddYears(-18);
            DateTime fechaMinima = DateTime.Today.AddYears(-90);
            dtpFechaNac.MaxDate = fechaMaxima;
            dtpFechaNac.MinDate = fechaMinima;

            txtClave.UseSystemPasswordChar = true;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is placeHolderBox txt)
                {
                    txt.TextChanged += fnc_validarCampos;
                }
            }

            txtPrimerNombre.KeyPress += fnc_validarCampoLetra;
            txtPrimerApellido.KeyPress += fnc_validarCampoLetra;

            txtCorreo.KeyPress += fnc_validarCampoEspecial;
            txtClave.KeyPress += fnc_validarCampoEspecial;
            txtUsuario.KeyPress += fnc_validarCampoEspecial;

            txtId.KeyPress += fnc_validarCampoNumerico;
        }
        private void fnc_validarCampos(object sender, EventArgs e)
        {
            bool camposCompletos = true;

            lblDatosObligatorios.Show();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is placeHolderBox ph)
                {
                    if (string.IsNullOrWhiteSpace(ph.Text))
                    {
                        camposCompletos = false;
                        break;
                    }
                }
            }

            bool claveValida = !string.Equals(txtClave.Text, txtUsuario.Text, StringComparison.OrdinalIgnoreCase);

            if (camposCompletos && claveValida)
            {
                btnRegistrar.Enabled = true;
                btnRegistrar.BackColor = Color.Orange;

                lblDatosObligatorios.Hide();
                lblClaveUsuario.Hide();
            }
            else
            {
                btnRegistrar.Enabled = false;
                btnRegistrar.BackColor = Color.DimGray;

                lblDatosObligatorios.Visible = !camposCompletos;
                lblClaveUsuario.Visible = !claveValida;
            }
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string v_nombre =
                    txtPrimerNombre.Text + " " + txtPrimerApellido.Text;
                string v_mail = txtCorreo.Text;
                int v_id = int.Parse(txtId.Text);
                string v_usuario = txtUsuario.Text;
                string v_clave = txtClave.Text;
                string v_fechaNac = dtpFechaNac.Value.Date.ToString("dd/MM/yyyy");

                Datos data = new Datos();
                int resultadoDml = data.fnc_registrarUsuario(v_nombre, v_mail, v_id, v_usuario, v_clave, v_fechaNac);

                switch (resultadoDml)
                {
                    case 1:
                        MessageBox.Show("Registro completado correctamente");
                        break;

                    case -1:
                        MessageBox.Show("Ya existe una cuenta registrada con el ID que ingreso");
                        break;

                    case -2:
                        MessageBox.Show("Ya existe una cuenta registrada con el correo que ingreso");
                        break;

                    case -3:
                        MessageBox.Show("Ya existe una cuenta registrada con el usuario que ingreso");
                        break;
                    default:
                        MessageBox.Show("No se pudo completar el registro");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los campos requeridos contienen datos invalidos",
                                "Error al registrarse",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                MessageBox.Show("Excepcion: " + ex);
            }
        }

        private void picMostrarClave_Click(object sender, EventArgs e)
        {
            txtClave.UseSystemPasswordChar = false;

            picMostrarClave.Hide();
            picMostrarClave.Enabled = false;

            picOcultarClave.Show();
            picOcultarClave.Enabled = true;
        }

        private void picOcultarClave_Click(object sender, EventArgs e)
        {
            txtClave.UseSystemPasswordChar = true;

            picOcultarClave.Hide();
            picOcultarClave.Enabled = false;

            picMostrarClave.Show();
            picMostrarClave.Enabled = true;
        }

        private void fnc_validarCampoLetra(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void fnc_validarCampoEspecial(object sender, KeyPressEventArgs e)
        {
            if (
                !char.IsLetter(e.KeyChar) 
                && !char.IsControl(e.KeyChar) 
                && !char.IsNumber(e.KeyChar) 
                && !e.KeyChar.Equals('@') 
                && !e.KeyChar.Equals('.')
                && !e.KeyChar.Equals('#')
               )
            {
                e.Handled = true;
            }
        }
        private void fnc_validarCampoNumerico(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}