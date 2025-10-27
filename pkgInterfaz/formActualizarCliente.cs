using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testForms.pkgBaseDatos;

namespace testForms.pkgInterfaz
{
    public partial class formActualizarCliente : Form
    {

        int id_usuarioActual = 0;
        string clave;
        Datos data = new Datos();
        public formActualizarCliente(int prm_usuarioActual)
        {
            InitializeComponent();
            id_usuarioActual = prm_usuarioActual;

            var infoCliente = data.fnc_obtenerInfoCliente(prm_usuarioActual);

            txtCorreo.placeholder = infoCliente.Value.outPrm_correo;
            txtUsuario.placeholder = infoCliente.Value.outPrm_usuario;
            clave = infoCliente.Value.outPrm_clave;

            txtClaveActual.TextBoxInterno.TextChanged += fnc_validarClave;

            txtClaveNueva.Hide();

            txtClaveActual.esClave = true;
            txtClaveNueva.esClave = true;

            picMostrarClaveNueva.Hide();
            picOcultarClaveNueva.Hide();
        }

        private void fnc_validarClave (object sender, EventArgs e)
        {
            if (txtClaveActual.TextBoxInterno.Text == clave && !string.IsNullOrEmpty(txtClaveActual.TextBoxInterno.Text))
            {
                txtClaveNueva.Show();
                txtClaveNueva.Enabled = true;

                picMostrarClaveNueva.Show();
                picOcultarClaveNueva.Show();
            }
            else
            {
                txtClaveNueva.Hide();
                txtClaveNueva.Enabled = false;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picOcultarClaveActual_Click(object sender, EventArgs e)
        {
            txtClaveActual.esClave = true;

            picOcultarClaveActual.Hide();
            picOcultarClaveActual.Enabled = false;

            picMostrarClaveActual.Show();
            picMostrarClaveActual.Enabled = true;
        }

        private void picMostrarClaveActual_Click(object sender, EventArgs e)
        {
            txtClaveActual.esClave = false;

            picMostrarClaveActual.Hide();
            picMostrarClaveActual.Enabled = false;

            picOcultarClaveActual.Show();
            picOcultarClaveActual.Enabled = true;
        }

        private void picOcultarClaveNueva_Click(object sender, EventArgs e)
        {
            txtClaveNueva.esClave = true;

            picOcultarClaveNueva.Hide();
            picOcultarClaveNueva.Enabled = false;

            picMostrarClaveNueva.Show();
            picMostrarClaveNueva.Enabled = true;
        }

        private void picMostrarClaveNueva_Click(object sender, EventArgs e)
        {
            txtClaveNueva.esClave = false;

            picMostrarClaveNueva.Hide();
            picMostrarClaveNueva.Enabled = false;

            picOcultarClaveNueva.Show();
            picOcultarClaveNueva.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.TextBoxInterno.Text;
            string correo = txtCorreo.TextBoxInterno.Text;
            string clave = txtClaveNueva.TextBoxInterno.Text;
            int resultado = data.fnc_actualizarInfoCliente(id_usuarioActual, correo, usuario, clave);

            if (resultado == 0)
            {
                MessageBox.Show("Los datos ya se encuentran asociados a una cuenta existente",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Se han actualizado correctamente su informacion.",
                                "Actualizacion correcta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void txtClaveNueva_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
