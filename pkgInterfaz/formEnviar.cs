using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using testForms.pkgBaseDatos;

namespace testForms.pkgInterfaz
{
    public partial class formEnviar : Form
    {
        decimal saldo = 0;
        int idUsuario = 0;
        public formEnviar(int prm_usuarioActual, decimal prm_saldo)
        {
            InitializeComponent();
            lblSaldo.Text = $"Tu saldo disponible: {prm_saldo.ToString("C2")}";

            saldo = prm_saldo;
            idUsuario = prm_usuarioActual;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is placeHolderBox ph)
                {
                    ph.TextChanged += fnc_validarCampos;
                }
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Datos data = new Datos();

            var transferencia = data.fnc_transferencia(idUsuario, int.Parse(txtNumeroCuenta.Text), int.Parse(txtMonto.Text));

            if (transferencia == null)
            {
                MessageBox.Show("No se ha encontrado la cuenta destino, por favor revise los datos ingresados",
                    "Error al enviar dinero",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                DateTime fecha = Convert.ToDateTime(transferencia.Value.prmOut_fecha.ToString());
                int referencia = int.Parse(transferencia.Value.prmOut_referencia.ToString());

                formComprobante comprobante = new formComprobante(
                    int.Parse(txtNumeroCuenta.Text),
                    int.Parse(txtMonto.Text),
                    fecha,
                    referencia
                    );

                comprobante.ShowDialog();
                this.Close();
            }
        }

        private void fnc_validarCampos(object sender, EventArgs e)
        {
            bool campos = false;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is placeHolderBox ph)
                {
                    if (string.IsNullOrEmpty(ph.Text) || ph.Text == "")
                    {
                        campos = false; 
                        break;
                    }
                    else if (Convert.ToDecimal(txtMonto.Text) <= saldo)
                    {
                        campos = true;
                    }
                }
            }

            if (campos)
            {
                btnEnviar.Show();
                btnEnviar.Enabled = true;
                lblErrorMonto.Hide();
            }
            else
            {
                btnEnviar.Hide();
                btnEnviar.Enabled = false;
                lblErrorMonto.Show();
            }   
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumeroCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
