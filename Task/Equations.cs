using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal struct Equations
    {
        double coeffK;
        double coeffB;

        public Equations(double coeffK, double coeffB)
        {
            this.coeffK = coeffK;
            this.coeffB = coeffB;
        }

        public double Root()
        {
            return   -coeffB/coeffK;
        }
    }
}
