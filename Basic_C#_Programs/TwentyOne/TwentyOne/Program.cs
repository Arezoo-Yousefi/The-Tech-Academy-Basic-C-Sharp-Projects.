﻿using System;
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
            int timesShuffled = 0;
            deck = Shuffle(deck, out timesShuffled, 3);
            foreach(Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " " + card.Suit);
                
            }
            Console.WriteLine($"The total cards  are: {deck.Cards.Count} +  and times deck are shuffled is: {timesShuffled}");
            Console.ReadLine();
        }
        
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        {
            timesShuffled = 0;
            for(int i = 0; i<times; i++)
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
                timesShuffled++;
            }
            return deck;
            
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
