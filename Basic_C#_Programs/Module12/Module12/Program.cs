using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12
{
    class Program
    {
        static void Main(string[] args)
        {
            bool getDay = false;
            Console.Write("Enter the day:");
            string day = Console.ReadLine();
            string weekday = char.ToUpper(day[0]) + day.Substring(1).ToLower();
            Console.WriteLine(weekday);
            do
            {
                switch (weekday)
                {
                    case "Sunday":
                        Console.WriteLine("yohooooo! weekend");
                        getDay = true;
                        break;
                    case "Saturday":
                        Console.WriteLine("yohooooo! Weekend");
                        getDay = true;
                        break;
                    default:
                        Console.WriteLine("Weekdays");
                        Console.WriteLine("Name another day");
                        day = Console.ReadLine();
                        break;


                }
            } while (getDay);
            Console.ReadLine();
        }
    }
}
