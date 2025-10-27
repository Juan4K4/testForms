using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testForms.pkgBaseDatos;

namespace testForms.pkgInterfaz
{
    public partial class formHomeCliente : Form
    {
        int id_usuarioActual = 0;
        decimal saldo = 0;

        public formHomeCliente(int prm_idUsuarioActual)
        {
            id_usuarioActual = prm_idUsuarioActual;
            InitializeComponent();

            fnc_cargarDatosCuenta(id_usuarioActual);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (formActualizarCliente formAct = new formActualizarCliente(id_usuarioActual))
            {
                formAct.ShowDialog();
            }

            fnc_cargarDatosCuenta(id_usuarioActual);
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (formEnviar formEnv = new formEnviar(id_usuarioActual, saldo))
            {
                formEnv.ShowDialog();
            }

            fnc_cargarDatosCuenta(id_usuarioActual);
            this.Show();
        }

        private void fnc_cargarDatosCuenta (int prm_idUsuarioActual)
        {
            var data = new Datos();
            var infoCuenta = data.fnc_obtenerInfoCuenta(prm_idUsuarioActual);
            lblNombre.Text = $"Bienvenido,  {infoCuenta.Value.outPrm_nombre}";
            lblCuentaNum.Text = $"Numero de cuenta:     {infoCuenta.Value.outPrm_numeroCuenta}";
            saldo = infoCuenta.Value.outPrm_saldoCuenta;
            lblSaldo.Text = $"Disponible:   {saldo.ToString("C2")}";  
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (formMovimientos frmMov = new formMovimientos(id_usuarioActual))
            {
                frmMov.ShowDialog();
            }

            fnc_cargarDatosCuenta(id_usuarioActual);
            this.Show();
        }
    }
}
