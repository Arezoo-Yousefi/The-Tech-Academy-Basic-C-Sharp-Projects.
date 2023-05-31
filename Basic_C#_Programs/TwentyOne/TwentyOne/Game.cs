using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game
    {
        public Game()
        {
            Players = new List<Player>();
        }
        public List<Player> Players { get; set; }
        public string Dealer { get; set; }
        public string name { get; set; }
        public abstract void Play();
        public virtual void listPlayer()
        {
            foreach(Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }

    }
}
