using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_09
{
    public class Square : Two_D
    {
        public double s;

        public Square(double s)
        {
            this.s = s;
        }
        public override double area()
        {
            return s * s;
        }

        public override double perimeter()
        {
            return s*4;
        }
    }
}
