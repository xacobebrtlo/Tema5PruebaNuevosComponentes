using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema5PruebaNuevosComponentes;

namespace FormPruebaComponentes
{

    //Si el set está mal puede saltar stackOverFlow (Llamada recursiva)
    //, editar la clase con 
    //Para pruebas 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* Prueba para ver que se ha enlazado en componente txt al LabelTextBox
             */
            Debug.Write("Key pressed");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelTextBox1.Posicion == LabelTextBox.EPosicion.DERECHA)
            {
                labelTextBox1.Posicion = LabelTextBox.EPosicion.IZQUIERDA;
            }
            else
            {
                labelTextBox1.Posicion = LabelTextBox.EPosicion.DERECHA;
            }
        }

        private void labelTextBox1_PosicionChanged(object sender, EventArgs e)
        {
            this.Text = labelTextBox1.Posicion.ToString();
        }

        private void labelTextBox1_SeparationChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("La separacion es: " + labelTextBox1.Separacion);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int num = random.Next(0, 20);
            labelTextBox1.Separacion = num;
            Debug.WriteLine("**" + num);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //            e.Graphics.DrawString("Prueba de escritura de texto",
            //this.Font, Brushes.BlueViolet, 10, 10);
        }

        private void labelTextBox1_TxtChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("hola");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ahorcado1_cambiaError(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
