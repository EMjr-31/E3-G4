using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E3_G4
{
    public class Figura
    {
        private double area;
        public Figura( double A)
        {
            area = A;
        }
        public double Area
        {
            get { return area; }
            set { area = value; }
        }
        public virtual void CalcularArea(Label LR)
        {

        }
    }
}
