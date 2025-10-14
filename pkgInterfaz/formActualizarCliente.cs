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
    public partial class formActualizarCliente : Form
    {

        int id_usuarioActual = 0;
        public formActualizarCliente(int prm_usuarioActual)
        {
            InitializeComponent();
            id_usuarioActual = prm_usuarioActual;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formHome home = new formHome(id_usuarioActual);
            this.Close();
            home.Show();
        }
    }
}
