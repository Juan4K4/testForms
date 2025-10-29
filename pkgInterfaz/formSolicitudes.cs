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
using testForms.pkgLogica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace testForms.pkgInterfaz
{
    public partial class formSolicitudes : Form
    {
        long id_usuarioActual = 0;
        Usuario user = new Usuario();
        Datos data = new Datos();
        static Dictionary<string, int> diccionarioMeses = new Dictionary<string, int>();
        DateTime fechaCreacion;
        DateTime fechaActual;

        public formSolicitudes(long prm_idUsuarioActual)
        {
            InitializeComponent();
            id_usuarioActual = prm_idUsuarioActual;

            int aux = 1;
            foreach (string mes in cmbMes.Items)
            {
                diccionarioMeses.Add(mes, aux);
                aux++;
            }

            lblErrorAnio.Hide();
            lblErrorMes.Hide();

            btnGenerarExtracto.BackColor = Color.DimGray;

            cmbMes.SelectionChangeCommitted += validarSeleccion;
            cmbAnio.SelectionChangeCommitted += validarSeleccion;
        }

        private void validarSeleccion(object sender, EventArgs e)
        {
            bool campoMes = false; 
            bool campoAnio = false;

            campoMes = cmbMes.SelectedItem != null;
            campoAnio = cmbAnio.SelectedItem != null;

            if (campoAnio && campoMes)
            {
                lblErrorMes.Hide();
                lblErrorAnio.Hide();

                btnGenerarExtracto.Enabled = true;
                btnGenerarExtracto.BackColor = Color.RoyalBlue;
            }
            else
            {
                lblErrorAnio.Visible = !campoAnio;
                lblErrorMes.Visible = !campoMes;
            }
        }

        private void tabExtracto_Enter(object sender, EventArgs e)
        {
            fechaCreacion = user.fnc_verificarFechaCreacion(id_usuarioActual);
            fechaActual = DateTime.Now;

            cmbAnio.Items.Clear();

            int anioInicio = fechaCreacion.Year;
            int anioFin = fechaActual.Year;

            for (int anio = anioFin; anio >= anioInicio; anio--)
            {
                cmbAnio.Items.Add(anio.ToString());
            }
        }

        private void btnGenerarExtracto_Click(object sender, EventArgs e)
        {
            int anio = int.Parse(cmbAnio.SelectedItem.ToString());
            string mesTexto = cmbMes.Text;
            int mesNumero = 0;

            diccionarioMeses.TryGetValue(mesTexto, out mesNumero);

            DateTime periodo = new DateTime(anio, mesNumero, 1);
            if (periodo.Month >= DateTime.Now.Month && periodo.Year >= DateTime.Now.Year
                || periodo <= fechaCreacion)
            {
                MessageBox.Show($"No existen extractos disponibles para el periodo de {cmbMes.Text} de {cmbAnio.Text}.");
                return;
            }

            var resultado = data.fnc_generarExtracto(id_usuarioActual, periodo);
            var infoCuenta = data.fnc_obtenerInfoCuenta(id_usuarioActual);

            decimal saldoInicio = resultado.Value.outP_saldoInicio;
            decimal ingresos = resultado.Value.outP_ingresos;
            decimal egresos = resultado.Value.outP_egresos;
            decimal saldoFin = resultado.Value.outP_saldoFin;
            DateTime fechaInicio = resultado.Value.outP_fechaInicio;
            DateTime fechaFin = resultado.Value.outP_fechaFin;

            string titular = infoCuenta.Value.outPrm_nombre.ToString();
            int numeroCuenta = int.Parse(infoCuenta.Value.outPrm_numeroCuenta.ToString());

            formExtracto frmExtracto = new formExtracto (
                fechaInicio,
                fechaFin,
                saldoInicio,
                ingresos,
                egresos,
                saldoFin,
                titular,
                numeroCuenta,
                id_usuarioActual
                    );

            this.Close();
            frmExtracto.ShowDialog();

        }
    }
}
