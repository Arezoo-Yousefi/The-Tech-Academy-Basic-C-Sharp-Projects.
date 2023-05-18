using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to Package Express. Please follow the instructions below.\nPlease enter the package weight:");
            double packageWeight = Convert.ToDouble(Console.ReadLine());
            if (packageWeight > 50)//the package is heavier thn 50
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.Read();
            }
            else
            {
                Console.Write("Please enter the package height:");//package height
                double packageHeight = Convert.ToDouble(Console.ReadLine());//package height
                Console.Write("Please enter the package Width:");
                double packageWidth = Convert.ToDouble(Console.ReadLine());//package width
                Console.Write("Please enter the package length:");
                double packageLength = Convert.ToDouble(Console.ReadLine());//package length
                decimal price = (decimal)(packageWidth * packageLength * packageHeight * packageWeight / 100);
                //var x = string.Format("{0:#.00}", price);
                Console.WriteLine($"Your estimated total for shipping this package is: {price:#0.00} $\nThank you");//change the format to money 
                //var x = string.Format("Your estimated total for shipping this package is: {0:#.00} $", price);
                Console.Read();//the page is still visible untill pressing enter
            }

        }
    }
}
