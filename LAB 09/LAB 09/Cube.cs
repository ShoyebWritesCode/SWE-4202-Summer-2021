using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_09
{
    public class Cube : Three_D
    {
        public double p;

        public Cube (double p)
        {
            this.p = p;
        }
        public override double Sarea()
        {
            return 6*p*p;
        }

        public override double Vol()
        {
            return p*p*p;
        }
    }
}
