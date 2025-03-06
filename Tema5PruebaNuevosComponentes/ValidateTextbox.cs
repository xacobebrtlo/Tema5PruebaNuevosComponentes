using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tema5PruebaNuevosComponentes
{
    public partial class ValidateTextbox : UserControl
    {
        public ValidateTextbox()
        {
            InitializeComponent();
            IniciarTextBox();
        }

        private void IniciarTextBox()
        {
            textBox1.Location = new Point(10, 10);
            this.Height = textBox1.Height + 20;
            textBox1.Width = this.Width - 20;

        }
        [Category("Apariencia")]
        [Description("Modifica el campo text del textbox interno")]
        public string Texto
        {
            get
            {
                return textBox1.Text;
            }
            set
            {

                textBox1.Text = value;
                Refresh();

            }
        }


        [Category("Apariencia")]
        [Description("Si está a true permite que el textbox interno sea multilina")]
        public bool Multilinea
        {
            get
            {
                return textBox1.Multiline;
            }
            set
            {

                textBox1.Multiline = value;

            }

        }


        public enum eTipo
        {
            Numerico,
            Textual
        }
        private eTipo tipo;
        [Category("Appearance")]
        [Description("enum")]
        public eTipo Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
                Refresh();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            IniciarTextBox();
            string cadena = textBox1.Text.Trim();
            char[] enteros = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] cadenaArray = cadena.ToCharArray();
            bool error = false;
            Color color;
            //e.Graphics.DrawLine(new Pen(Color.Red), new Point(5, 5), new Point(this.Width - 5, this.Height - 5));
            if (Tipo == eTipo.Numerico)
            {
                if (cadena.Length == 0)
                {
                    error = true;
                }
                else
                {
                    foreach (char numero in cadena)
                    {
                        bool esNumero = false;
                        foreach (char numerosComprobar in enteros)
                        {
                            if (numero == numerosComprobar)
                            {
                                esNumero = true;
                                break;
                            }
                        }
                        if (!esNumero)
                        {
                            error = true;
                            break;
                        }
                    }
                }

            }
            else
            {
                if (cadena.Length == 0)
                {
                    error = true;
                }
                else
                {
                    foreach (char caracter in cadenaArray)
                    {
                        if (!Char.IsLetter(caracter))
                        {
                            if (caracter != ' ')
                            {
                                error = true;
                                break;
                            }
                        }
                    }
                }
            }
            if (error)
            {
                color = Color.Red;
            }
            else
            {
                color = Color.Green;
            }
            using (Pen lapiz = new Pen(color))
            {
                Rectangle r = new Rectangle(5, 5, this.Width - 10, this.Height - 10);
                e.Graphics.DrawRectangle(lapiz, r);
            }
        }

        [Category("Apariencia")]
        [Description("Se lanza cuando cambia el texto")]

        public event EventHandler TextChanged;

        protected void OnTextChanged()
        {
            TextChanged?.Invoke(this, EventArgs.Empty);
        }
        private void textbox1_TextChanged(object sender, EventArgs e)
        {
            this.OnTextChanged();
            this.Invalidate();
        }
    }
}
