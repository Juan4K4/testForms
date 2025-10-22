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

namespace testForms.pkgInterfaz
{
    public partial class formEnviar : Form
    {
        decimal saldo = 0;
        public formEnviar(int prm_usuarioActual, decimal prm_saldo)
        {
            InitializeComponent();
            lblSaldo.Text = $"Tu saldo disponible: {prm_saldo.ToString("C2")}";

            saldo = prm_saldo;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is placeHolderBox ph)
                {
                    ph.TextChanged += fnc_validarCampo;
                }
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

        }

        private void fnc_validarCampo(object sender, EventArgs e)
        {
            bool campos = false;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is placeHolderBox ph)
                {
                    if (string.IsNullOrEmpty(ph.Text) || ph.Text == "")
                    {
                        campos = false;
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
    }
}
