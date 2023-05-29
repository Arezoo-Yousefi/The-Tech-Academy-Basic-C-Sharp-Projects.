using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many tickets do you need: ");
            int tickets = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the number of people who would like to join you: ");
            int result = Convert.ToInt32(Console.ReadLine())+1;//total number of people
            Math math = new Math();
            int total;
            if (result == 0)
            {
                total = math.TicketTotal(tickets);
                Console.WriteLine($"The total amount you should pay is {total*70:00.00} $");
            }else
            {
                total = math.TicketTotal(tickets, result);
                Console.WriteLine($"The total amount you should pay is {total * 70:00.00} $");
            }
            Console.ReadLine();
           
        }
    }
}
