using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame: Game
    {
        public override void Play()
        {
            Console.WriteLine("hello");
        }
        public override void listPlayer()
        {
            Console.WriteLine(" list of players:");
            base.listPlayer();
        }
        

        
       
    }

}
