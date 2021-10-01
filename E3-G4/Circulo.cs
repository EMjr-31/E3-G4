﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E3_G4
{
    public class Circulo: Figura
    {
        private double radio;
        public Circulo(double A, double R) : base(A)
        {
            radio = R;
        }
        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }
        public override void CalcularArea(Label LR)
        {
            Area = (Math.PI * Math.Pow(Radio, 2));
            LR.Text = "Area: " + Area;
        }
    }
}
