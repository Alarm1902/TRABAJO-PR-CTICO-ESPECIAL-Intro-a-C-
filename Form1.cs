using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Figuras
{
    public partial class Form1 : Form
    {
        Figura[] figuras;

        public Form1()
        {
            InitializeComponent();
            figuras = new Figura[5] 
{
    new Circulo(40),
    new Rectangulo(60, 80),
    new Cuadrado(100),
    new TrianguloIsosceles(70, 90),   // base 70, altura 90
    new TrianguloEquilatero(110),     // lado 110
};

        }

        private void button1_Click(object sender, EventArgs e)
{
    Graphics gr = pictureBox1.CreateGraphics();
    Random rnd = new Random();
    
    for (int i = 0; i < figuras.Length; i++)
    {
        Color c = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        Pen pen = new Pen(c);
        figuras[i].Dibujar(pen, gr, 10 + i * 115, 50);
    }
}
    }
}
