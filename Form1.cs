using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Ian Haworth
// Wheel Of fortune Game

namespace AssignmentTwo
{
    public partial class Form1 : Form
    {
        Player player1;
        Player player2;
        Game game;
        string hiddenWord;
        public Form1()
        {
            InitializeComponent();
        }

        string generateHidden(int passedLength)
        {
            string word = "";
            for (int i = 0; i < passedLength; i++)
                word += "-";
            return word;
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            player1 = new Player(playerOneName.Text);
            player2 = new Player(playerTwoName.Text);
            game = new Game();
            setScore();
            hiddenWord = generateHidden(game.TargetWord.Length);
            targetWord.Text = hiddenWord;
            MessageBox.Show(player1.playerName + "'s turn");
        }
        private void beginGuess_Click_1(object sender, EventArgs e)
        {
            checkGuess();
            setScore();

            if (!targetWord.Text.Contains("-"))
            {
                string winner;
                if (player1.playerScore > player2.playerScore)
                    winner = player1.playerName;
                else if (player1.playerScore > player2.playerScore)
                    winner = player2.playerName;
                else
                    winner = "Tie";
                DialogResult result = MessageBox.Show("Winner: " + winner + '\n' +"would you like to play again", "GAME OVER", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    game.randomWord();
                    player1.playerScore = 0;
                    player2.playerScore = 0;
                    playerOneScore.Text = "";
                    playerTwoScore.Text = "";
                    setScore();
                    hiddenWord = generateHidden(game.TargetWord.Length);
                    targetWord.Text = hiddenWord;
                    MessageBox.Show(player1.playerName + "'s turn");
                }
            }
            else
            {

                if (game.turn == 1)
                {
                    game.turn = 2;
                    MessageBox.Show(player2.playerName + "'s turn");
                }
                else
                {
                    game.turn = 1;
                    MessageBox.Show(player1.playerName + "'s turn");
                }
            }
        }

        private void checkGuess()
        {

            char[] wordGuess = hiddenWord.ToCharArray();
            char[] wordArray = game.TargetWord.ToCharArray();
            if (playerGuess.Text == "")
                MessageBox.Show("nothing entered, turn skipped");

            else if (game.TargetWord.Contains(playerGuess.Text))
            {
                
                for (int ctr = 0; ctr < wordArray.Length; ctr++)
                {
                    if (char.Parse(playerGuess.Text) == wordArray[ctr])
                        wordGuess[ctr] = game.TargetWord[ctr];
                    hiddenWord = new string(wordGuess);
                    targetWord.Text = hiddenWord;
                }
                if (game.turn == 1)
                {
                    player1.playerScore += game.currentPrize;
                    playerOneScore.Text = player1.playerScore.ToString();
                }
                else
                {
                    player2.playerScore += game.currentPrize;
                    playerTwoScore.Text = player2.playerScore.ToString();
                }
            }
            else
            {
                MessageBox.Show("Letter is not in the word");
            }
            playerGuess.Text = "";
        }
        private void setScore()
        {
            game.randomPrize();

            switch(game.currentPrize)
            {
                case 350:
                    scoreBox.Image = AssignmentTwo.Properties.Resources._350;
                    break;
                 case 500:
                    scoreBox.Image = AssignmentTwo.Properties.Resources._500;
                    break;
                case 700:
                    scoreBox.Image = AssignmentTwo.Properties.Resources._700;
                    break;
                 case 1000:
                    scoreBox.Image = AssignmentTwo.Properties.Resources._1000;
                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }    
        }

    }
}
