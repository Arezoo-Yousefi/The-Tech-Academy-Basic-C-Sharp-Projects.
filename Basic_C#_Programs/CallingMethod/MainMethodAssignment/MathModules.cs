using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class MathModules
    {
        const double pi = 3.14;
        public double CircleArea(int radius)//if the input is integer this method is used 
        {
            
            double result = Convert.ToDouble(radius * radius * pi);
            
            return result;
        }
        public decimal CircleArea(decimal radius)// if the type of the input is decimal this method is used
        {
            decimal result = radius * radius * Convert.ToDecimal(pi);
            return result;
        }
        public string CircleArea(string radius)// if the type of the input is string this method is used
        {
            string result = radius + "*" + radius + "*" + Convert.ToString(pi);
            return result;
        }
    }
}
