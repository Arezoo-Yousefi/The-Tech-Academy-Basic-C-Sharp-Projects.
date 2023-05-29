using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathModules area = new MathModules();
            Console.WriteLine($"The area of a Circle with the radius(3) is {area.CircleArea(3)}" +//integer input
                $"\nThe area of a circle with the radius(3.75) is {area.CircleArea(3.75m)}" +//decimal input
                $"\nThe area of a circle with radius(\" 3.75\") is calculated in {area.CircleArea("3.75")}");//string input

            Console.ReadLine();
        }
    }
}
