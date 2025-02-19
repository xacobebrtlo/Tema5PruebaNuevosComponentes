namespace FormPruebaComponentes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ahorcado1 = new Tema5PruebaNuevosComponentes.Ahorcado();
            this.etiquetaAviso1 = new Tema5PruebaNuevosComponentes.EtiquetaAviso();
            this.labelTextBox1 = new Tema5PruebaNuevosComponentes.LabelTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cambio de posicion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cambio separacion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ahorcado1
            // 
            this.ahorcado1.Errores = 8;
            this.ahorcado1.Location = new System.Drawing.Point(293, 210);
            this.ahorcado1.Name = "ahorcado1";
            this.ahorcado1.Size = new System.Drawing.Size(495, 55);
            this.ahorcado1.TabIndex = 5;
            this.ahorcado1.Text = "-";
            // 
            // etiquetaAviso1
            // 
            this.etiquetaAviso1.ColorFinal = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.etiquetaAviso1.ColorInicial = System.Drawing.Color.Yellow;
            this.etiquetaAviso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaAviso1.Gradiente = false;
            this.etiquetaAviso1.ImagenMarca = global::FormPruebaComponentes.Properties.Resources.El_viaje_de_Chihiro_348587850_large___copia___copia;
            this.etiquetaAviso1.Location = new System.Drawing.Point(62, 158);
            this.etiquetaAviso1.Marca = Tema5PruebaNuevosComponentes.EMarca.Imagen;
            this.etiquetaAviso1.Name = "etiquetaAviso1";
            this.etiquetaAviso1.Size = new System.Drawing.Size(238, 36);
            this.etiquetaAviso1.TabIndex = 4;
            this.etiquetaAviso1.Text = "etiquetaAviso1";
            // 
            // labelTextBox1
            // 
            this.labelTextBox1.Location = new System.Drawing.Point(62, 41);
            this.labelTextBox1.Name = "labelTextBox1";
            this.labelTextBox1.Posicion = Tema5PruebaNuevosComponentes.LabelTextBox.EPosicion.IZQUIERDA;
            this.labelTextBox1.PswChr = '*';
            this.labelTextBox1.Separacion = 0;
            this.labelTextBox1.Size = new System.Drawing.Size(135, 20);
            this.labelTextBox1.Subrallado = true;
            this.labelTextBox1.TabIndex = 3;
            this.labelTextBox1.TextLbl = "label1";
            this.labelTextBox1.TextTxt = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ahorcado1);
            this.Controls.Add(this.etiquetaAviso1);
            this.Controls.Add(this.labelTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

    
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Tema5PruebaNuevosComponentes.LabelTextBox labelTextBox1;
        private Tema5PruebaNuevosComponentes.EtiquetaAviso etiquetaAviso1;
        private Tema5PruebaNuevosComponentes.Ahorcado ahorcado1;
    }
}

