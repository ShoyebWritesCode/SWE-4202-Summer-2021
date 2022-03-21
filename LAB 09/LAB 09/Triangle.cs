using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_09
{
    public class Triangle : Two_D
    {
        public double l;
        public double h;
        public double a;

        public Triangle (double l, double h, double a)
        {
            this.l = l;
            this.h = h;
            this.a = a;
        }
        public override double area()
        {
            return (l * h)/2;
        }

        public override double perimeter()
        {
            return l + h + h;
        }
    }
}
