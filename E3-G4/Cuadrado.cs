using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E3_G4
{
    class Cuadrado : Figura
    {
        private double lado;
        public Cuadrado(double A, double L) : base(A)
        {
            lado = L;
        }
        public double Lado
        {
            get { return lado;}
            set{ lado = value;}
        }
        public override void CalcularArea(Label LR)
        {
            Area = (Lado * Lado);
            LR.Text = "Area: " + Area;
        }
    }
}
