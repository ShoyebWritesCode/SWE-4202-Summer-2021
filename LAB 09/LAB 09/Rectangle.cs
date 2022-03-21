using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_09
{
    public class Rectangle : Two_D
    {
        public double l1;
        public double l2;

        public Rectangle(double l1, double l2)
        {
            this.l1 = l1;
            this.l2 = l2;
        }
        public override double area()
        {
            return l1 * l2;
        }

        public override double perimeter()
        {
            return 2* (l1+ l2);
        }
    }
}
