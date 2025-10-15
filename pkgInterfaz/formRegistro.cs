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
using testForms.pkgInterfaz;

namespace testForms
{
    public partial class formRegistro : Form
    {
        formLogin frmLogin = new formLogin();
        bool camposObligatorios;
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

            /** Diseño **/
            lblDatosObligatorios.Hide();

            /** Logica  **/

            DateTime fechaMaxima = DateTime.Today.AddYears(-18);
            dtpFechaNac.MaxDate = fechaMaxima;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is placeHolderBox txt)
                {
                    txt.TextChanged += fnc_validarCampos;
                }
            }
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
        private void fnc_validarCampos(object sender, EventArgs e)
        {
            formRegistro frm = new formRegistro();
            bool campos = true;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is placeHolderBox ph) 
                {
                    if (string.IsNullOrEmpty(ph.Text))
                    {
                        campos = false;
                        break;
                    }
                }
            }

            if (campos)
            {
                btnRegistrar.Enabled = campos;
                btnRegistrar.BackColor = Color.Orange;

                lblDatosObligatorios.Show();
                lblDatosObligatorios.Enabled = !campos;
            }
        }
    }
}