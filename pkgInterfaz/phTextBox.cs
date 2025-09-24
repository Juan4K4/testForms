using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace testForms.pkgInterfaz
{
    internal class phTextBox : TextBox
    {
        public phTextBox() 
        { 
            this.Enter += new EventHandler(enter);
            this.Leave += new EventHandler(leave);

            base.ForeColor = Color.DimGray;
            this.Size = new Size(250, 40);
            this.Font = new Font("Codec Pro", 8);
            this.Padding = new Padding(0, 8, 0, 0);
        }
        private string placeHolder;
        public string PlaceHolder
        {
            get { return placeHolder; }
            set { placeHolder = value; }
        }

        private void enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.Text == placeHolder)
            {
                txt.Text = string.Empty;
                txt.ForeColor = Color.Black;
            }
        }

        private void leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.Text == string.Empty)
            {
                txt.Text = placeHolder;
                txt.ForeColor = Color.DimGray;
            }
        }
    }
}
