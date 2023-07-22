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
    public partial class SecondRoundPlayerTwo : Form
    {
        // this is the form for when the game has 2 rounds and 2 players and it is the second round and player two's turn
        public int numOfPlayers;
        public string PlayerOne;
        public string pOneAnswerOne;
        public string pOneAnswerTwo;
        public string pOneAnswerThree;
        public string pOneAnswerFour;
        public string pOneAnswerFive;
        public string pOneAnswerSix;
        public string PlayerTwo;
        public string promptone;
        public string prompttwo;
        public string promptthree;
        public string promptfour;
        public string promptfive;
        public string promptsix;
        public string RandLetter;
        public int numOfRounds;
        public int playerOneScore = 0;
        public int playerTwoScore = 0;
        private int timer;
        Player playerOneObj = new Player();
        Player playerTwoObj = new Player();



        public SecondRoundPlayerTwo()
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

        //get both player points from other form
        public void SetBothPlayerPoints(int points, int secondpoints)
        {
            playerOneObj.PlayerScore = points;
            playerTwoObj.PlayerScore = secondpoints;
        }

        //get player points from other form
        public void SetPlayerPoints(int points)
        {
            playerOneObj.PlayerScore = points;
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
            ScattegoriesMVC.addPlayer(PlayerOne);

        }

        // function to pass randomized letter to next form so playertwo can have same letter as player one
        public void SetRandomizedLetter(string randletter)
        {
            RandLetter = randletter;
        }

        //function to set propmts from first round to give same questions to second player
        public void SetSamePrompts(string promptOne, string promptTwo, string promptThree, string promptFour, string promptFive, string promptSix)
        {
            promptone = promptOne;
            prompttwo = promptTwo;
            promptthree = promptThree;
            promptfour = promptFour;
            promptfive = promptFive;
            promptsix = promptSix;
        }

        // have to pass in a player class to get the player name
        public void SetPlayerTwo(string player)
        {
            playerTwoObj.PlayerName = player.ToString();
            ScattegoriesMVC.addPlayer(PlayerTwo);

        }

        //function to get answers from player one from previous form
        public void SetPoneAnswers(string answerone, string answertwo, string answerthree, string answerfour, string answerfive, string answersix)
        {
            pOneAnswerOne = answerone;
            pOneAnswerTwo = answertwo;
            pOneAnswerThree = answerthree;
            pOneAnswerFour = answerfour;
            pOneAnswerFive = answerfive;
            pOneAnswerSix = answersix;
        }




        private void SecondRoundPlayerTwo_Load(object sender, EventArgs e)
        {
            // what round it is label 
            label8.Text = "Round 2/" + numOfRounds;
            //label1.Text = sg.Timer.ToString();
            MessageBox.Show("The number of players is " + numOfPlayers);

            // displaying whose turn it is 
            lblHeader.Text = "Player " + playerTwoObj.PlayerName + "'s Turn";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;

            // displaying the prompt fro mprevious form to the labels on screen
            label2.Text = promptone;
            label3.Text = prompttwo;
            label4.Text = promptthree;
            label5.Text = promptfour;
            label6.Text = promptfive;
            label7.Text = promptsix;


            // displaying random letter value
            lblLetter.Text = RandLetter;

            txtBoxAnswerOne.Focus();

            // Enable timer
            // this.timer1.Enabled = true;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {  
            // get player two points without player one answers which would be passed into the next function below
            int playerPoints = ScattegoriesMVC.CountPoints(playerTwoObj, lblLetter.Text, txtBoxAnswerOne.Text.ToLower(), txtBoxAnswerTwo.Text.ToLower(), txtBoxAnswer3.Text.ToLower(), txtBoxAnswer4.Text.ToLower(), txtBoxAnswerFive.Text.ToLower(), txtBoxAnswer6.Text.ToLower());
            
            //calling function to count the points for playerTwo answers with player one answer comparison
            int playertwopoints = ScattegoriesMVC.CountPtwoPointsWithPlayerOneAnswer(playerOneObj, playerTwoObj, playerOneObj.PlayerScore, playerPoints, lblLetter.Text, pOneAnswerOne, pOneAnswerTwo, pOneAnswerThree, pOneAnswerFour, pOneAnswerFive, pOneAnswerSix, txtBoxAnswerOne.Text, txtBoxAnswerTwo.Text, txtBoxAnswer3.Text, txtBoxAnswer4.Text, txtBoxAnswerFive.Text, txtBoxAnswer6.Text);

            // assigning and adding playertwo pointsto the player two object score
            playerTwoObj.PlayerScore += playertwopoints;
            

            // calling my function to store the score of player to leaderboard
            ScattegoriesMVC.addScoreToLeaderBoard(playerTwoObj.PlayerScore, playerTwoObj.PlayerName);
            ScattegoriesMVC.addScoreToLeaderBoard(playerOneObj.PlayerScore, playerOneObj.PlayerName);

            // in the event player one has a higher score display this message
            if (playerOneObj.PlayerScore > playerTwoObj.PlayerScore)
            {
                MessageBox.Show(playerOneObj.PlayerName + " recieved a score of " + playerOneObj.PlayerScore + "," + playerTwoObj.PlayerName + " recieved a score of " + playerTwoObj.PlayerScore + " " + " " + playerOneObj.PlayerName + " Wins! Play Again button to Play again");

            }
            // in the event player to has a higher score display this message

            else if (playerOneObj.PlayerScore < playerTwoObj.PlayerScore)
            {
                MessageBox.Show(playerOneObj.PlayerName + " recieved a score of " + playerOneObj.PlayerScore + "," + playerTwoObj.PlayerName + " recieved a score of " + playerTwoObj.PlayerScore + " " +  playerTwoObj.PlayerName + " Wins! Press Play Again button to Play again");

            }
            // in the event of a tie, display this message
            else
            {
                MessageBox.Show(playerOneObj.PlayerName + " recieved a score of " + playerOneObj.PlayerScore + "," + playerTwoObj.PlayerName + " recieved a score of " + playerTwoObj.PlayerScore + " It's a tie! Press Play Again button to Play again");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLeaderBoards_Click(object sender, EventArgs e)
        {
            //going to the leaderboards form
            LeaderBoards f1 = new LeaderBoards();
            f1.ShowDialog();
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
