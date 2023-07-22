using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scattergories_basic
{
    public partial class GameScreen : Form
    {
        Scattergories sg = new Scattergories();
        /* With the currentPlayer variable, I'm hoping to signify what player's turn it currently is
         * I will increment this variable every time the submit button is pressed or the timer reaches 0 and
         * resets the board
         */
        public int numOfPlayers;
        public string PlayerOne;
        public string PlayerTwo;
        public int numOfRounds;
        public int playerOneScore = 0;
        public int playerTwoScore = 0;
        private int timer;
        Player playerOneObj = new Player();
        Player playerTwoObj = new Player();

        int currentPlayer = 1;
        int totalSeconds;
        public GameScreen()
        {
            InitializeComponent();
        }

        public void setPlayersRoundsTimer(int NumOfPlayers, int NumOfRounds, int Timer)
        {
            numOfPlayers = NumOfPlayers;
            numOfRounds = NumOfRounds;
            timer = Timer;
        }

        // get the player class object from first form
        public void SetPlayerOneclass(object player)
        {
            playerOneObj = (Player)player;
        }

        // get the player class object from first form
        public void SetPlayerTwoclass(object player)
        {
            playerTwoObj = (Player)player;
        }

        // have to pass in a player class to get the player name
        public void SetPlayerOne(string player)
        {
            playerOneObj.PlayerName = player.ToString();
            ScattegoriesMVC.addPlayer(playerOneObj.PlayerName);
            
        }

        // have to pass in a player class to get the player name
        public void SetPlayerTwo(string player)
        {
            playerTwoObj.PlayerName = player.ToString();
            ScattegoriesMVC.addPlayer(player.ToString());

        }



        private void GameScreen_Load(object sender, EventArgs e)
        {
            
                label8.Text = "Round 1/" + numOfRounds;
                //label1.Text = sg.Timer.ToString();

                // show the name of the player playing at top
                lblHeader.Text = "Player " + playerOneObj.PlayerName + "'s Turn";
                lblHeader.TextAlign = ContentAlignment.MiddleCenter;

                // setting all the prompts to the screen
                label2.Text = ScattegoriesMVC.SetPrompts();
                label3.Text = ScattegoriesMVC.SetPrompts();
                label4.Text = ScattegoriesMVC.SetPrompts();
                label5.Text = ScattegoriesMVC.SetPrompts();
                label6.Text = ScattegoriesMVC.SetPrompts();
                label7.Text = ScattegoriesMVC.SetPrompts();


             

                // displaying random letter value
                lblLetter.Text = ScattegoriesMVC.GenerateRandLetter();

                txtBoxAnswerOne.Focus();

                // Enable timer
                this.timer1.Enabled = true;
            

         


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            

            if (numOfRounds == 1 && numOfPlayers == 1)
            {
               // calling function to count points for player answer
                int playerPoints = ScattegoriesMVC.CountPoints(playerOneObj,lblLetter.Text, txtBoxAnswerOne.Text.ToLower(), txtBoxAnswerTwo.Text.ToLower(), txtBoxAnswer3.Text.ToLower(), txtBoxAnswer4.Text.ToLower(), txtBoxAnswerFive.Text.ToLower(), txtBoxAnswer6.Text.ToLower());
                playerOneObj.PlayerScore = playerPoints;

                //calling function to store points to leaderboard
                ScattegoriesMVC.addScoreToLeaderBoard(playerOneObj.PlayerScore, playerOneObj.PlayerName);
                MessageBox.Show("You Recieved a Score of " + playerOneObj.PlayerScore + ". Press Play Again button to play again or press the Show LeaderBoards button to see the score of others!");
            }

            if(numOfRounds == 2 && numOfPlayers == 1)
            {
                this.Hide();
                int playerPoints = ScattegoriesMVC.CountPoints(playerOneObj, lblLetter.Text, txtBoxAnswerOne.Text.ToLower(), txtBoxAnswerTwo.Text.ToLower(), txtBoxAnswer3.Text.ToLower(), txtBoxAnswer4.Text.ToLower(), txtBoxAnswerFive.Text.ToLower(), txtBoxAnswer6.Text.ToLower());
                playerOneObj.PlayerScore = playerPoints;

                //call form to display round 2 for player one and set the items from this form to that form
                SecondRoundScreen f2 = new SecondRoundScreen();
                f2.setPlayersRoundsTimerRoundTwo(numOfPlayers, numOfRounds, timer);
                f2.SetPlayerPoints(playerOneObj.PlayerScore);
                f2.SetPlayerOneclass(playerOneObj);
                f2.ShowDialog();
            }

            if(numOfRounds == 1 && numOfPlayers == 2)
            {
                this.Hide();
                int playerPoints = ScattegoriesMVC.CountPoints(playerOneObj, lblLetter.Text, txtBoxAnswerOne.Text.ToLower(), txtBoxAnswerTwo.Text.ToLower(), txtBoxAnswer3.Text.ToLower(), txtBoxAnswer4.Text.ToLower(), txtBoxAnswerFive.Text.ToLower(), txtBoxAnswer6.Text.ToLower());
                playerOneObj.PlayerScore = playerPoints;
                MessageBox.Show("You Recieved a Score of " + playerOneObj.PlayerScore);
                playerTwoRoundScreen f3 = new playerTwoRoundScreen();
                f3.setPlayersRoundsTimer(numOfPlayers, numOfRounds, timer);
                f3.SetPlayerOneclass(playerOneObj);
                f3.SetPlayerOne(playerOneObj.PlayerName);
                f3.SetSamePrompts(label2.Text, label3.Text, label4.Text, label5.Text, label6.Text, label7.Text);
                f3.SetPlayerTwoclass(playerTwoObj);
                f3.SetPlayerTwo(playerTwoObj.PlayerName);
                f3.SetRandomizedLetter(lblLetter.Text);
                f3.SetPlayerPoints(playerOneObj.PlayerScore);
                f3.SetPoneAnswers(txtBoxAnswerOne.Text.ToLower(), txtBoxAnswerTwo.Text.ToLower(), txtBoxAnswer3.Text.ToLower(), txtBoxAnswer4.Text.ToLower(), txtBoxAnswerFive.Text.ToLower(), txtBoxAnswer6.Text.ToLower());
                f3.ShowDialog();
            }

            if (numOfRounds == 2 && numOfPlayers == 2)
            {
                this.Hide();
                int playerPoints = ScattegoriesMVC.CountPoints(playerOneObj, lblLetter.Text, txtBoxAnswerOne.Text.ToLower(), txtBoxAnswerTwo.Text.ToLower(), txtBoxAnswer3.Text.ToLower(), txtBoxAnswer4.Text.ToLower(), txtBoxAnswerFive.Text.ToLower(), txtBoxAnswer6.Text.ToLower());
                playerOneObj.PlayerScore = playerPoints;
                MessageBox.Show("You Recieved a Score of " + playerOneObj.PlayerScore);
                playerTwoRoundScreen f3 = new playerTwoRoundScreen();
                f3.setPlayersRoundsTimer(numOfPlayers, numOfRounds, timer);
                f3.SetPlayerOneclass(playerOneObj);
                f3.SetPlayerOne(playerOneObj.PlayerName);
                f3.SetSamePrompts(label2.Text, label3.Text, label4.Text, label5.Text, label6.Text, label7.Text);
                f3.SetPlayerTwoclass(playerTwoObj);
                f3.SetPlayerTwo(playerTwoObj.PlayerName);
                f3.SetRandomizedLetter(lblLetter.Text);
                f3.SetPlayerPoints(playerOneObj.PlayerScore);
                f3.SetPoneAnswers(txtBoxAnswerOne.Text.ToLower(), txtBoxAnswerTwo.Text.ToLower(), txtBoxAnswer3.Text.ToLower(), txtBoxAnswer4.Text.ToLower(), txtBoxAnswerFive.Text.ToLower(), txtBoxAnswer6.Text.ToLower());
                f3.ShowDialog();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer > 0)
            {
                timer--;
                int minutes = timer / 60;
                int seconds = timer - (minutes * 60);
                this.label1.Text = minutes.ToString() + ":" + seconds.ToString();
            }
            else
            {
                this.timer1.Stop();
                MessageBox.Show("Time's Up!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLeaderBoards_Click(object sender, EventArgs e)
        {
            LeaderBoards f1 = new LeaderBoards();
            f1.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            //going back to start screen to play again
            this.Hide();
            StartScreen f6 = new StartScreen();
            f6.ShowDialog();
        }
    }
}
