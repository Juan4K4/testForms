using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace testForms.pkgInterfaz
{
    public partial class pLineaTextBox : UserControl
    {
        placeHolderBox ph = new placeHolderBox();

        public pLineaTextBox()
        {
            InitializeComponent();
        }

        public string _label = "label";
        public string _ph = "placeholder";
        public bool _esClave = false;
        public int _limiteCaracteres = default;
        private int _radio = 8;

        [Category("Apariencia")]
        [Description("Define el radio de las esquinas del control.")]
        public int Radius
        {
            get { return _radio; }
            set
            {
                _radio = value;
                this.Invalidate();
            }
        }

        public string label
        {
            get { return _label; }
            set { _label = value; }
        }

        public enum TipoEntrada
        {
            Texto,
            Numerico,
            Especial
        }

        public TipoEntrada Tipo { get; set; } = TipoEntrada.Texto;

        public bool esClave
        {
            get { return _esClave; }
            set
            {
                _esClave = value;
                placeHolderBox1.UseSystemPasswordChar = _esClave;
            }
        }
        public int limiteCaracteres
        {
            get { return _limiteCaracteres; }
            set { _limiteCaracteres = value; }
        }
        public string placeholder
        {
            get { return _ph; }
            set { _ph = value; }
        }
        public placeHolderBox TextBoxInterno
        {
            get { return placeHolderBox1; }
        }

        private void pLineaTextBox_Load(object sender, System.EventArgs e)
        {

            placeHolderBox1.UseSystemPasswordChar = _esClave;
        }

        public event KeyPressEventHandler TextBoxKeyPress
        {
            add { placeHolderBox1.KeyPress += value; }
            remove { placeHolderBox1.KeyPress -= value; }
        }

        private void placeHolderBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (Tipo)
            {
                case TipoEntrada.Texto:
                    e.Handled = (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar));
                    break;
                case TipoEntrada.Numerico:
                    e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar));
                    break;
                case TipoEntrada.Especial:
                    e.Handled = (!char.IsLetter(e.KeyChar)
                                && !char.IsControl(e.KeyChar)
                                && !char.IsNumber(e.KeyChar)
                                && !e.KeyChar.Equals('@')
                                && !e.KeyChar.Equals('.')
                                && !e.KeyChar.Equals('-')
                                && !e.KeyChar.Equals('_')
                                );
                    break;
            }
        }
        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();

            if (diameter > rect.Width) diameter = rect.Width;
            if (diameter > rect.Height) diameter = rect.Height;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);           // Superior Izquierda
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);    // Superior Derecha
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90); // Inferior Derecha
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);     // Inferior Izquierda

            path.CloseAllFigures();
            return path;
        }
        private void pLineaTextBox_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = label;
            placeHolderBox1.PlaceHolder = placeholder;
            placeHolderBox1.MaxLength = limiteCaracteres;

            if (_radio > 0)
            {
                Rectangle bounds = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

                using (GraphicsPath path = GetRoundedRect(bounds, _radio))
                {
                    this.Region = new Region(path);

                    using (Pen pen = new Pen(Color.Gray, 1)) 
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            }
        }
    }
}