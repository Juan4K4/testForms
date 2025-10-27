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
                this.dgvMovimientos.Columns["Monto"].DefaultCellStyle.Format = "C";

                if (dgvMovimientos.Columns.Contains("TipoMovimiento"))
                {
                    foreach (DataGridViewRow row in dgvMovimientos.Rows)
                    {
                        DataGridViewCell cell = row.Cells["TipoMovimiento"];

                        string estado = cell.Value.ToString();

                        if (estado == "Enviado")
                        {
                            cell.Style.BackColor = ColorTranslator.FromHtml("#630000");
                            cell.Style.ForeColor = Color.White;
                        }
                        else if (estado == "Recibido")
                        {
                            cell.Style.BackColor = ColorTranslator.FromHtml("#1a6300");
                            cell.Style.ForeColor = Color.White;
                        }
                    }
                }

                dgvMovimientos.Show();


            }
        }
    }
}
