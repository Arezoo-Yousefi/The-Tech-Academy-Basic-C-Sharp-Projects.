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
            bool IsWeekend = false;
            do
            {
                Console.Write("Enter the day:");
                string day = Console.ReadLine();
                string weekday = char.ToUpper(day[0]) + day.Substring(1).ToLower();
                Console.WriteLine(weekday);
                switch (weekday)
                {
                    case "Sunday":
                    case "Saturday":
                        Console.WriteLine("yohooooo! weekend");
                        IsWeekend = true;
                        break;
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "thursday":
                    case "Friday":
                        Console.WriteLine("Weekdays");
                        break;
                    default:
                        Console.WriteLine("This is not a day name!!!");
                        break;
                }
            } while (!IsWeekend);
            Console.ReadLine();
        }
    }
}
