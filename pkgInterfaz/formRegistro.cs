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

            txtClave.esClave = true;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is pLineaTextBox linea)
                {
                    linea.TextBoxInterno.TextChanged += fnc_validarCampos;
                }
            }
        }
        private void fnc_validarCampos(object sender, EventArgs e)
        {
            bool camposCompletos = true;

            lblDatosObligatorios.Show();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is pLineaTextBox linea)
                {
                    if (string.IsNullOrWhiteSpace(linea.TextBoxInterno.Text))
                    {
                        camposCompletos = false;
                        break;
                    }
                }
            }

            bool claveValida = !string.Equals(txtClave.TextBoxInterno.Text, txtUsuario.TextBoxInterno.Text, StringComparison.OrdinalIgnoreCase);

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
                    txtPrimerNombre.TextBoxInterno.Text + " " + txtPrimerApellido.TextBoxInterno.Text;
                string v_mail = txtCorreo.TextBoxInterno.Text;
                long v_id = long.Parse(txtId.TextBoxInterno.Text);
                string v_usuario = txtUsuario.TextBoxInterno.Text;
                string v_clave = txtClave.TextBoxInterno.Text;
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