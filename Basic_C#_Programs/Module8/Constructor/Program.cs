using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radius");
            double radius = Convert.ToDouble(Console.ReadLine());
            AreaCounter counter = new AreaCounter(radius);
            var result2 = counter.Area();//variable using the keyword “var.”
            Console.WriteLine($"The area of this circle is {result2}");
            Console.ReadLine();
            
            
        }
    }
}
