using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testForms.pkgInterfaz
{
    internal class pDegradado : Panel
    {
        private string hexColor1 = "#FF5733";
        private string hexColor2 = "#33FFBD";
        private float angle = 45f;

        [Category("Gradient Colors")]
        public string HexColor1
        {
            get => hexColor1;
            set { hexColor1 = value; Invalidate(); }
        }

        [Category("Gradient Colors")]
        public string HexColor2
        {
            get => hexColor2;
            set { hexColor2 = value; Invalidate(); }
        }

        [Category("Gradient Colors")]
        public float Angle
        {
            get => angle;
            set { angle = value; Invalidate(); }
        }

        public pDegradado()
        {
            this.DoubleBuffered = true;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            try
            {
                Color color1 = ColorTranslator.FromHtml(hexColor1);
                Color color2 = ColorTranslator.FromHtml(hexColor2);

                using (LinearGradientBrush brush = new LinearGradientBrush(
                           this.ClientRectangle,
                           color1,
                           color2,
                           angle))
                {
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }
            }
            catch
            {
                base.OnPaintBackground(e);
            }
        }
    }
}
