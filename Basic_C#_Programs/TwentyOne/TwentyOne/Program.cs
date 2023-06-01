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
            
            Card card1 = new Card();
            Card card2 = card1;
            card1.Face = faceEnum.King;
            card2.Face = faceEnum.Ace;
            Console.WriteLine(card1.Face);

            //Card card1 = new Card();
            //card1.Suit = suitEnum.Clubs;
            //int underlyingValue = Convert.ToInt32(card1.Suit);
            //Console.WriteLine(underlyingValue);
            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Arezoo";
            //game += player;
            //game -= player;

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
