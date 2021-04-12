using System;
using System.Collections.Generic;
using System.Text;

namespace lab14
{
    class Rivnobed : TTriangle
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
        private double b_;
        public double b
        {
            get { return b_; }
            set
            {
                if (value > 0) b_ = value;
                else b_ = 1;
            }
        }
        public Rivnobed(double a,double b)
        {
            this.a = a;
            this.b = b;
        }
        double TTriangle.Perimeter()
        {
            return a + a + b;
        }
        double TTriangle.Square()
        {
            return ((Math.Sqrt(Math.Pow(a, 2) - Math.Pow(b / 2, 2)))*b)/2;
        }
    }
}
