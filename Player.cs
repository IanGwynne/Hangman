using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ian Haworth
// Class for the two players

namespace AssignmentTwo
{
    internal class Player
    {
        public string playerName { get; set; }
        public int playerScore { get; set; }
        public int numWins { get; set; }
        public int numLosses { get; set; }

        public Player(string passedName)
        {
            playerName = passedName;
            playerScore = 0;
            numWins = 0;
            numLosses = 0;
        }
    }

}
