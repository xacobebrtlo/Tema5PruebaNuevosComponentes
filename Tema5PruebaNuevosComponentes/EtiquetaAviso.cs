using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema5PruebaNuevosComponentes // Revisar tamaño con imagen y en Nada no identar texto y el refresh de img
{
    public enum EMarca
    {
        Nada,
        Cruz,
        Circulo,
        Imagen
    }
    public partial class EtiquetaAviso : Control
    {
        int grosor = 0; //Grosor de las líneas de dibujo
        int offsetX = 0; //Desplazamiento a la derecha del texto
        int offsetY = 0; //Desplazamiento hacia abajo del texto
                         // Altura de fuente, usada como referencia en varias partes
        public EtiquetaAviso()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            int h = this.Font.Height;
            //Esta propiedad provoca mejoras en la apariencia o en la eficiencia
            // a la hora de dibujar
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //Dependiendo del valor de la propiedad marca dibujamos una
            //Cruz o un Círculo


            if (gradiente)
            {//TODO pintar fodno gradiente 

                grosor = 0; //Grosor de las líneas de dibujo
                offsetX = 0; //Desplazamiento a la derecha del texto
                offsetY = 0;
                h = this.Font.Height;
                g.FillRectangle(new LinearGradientBrush(new Point(0, 0), new Point(this.Width, this.Height)
                    , colorInicial, colorFinal), 0, 0, this.Width, this.Height);
            }
            switch (Marca)
            {
                case EMarca.Circulo:
                    grosor = 20;
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor,
                    h, h);
                    offsetX = h + grosor;
                    offsetY = grosor;

                    break;
                case EMarca.Cruz:
                    grosor = 3;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, h, h);
                    g.DrawLine(lapiz, h, grosor, grosor, h);
                    offsetX = h + grosor;
                    offsetY = grosor / 2;
                    //Es recomendable liberar recursos de dibujo pues se
                    //pueden realizar muchos y cogen memoria
                    lapiz.Dispose();
                    break;
                case EMarca.Imagen:
                    grosor = 0; //Grosor de las líneas de dibujo
                    offsetX = 0; //Desplazamiento a la derecha del texto
                    offsetY = 0;
                    if (imagenMarca != null)
                    {
                        g.DrawImage(imagenMarca, 0, 0, h, h);
                        offsetX = h + grosor;
                        offsetY = grosor;
                    }
                    else
                    {
                        goto case EMarca.Nada;
                    }

                    break;
                case EMarca.Nada:
                    grosor = 0;
                    offsetX = 0;
                    offsetY = 0;

                    break;
            }
            //Finalmente pintamos el Texto; desplazado si fuera necesario
            SolidBrush b = new SolidBrush(this.ForeColor);
            g.DrawString(this.Text, this.Font, b, offsetX + grosor, offsetY);
            Size tam = g.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2);
            b.Dispose();

        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }
        private EMarca marca = EMarca.Nada;
        [Category("Appearance")]
        [Description("Indica el tipo de marca que aparece junto al texto")]
        public EMarca Marca
        {
            set
            {
                marca = value;
                this.Refresh();
            }
            get
            {
                return marca;
            }
        }
        private Image imagenMarca;
        [Category("Appearance")]
        [Description("Selecciona la imagen de fondo del componente si esta seleccionada propiedad imagen")]
        public Image ImagenMarca
        {
            set
            {
                imagenMarca = value;
                this.Refresh();
            }
            get { return imagenMarca; }
        }
        private bool gradiente = false;
        [Category("Appearance")]
        [Description("Coloca un fondo gradiente si la propiedad está a true")]
        public bool Gradiente
        {
            set
            {
                gradiente = value;
                this.Refresh();
            }
            get { return gradiente; }

        }

        private Color colorInicial = Control.DefaultBackColor;
        [Category("Appearance")]
        [Description("Selecciona el color inicial del gradiente para el fondo")]
        public Color ColorInicial
        {
            set
            {
                colorInicial = value;
                this.Refresh();
            }
            get { return colorInicial; }

        }
        private Color colorFinal = Control.DefaultForeColor;
        [Category("Appearance")]
        [Description("Selecciona el color final del gradiente para el fondo")]
        public Color ColorFinal
        {
            set
            {
                colorFinal = value;
                this.Refresh();
            }
            get { return colorFinal; }

        }

        [Category("Acción")]
        [Description("Es lanzado cuando el usuario pulsa el ratón pero solo en la zona donde está la marca (salvo que sea Nada)")]
        public event System.EventHandler ClickEnMarca;
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.Location.X <= offsetX && marca != EMarca.Nada)//!= nada
            {
                onClickEnMarca(EventArgs.Empty);
                Debug.WriteLine("Evento marca");
            }
        }
        protected virtual void onClickEnMarca(EventArgs e)
        { 
            if (ClickEnMarca != null)
            {
                ClickEnMarca(this, e);
            }
        }
    }
}
