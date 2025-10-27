using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testForms.pkgLogica;

namespace testForms.pkgInterfaz
{
    public partial class formSolicitudes : Form
    {
        int id_usuarioActual = 0;
        Usuario user = new Usuario();
        public formSolicitudes(int prm_idUsuarioActual)
        {
            InitializeComponent();
            id_usuarioActual = prm_idUsuarioActual;
        }

        private void tabExtracto_Enter(object sender, EventArgs e)
        {
            DateTime fechaCreacion = user.fnc_verificarFechaCreacion(id_usuarioActual);
            DateTime fechaActual = DateTime.Now;

            cmbAnio.Items.Clear();

            int anioInicio = fechaCreacion.Year;
            int anioFin = fechaActual.Year;

            for (int anio = anioFin; anio >= anioInicio; anio--)
            {
                cmbAnio.Items.Add(anio.ToString());
            }
        }
    }
}
