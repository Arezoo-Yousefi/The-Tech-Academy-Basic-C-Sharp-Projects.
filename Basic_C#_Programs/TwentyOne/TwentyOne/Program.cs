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

            Game game = new TwentyOneGame();
            Player player = new Player();
            player.Name = "Arezoo";
            game = game + player;

            Deck deck = new Deck();
            deck.Shuffle(3);
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " " + card.Suit);

            }
            //Console.WriteLine($"The total cards  are: {deck.Cards.Count}");
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string> { "Arezoo", "Ali", "Parmida" };
            //game.listPlayer();
            //game.play();
            //Dealer dealer = new Dealer();

            Console.ReadLine();
        }


        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for(int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
        
    }
}
