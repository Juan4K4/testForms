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

namespace testForms.pkgInterfaz
{
    public partial class formMovimientos : Form
    {
        Datos data = new Datos();
        int id_usuarioActual = 0;
        public formMovimientos(int prm_idUsuario)
        {
            InitializeComponent();
            dgvMovimientos.Enabled = false;
            dgvMovimientos.Hide();
            dgvMovimientos.AutoSize = true;

            id_usuarioActual = prm_idUsuario;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formMovimientos_Load(object sender, EventArgs e)
        {
            DataTable tabla = data.fnc_consultarMovimientos(id_usuarioActual);
            if (tabla != null)
            {
                dgvMovimientos.Enabled = true;
                dgvMovimientos.DataSource = tabla;
                dgvMovimientos.AutoResizeRows();
                dgvMovimientos.AutoResizeColumns();
                dgvMovimientos.Show();
            }
        }
    }
}
