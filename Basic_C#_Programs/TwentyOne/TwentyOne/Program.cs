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
            Deck deck = new Deck();
            foreach(Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " " + card.Suit);
                
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
        public static Deck shuffle(Deck deck)
        {
            List<Card> tempList = new List<Card>();
            Random random = new Random();
            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                tempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = tempList;
            return deck;
        }
    }
}
