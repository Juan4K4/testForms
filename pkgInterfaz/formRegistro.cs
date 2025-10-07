using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using testForms.pkgLogica;

namespace testForms
{
    public partial class formRegistro : Form
    {
        formLogin frmLogin = new formLogin();
        public formRegistro()
        {
            InitializeComponent();
        }

        public formRegistro(formLogin login)
        {
            InitializeComponent();
            frmLogin = login;
        }

        private void btnLoginBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin.Show();
        }

        private void formRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string v_nombre = txtNombre.Text;
            string v_mail = txtCorreo.Text;
            int v_id = int.Parse(txtId.Text);
            string v_usuario = txtUsuario.Text;
            string v_clave = txtClave.Text;
            string v_fechaNac = dtpFechaNac.Value.Date.ToString("dd/MM/yyyy");

            Usuario u = new Usuario();  
            int resultadoDml = u.fnc_registrarUsuario(v_nombre, v_mail, v_id, v_usuario, v_clave, v_fechaNac);

            if (resultadoDml == 0)
            {
                MessageBox.Show("No se ha podido completar el registro");
            }
            else
            {
                MessageBox.Show("Registro completado correctamente");
            }
        }
    }
}