using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int numOne = Convert.ToInt32(Console.ReadLine());
            int resultOne = numOne * 50;
            Console.WriteLine(resultOne);
            Console.WriteLine("Enter another number");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            int resultTwo = numTwo + 25;
            Console.WriteLine(resultTwo);
            Console.WriteLine("Enter another number");
            int numThree = Convert.ToInt32(Console.ReadLine());
            float resultThree= (float)(numThree /12.5);
            Console.WriteLine(resultThree);
            Console.WriteLine("Enter the temprature");
            int temprature = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(temprature > 50);//check if the temprature is greater than 50;
           
            Console.WriteLine("Enter another number");
            int numFour = Convert.ToInt32(Console.ReadLine());
            int resultFour = numFour % 7;//remainder of the division by 7
            Console.WriteLine(resultFour);
        }
    }
}
