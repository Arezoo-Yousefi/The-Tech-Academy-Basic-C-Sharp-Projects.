using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>();
        public List<Player> Players { get { return _players; } set {_players = value;} }
        
        public string name { get; set; }

        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public Dictionary<Player, int> Bets { get {return _bets; } set {_bets = value; } }
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
