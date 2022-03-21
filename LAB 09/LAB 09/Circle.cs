using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_09
{
    public class Circle : Two_D
    {
        public double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double area()
        {
            return 3.1416 * Math.Pow(radius, 2);
        }

        public override double perimeter()
        {
            return 2 * 3.1416 * radius;
        }
    }
}
