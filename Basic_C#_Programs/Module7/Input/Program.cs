using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pleasr enter a number: ");//Asks the user for a number.
            string num = Console.ReadLine();

            //Logs that number to a text file.
            File.WriteAllText(@"D:\AolccProjects\C#\Basic_C#_Programs\Module7\logs\log.txt", num);

            //Prints the text file back to the user
            Console.WriteLine($"This is a log from the number you entered {File.ReadAllText(@"D:\AolccProjects\C#\Basic_C#_Programs\Module7\logs\log.txt")}");
            Console.Read();
        }
    }
}
