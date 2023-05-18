using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonOperators
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program\nPerson 1");
            Console.WriteLine("Please enter your Hourly Rate");
            decimal rateOne = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter Hours worked per week");
            int workHourOne = Convert.ToInt32(Console.ReadLine());
            decimal resultOne = rateOne * workHourOne * 52;
            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter your Hourly Rate");
            decimal rateTwo = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter Hours worked per week");
            int workHourTwo = Convert.ToInt32(Console.ReadLine());
            decimal resultTwo = rateTwo * workHourTwo * 52;
            Console.WriteLine("Annual salary of Person 1:" + resultOne);//yearly income first person
            Console.WriteLine("Annual salary of Person 2:" + resultTwo);//yearly income second person
            Console.WriteLine("Does person 1 make more money than person two? " + Convert.ToString(resultOne > resultTwo));
            Console.Read();



        }
    }
}
