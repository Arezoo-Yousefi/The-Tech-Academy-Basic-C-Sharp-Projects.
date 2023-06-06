using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);//Current date and time
            Console.Write("Enter a number: ");
            float realTime = float.Parse(Console.ReadLine());//ask the user to enter a number 

            DateTime timeAfter = DateTime.Now.AddHours(realTime);//add a number to the current time as hours
            Console.WriteLine($"Your number added to current time is {timeAfter}");
            
            Console.ReadLine();
        }
    }
}
