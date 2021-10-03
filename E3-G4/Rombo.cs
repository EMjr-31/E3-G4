using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E3_G4
{
    class Rombo: Figura
    {
        private double dma;
        private double dme;
        public Rombo(double A, double D1, double D2) : base(A)
        {
            dma = D1;
            dme= D2;
        }

        public double Dma { get => dma; set => dma = value; }
        public double Dme { get => dme; set => dme = value; }

        public override void CalcularArea(Label LR)
        {
            Area = (Dma*Dme)/2;
            LR.Text = "Area: " + Area;
        }
    }
}
