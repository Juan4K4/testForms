using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testForms.pkgInterfaz
{
    public partial class formComprobante : Form
    {
        public formComprobante(int prm_destino, int prm_monto, DateTime prm_fecha, int prm_referencia)
        {
            InitializeComponent();
            lblCuentaDestino.Text = $"Cuenta destino: {prm_destino}";
            lblMonto.Text = $"Monto: {prm_monto.ToString("C2")}";
            lblFecha.Text = $"Fecha: {prm_fecha}";
            lblReferencia.Text = $"Referencia: {prm_referencia}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
