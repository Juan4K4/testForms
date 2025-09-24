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
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Color color1 = ColorTranslator.FromHtml("#000000");
            Color color2 = ColorTranslator.FromHtml("#5C69F5");

            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       color1,
                                                                       color2,
                                                                       45f))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}
