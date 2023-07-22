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
    public partial class SecondRoundScreen : Form
    {
        private int numOfPlayers;
        private string player;
        private int numOfRounds;
        private int timer;
        int currentPlayer = 1;
        int totalSeconds;
        public string PlayerOne;
        Player playerOneObj = new Player();
        



        public SecondRoundScreen()
        {
            InitializeComponent();
        }

        //setting the round and time and players
        public void setPlayersRoundsTimerRoundTwo(int NumOfPlayers, int NumOfRounds, int Timer)
        {
            numOfPlayers = NumOfPlayers;
            numOfRounds = NumOfRounds;
            timer = Timer;
        }

        //get player points from other form
        public void SetPlayerPoints(int points)
        {
            playerOneObj.PlayerScore = points;
        }



        // get the player class object from first form
        public void SetPlayerOneclass(object player)
        {
            playerOneObj = (Player)player;
        }

        //get player name
        public void SetPlayerOne(string player)
        {
            playerOneObj.PlayerName = player.ToString();
            ScattegoriesMVC.addPlayer(PlayerOne);

        }



        private void SecondRoundScreen_Load(object sender, EventArgs e)
        {
            // what round it is label
            label8.Text = "Round 2/" + numOfRounds;
            //label1.Text = sg.Timer.ToString();
            MessageBox.Show("The second round is about to start! " + playerOneObj.PlayerName + " Click ok to start the second round");
           // MessageBox.Show("The number of players is " + numOfPlayers);

            // displaying whose turn it is 
            lblHeader.Text = "Player " + playerOneObj.PlayerName + "'s Turn";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;


            //using the function setprompts to set the prompts to the labels on the screen
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
           

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // setting up the timer for the screen 
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
            
        }

        private void btnLeaderBoards_Click_1(object sender, EventArgs e)
        {
            // going to the leaderboards form
            LeaderBoards f1 = new LeaderBoards();
            f1.ShowDialog();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            // exiting out the program
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            //calling function to count the pointss for the player answers
            int playerPoints = ScattegoriesMVC.CountPoints(playerOneObj, lblLetter.Text, txtBoxAnswerOne.Text.ToLower(), txtBoxAnswerTwo.Text.ToLower(), txtBoxAnswer3.Text.ToLower(), txtBoxAnswer4.Text.ToLower(), txtBoxAnswerFive.Text.ToLower(), txtBoxAnswer6.Text.ToLower());
           
            // assigning the playerPoints to player one obj score
            playerOneObj.PlayerScore += playerPoints;

            // calling my function to store the score of player to leaderboard
            ScattegoriesMVC.addScoreToLeaderBoard(playerOneObj.PlayerScore, playerOneObj.PlayerName);

            MessageBox.Show("You Recieved a Score of " + playerOneObj.PlayerScore + " Press the Play Again button to Play Again or press the Show LeaderBoards button to see your score and others! ");
            
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }
    }
}
