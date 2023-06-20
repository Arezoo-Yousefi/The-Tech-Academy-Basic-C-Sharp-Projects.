using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first name:");
            string fName = Console.ReadLine();
            string todayDate = DateTime.Today.ToShortDateString();
            Console.WriteLine($"{fName} Welcome back. Today is {todayDate}.\n");

            string path = @"D:\AolccProjects\C#\Basic_C#_Programs\Scores\Scores\StudentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);


            double totalScore = 0.0;
            Console.WriteLine("The scores are:\n");
            foreach(string line in lines)
            {
                Console.WriteLine(line + "\n");
                double score = Convert.ToDouble(line);
                totalScore += score;
            }
            double avg = totalScore / lines.Length;
            Console.WriteLine($"\n\nThe Average score for {lines.Length} students is {avg}");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
