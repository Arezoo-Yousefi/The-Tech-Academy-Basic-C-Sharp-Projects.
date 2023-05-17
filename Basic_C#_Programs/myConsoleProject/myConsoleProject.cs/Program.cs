using System;


namespace myConsoleProject.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hi, " + name + "!");
            Console.Read();
        }
    }
}
