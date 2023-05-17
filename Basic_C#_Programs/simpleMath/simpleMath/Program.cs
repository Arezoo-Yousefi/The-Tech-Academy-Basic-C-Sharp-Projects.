using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleMath
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your first number:");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number:");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the addition of these two numbers is: " + Convert.ToString(numberOne + numberTwo));
            Console.WriteLine("the subtraction of these two numbers is: " + Convert.ToString(numberOne - numberTwo));
            Console.WriteLine("the multiplication of these two numbers is: " + Convert.ToString(numberOne * numberTwo));
            Console.WriteLine("the division of these two numbers is: " + (numberOne / numberTwo));//concatenate string and int;

            Console.Read();
        }
    }
}
