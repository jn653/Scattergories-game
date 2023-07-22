using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scattergories_basic
{
    class Scattergories
    {
        int numOfPlayers;
        int numOfRounds;
        int timer;

        // Empty constructor
        public Scattergories() { }

        // Custom Constructor
        public Scattergories(int numOfPlayers, int numOfRounds, int timer)
        {
            this.numOfPlayers = numOfPlayers;
            this.numOfRounds = numOfRounds;
            this.timer = timer;
        }

        public int NumOfPlayers { get; set; }

        public int NumOfRounds { get; set; }

        public int Timer { get; set;}
        
    }
}
