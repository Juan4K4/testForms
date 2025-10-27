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

        private void pLineaTextBox_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = label;
            placeHolderBox1.PlaceHolder = placeholder;
            placeHolderBox1.MaxLength = limiteCaracteres;
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
                                && !e.KeyChar.Equals('#')
                                );
                    break;
            }
        }
    }
}