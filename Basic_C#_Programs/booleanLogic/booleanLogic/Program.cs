using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int yourAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?");
            bool haveDUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int speedTicket = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("qualified?");
            Console.WriteLine(yourAge > 14 && haveDUI == false && speedTicket <=3);//applicant must be over 14
            //and must not have DUI and must not have more than 3 speed ticket
            Console.Read();
        }
    }
}
