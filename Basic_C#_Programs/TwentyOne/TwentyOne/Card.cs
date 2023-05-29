using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        public Card(string s, string f)
        {
            Suit = s;
            Face = f;
        }
        public Card()
        {
            Suit = "Spade";
            Face = "two";
        }
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
