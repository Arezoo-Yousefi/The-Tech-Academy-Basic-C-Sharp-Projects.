using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game
    {
        public List<string> Players { get; set; }
        public string Dealer { get; set; }
        public string name { get; set; }
        public abstract void Play();
        public virtual void listPlayer()
        {
            foreach(string player in Players)
            {
                Console.WriteLine(player);
            }
        }

    }
}
