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
    public partial class formHome : Form
    {

        public formHome(int prm_idUsuarioActual)
        {
            InitializeComponent();
            var Datos = new Datos();
            var infoCuenta = Datos.fnc_obtenerInfoCuenta(prm_idUsuarioActual);

            lblNombre.Text = $"Bienvenido,  {infoCuenta.outPrm_nombre}";
            lblCuentaNum.Text = $"Numero de cuenta:     {infoCuenta.outPrm_numeroCuenta}";
            decimal saldo = infoCuenta.outPrm_saldoCuenta;
            lblSaldo.Text = $"Disponible:   {saldo.ToString("C2")}";
        }
    }
}
