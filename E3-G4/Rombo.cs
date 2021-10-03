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
        private double d1;
        private double d2;
        public Rombo(double A, double D1, double D2) : base(A)
        {
            d1 = D1;
            d1 = D2;
        }

        public double D1 { get => d1; set => d1 = value; }
        public double D2 { get => d2; set => d2 = value; }

        public override void CalcularArea(Label LR)
        {
            Area = (D1*D2)/2;
            LR.Text = "Area: " + Area;
        }
    }
}
