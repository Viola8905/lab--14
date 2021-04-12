using System;
using System.Collections.Generic;
using System.Text;

namespace lab14
{
    class Rivnostor : TTriangle
    {
        private double a_;
        public double a
        {
            get { return a_; }
            set
            {
                if (value > 0) a_ = value;
                else a_ = 1;
            }
        }
        public Rivnostor (double a)
        {
            this.a = a;
        }
        double TTriangle.Perimeter()
        {
            return a * 3;
        }
        double TTriangle.Square()
        {
            return (Math.Pow(a, 2) * Math.Sqrt(3)) / 4;
        }
    }
}
