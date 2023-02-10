using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ian Haworth
// Game Class

namespace AssignmentTwo
{
    internal class Game
    {
        private string[] targets = new string[] { "Gold", "Silver", "Red", "Blue" };
        private int[] prizes = new int[] { 1000, 500, 350, 700};
        private string targetWord;
        public int currentPrize { get; set; }

        public int turn { get; set; }
        public int playerScore { get; set; }

        public void randomWord()
        {
            Random random = new Random();
            int num = random.Next() % targets.Length;
            targetWord = targets[num];
        }
        public void randomPrize()
        {
            Random random = new Random();
            int num = random.Next() % prizes.Length;
            currentPrize = prizes[num];
        }

        public Game()
        {
            randomWord();
            turn = 1;
            playerScore = 0;
        }


        public string TargetWord
        {
            get
            {
                return targetWord;
            }
            set
            {
                targetWord = value;
            }
        }
    }
}
