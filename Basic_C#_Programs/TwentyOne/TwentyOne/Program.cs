using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to this Cosino, Let's start with telling me your name: ");
            string playerName = Console.ReadLine();

            Console.Write("How much money did you bring today? ");
            int bank = Convert.ToInt32(Console.ReadLine());

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
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!!");

            }

            Console.WriteLine("Feel free to go around the Casino, Bye for now.");
            Console.ReadLine();

        }
    }
}
