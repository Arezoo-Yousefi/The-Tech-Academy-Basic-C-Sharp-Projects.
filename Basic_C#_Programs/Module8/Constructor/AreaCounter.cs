using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class AreaCounter
    {
        public AreaCounter(double rad):this(rad, 2 * rad)//Chain two constructors together
        {

        }
        public AreaCounter(double r, double d)
        {
            xMath = r;
            yMath = d;
        }
        public double xMath { get; set; }
        public double yMath { get; set; }
        public const double pi = 3.14;//Create a const variable.
        public double Area()
        {
            double result = xMath * xMath * pi;
            return result;
        }
    }
}
