using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E3_G4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Figura[] arreglo = new Figura[5];
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            double R = double.Parse(txtRadio.Text);
            double A = 0;
            Circulo circulo = new Circulo(A, R);
            circulo.CalcularArea(lbRespuestaC);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double L = double.Parse(txtLado.Text);
            double A = 0;
            Cuadrado cuadrado = new Cuadrado(A,L);
            cuadrado.CalcularArea(LR);
        }

        private void btnCalcularV_Click(object sender, EventArgs e)
        {
            double R = double.Parse(txtValor.Text);
            double A = 0;
            double L = double.Parse(txtValor.Text);
            arreglo[0]= new Cuadrado(A,L);
            arreglo[1] = new Cuadrado(A, L+1);
            arreglo[2] = new Circulo(A,R);
            arreglo[3] = new Circulo(A, R+1);
            arreglo[4] = new Circulo(A, R+2);

            arreglo[0].CalcularArea(label4);
            arreglo[1].CalcularArea(label5);
            arreglo[2].CalcularArea(label6);
            arreglo[3].CalcularArea(label7);
            arreglo[4].CalcularArea(label8);

        }
    }
}
