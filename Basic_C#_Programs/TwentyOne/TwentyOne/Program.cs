using System;
using Casino;

using Casino.Twentyaone;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Ali");

            //DateTime todayDay = new DateTime(2023, 06, 05 , 3, 33, 30);
            //DateTime startDay = new DateTime(2023, 01, 16, 07, 14, 20);
            //TimeSpan differance = todayDay - startDay;
            //using (StreamWriter file = new StreamWriter(@"D:\AolccProjects\C#\Basic_C#_Programs\Module7\logs\log.txt", false))
            //{
            //    file.WriteLine(differance);
            //};
            //string dif = Convert.ToString(differance);
            //File.WriteAllText(@"D:\AolccProjects\C#\Basic_C#_Programs\Module7\logs\log.txt", dif);
            const string casino = "Casino";
            Console.Write($"Welcome to this {casino}, Let's start with telling me your name: ");
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.Write("How much money did you bring today? ");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if(!validAnswer)Console.WriteLine("Please enter a amount of money in digits not decimal");
            }
           

            Console.Write($"Hello {playerName}, Would you like to join the game right now? ");
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" ||answer=="ya"|| answer == "y")
            {
                Player player = new Player(playerName,bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while(player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("Security kick this person out!");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occured, please contact the administrator");
                        Console.ReadLine();
                        return;
                    }
                   
                }
                game -= player;
                Console.WriteLine("Thank you for playing!!");

            }

            Console.WriteLine("Feel free to go around the Casino, Bye for now.");
            Console.ReadLine();

        }
    }
}
