using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Console.WriteLine("Academy of Learning Career College \nStudent Daily Report");
        Console.WriteLine("What is your name ? ");
        string YourName = Console.ReadLine();//The name is typed
        Console.WriteLine("What course are you on? ");
        string courseName = Console.ReadLine();//the course is typed
        Console.WriteLine("What page number?");
        int pageNumber = Convert.ToInt32(Console.ReadLine());//change the datatype string to integer
        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
        bool anyNeeded = Convert.ToBoolean(Console.ReadLine());//change the datatype string to boolean 
        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics");
        string experiance = Console.ReadLine();
        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        string feedback = Console.ReadLine();
        Console.WriteLine("How many hours did you study today?");
        int studyHours = Convert.ToInt32(Console.ReadLine());//change the datatype string to int
        Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
        Console.Read();//still stay on the page


    }
}

