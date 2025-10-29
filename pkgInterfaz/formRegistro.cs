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
        DateTime fechaNacimiento;
        Datos data = new Datos();
        static Dictionary<string, int> diccionarioMeses = new Dictionary<string, int>();
        public formRegistro()
        {
            InitializeComponent();
        }

        public formRegistro(formLogin login)
        {
            InitializeComponent();
            frmLogin = login;
            btnRegistrar.BackColor = Color.DimGray;
        }

        private void btnLoginBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formRegistro_Load(object sender, EventArgs e)
        {
            lblDatosObligatorios.Hide();
            lblClaveUsuario.Hide();
            lblFechaIncompleta.Hide();

            DateTime fechaMaxima = DateTime.Today.AddYears(-18);
            DateTime fechaMinima = DateTime.Today.AddYears(-100);
            cmbAnio.Items.Clear();

            for (int anio = fechaMinima.Year; anio <= fechaMaxima.Year; anio++)
            {
                cmbAnio.Items.Add(anio.ToString());
            }

            int aux = 1;
            foreach (string mes in cmbMes.Items)
            {
                diccionarioMeses.Add(mes, aux);
                aux++;
            }

            txtClave.esClave = true;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is pLineaTextBox linea)
                {
                    linea.TextBoxInterno.TextChanged += fnc_validarCampos;
                }

                if (ctrl is ComboBox cmb)
                {
                    cmb.SelectedValueChanged += fnc_validarCampos;
                }
            }
        }
        private void fnc_validarCampos(object sender, EventArgs e)
        {
            bool camposCompletos = true;
            bool fechaCompleta = true;

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
                if (ctrl is ComboBox cmb)
                {
                    if (string.IsNullOrWhiteSpace(cmb.Text))
                    {
                        camposCompletos = false;
                        fechaCompleta = false;
                        break;
                    }
                    else
                    {
                        fechaCompleta = true;
                    }
                }
            }

            bool claveValida = !string.Equals(txtClave.TextBoxInterno.Text, txtUsuario.TextBoxInterno.Text, StringComparison.OrdinalIgnoreCase);

            if (camposCompletos && claveValida && fechaCompleta)
            {
                btnRegistrar.Enabled = true;
                btnRegistrar.BackColor = ColorTranslator.FromHtml("#5C69F5");

                lblDatosObligatorios.Hide();
                lblClaveUsuario.Hide();
                lblFechaIncompleta.Hide();

                int mes = 0;
                diccionarioMeses.TryGetValue(cmbMes.Text, out mes);
                string cadenaFecha = $"{cmbDia.SelectedItem.ToString()}/{mes}/{cmbAnio.SelectedItem.ToString()}";
                fechaNacimiento = Convert.ToDateTime(cadenaFecha);
            }
            else
            {
                btnRegistrar.Enabled = false;
                btnRegistrar.BackColor = Color.DimGray;

                lblDatosObligatorios.Visible = !camposCompletos;
                lblClaveUsuario.Visible = !claveValida;
                lblFechaIncompleta.Visible = !fechaCompleta;
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
                string v_fechaNac = fechaNacimiento.ToString();

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