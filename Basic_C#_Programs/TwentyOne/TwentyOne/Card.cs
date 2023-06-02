using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public struct Card
    {
        public suitEnum Suit { get; set; }
        public faceEnum Face { get; set; }
        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }
    public enum suitEnum
    {
        Clubs,
        Diamonds,
        Hearts, 
        Spades
    }
    public enum faceEnum
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight, 
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
