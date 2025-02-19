using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema5PruebaNuevosComponentes
{
    public partial class Ahorcado : Control
    {

        public Ahorcado()
        {
            InitializeComponent();
        }

        private int errores;
        [Category("Comportamiento")]
        [Description("Numero de errores del ahorcado")]
        public int Errores
        {
            set
            {
                errores = value;
                Refresh();
            }
            get { return errores; }
        }



        [Category("Comportamiento")]
        [Description("Ocurre cuando cambia el numero de errores")]
        public event EventHandler cambiaError;

        public void onCambiaError(EventArgs e)
        {
            cambiaError?.Invoke(this, e);

        }

        [Category("Comportamiento")]
        [Description("Ocurre cuando se completa el dibujo")]
        public event EventHandler Ahoracado;
        public void onAhoracado(EventArgs e)
        {
            Ahoracado?.Invoke(this, e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            switch (Errores)
            {
                case 1:
                    g.DrawLine(new Pen(Color.Green, 5), 0, this.Height - 3, this.Width, this.Height - 3);
                    break;

                case 2:
                    g.DrawLine(new Pen(Color.Green, 5), this.Width / 3, 0, this.Width / 3, this.Height);
                    goto case 1;

                case 3:
                    g.DrawLine(new Pen(Color.Green, 5), this.Width / 3, 2, (this.Width / 2) + (this.Width / 3), 2);
                    goto case 2;

                case 4:
                    g.DrawLine(new Pen(Color.Green, 5), (this.Width / 2) + (this.Width / 3) - 2, 1, (this.Width / 2) + (this.Width / 3) - 2, (this.Height / 5));
                    goto case 3;

                case 5:
                    g.DrawEllipse(new Pen(Color.Green, 5), ((this.Width / 2) + (this.Width / 3)) - (this.Height / 6) / 2, this.Height / 5, this.Height / 6, this.Height / 6);

                    goto case 4;
                case 6:
                    g.DrawLine(new Pen(Color.Green, 5), (this.Width / 2) + (this.Width / 3), this.Height / 2.8f, (this.Width / 2) + (this.Width / 3), this.Height / 1.5f);
                    goto case 5;

                case 7:
                    g.DrawLine(new Pen(Color.Green, 5), (this.Width / 2) + (this.Width / 3), this.Height / 1.55f, (this.Width / 2) + (this.Width / 4), (this.Height / 2) + (this.Height / 3));
                    g.DrawLine(new Pen(Color.Green, 5), (this.Width / 2) + (this.Width / 3), this.Height / 1.55f, (this.Width / 2) + (this.Width / 5.2f) * 2, (this.Height / 2) + (this.Height / 3));
                    goto case 6;
                case 8:
                    g.DrawLine(new Pen(Color.Green, 5), (this.Width / 2) + (this.Width / 3), this.Height / 2.2f, (this.Width / 2) + (this.Width / 4), this.Height / 1.6f);
                    g.DrawLine(new Pen(Color.Green, 5), (this.Width / 2) + (this.Width / 3), this.Height / 2.2f, (this.Width / 2) + (this.Width / 4.9f) * 2, this.Height / 1.6f);
                    goto case 7;



            }

            //Refresh();


        }

    }
}
