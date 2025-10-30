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
            FormHelper.HabilitarMovimiento(this, pDegradado1);
            lblCuentaDestino.Text = prm_destino.ToString();
            lblMonto.Text = prm_monto.ToString("C2");
            lblFecha.Text = prm_fecha.ToString("G");
            lblReferencia.Text = prm_referencia.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
