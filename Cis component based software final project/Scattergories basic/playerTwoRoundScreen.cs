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
    public partial class playerTwoRoundScreen : Form
    {
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


        public playerTwoRoundScreen()
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
        public void SetRandomizedLetter ( string randletter)
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




        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (numOfRounds == 1 && numOfPlayers == 1 || numOfPlayers == 2)
            {
                // calling function to count player two points 
                int playerpoints = ScattegoriesMVC.CountPoints(playerTwoObj, lblLetter.Text, txtBoxAnswerOne.Text.ToLower(), txtBoxAnswerTwo.Text.ToLower(), txtBoxAnswer3.Text.ToLower(), txtBoxAnswer4.Text.ToLower(), txtBoxAnswerFive.Text.ToLower(), txtBoxAnswer6.Text.ToLower());
                //calling function to count the points for playerTwo answers with comparison to player one answers
                int playertwopoints = ScattegoriesMVC.CountPtwoPointsWithPlayerOneAnswer(playerOneObj, playerTwoObj, playerOneObj.PlayerScore, playerpoints, lblLetter.Text, pOneAnswerOne, pOneAnswerTwo, pOneAnswerThree, pOneAnswerFour, pOneAnswerFive, pOneAnswerSix, txtBoxAnswerOne.Text, txtBoxAnswerTwo.Text, txtBoxAnswer3.Text, txtBoxAnswer4.Text, txtBoxAnswerFive.Text, txtBoxAnswer6.Text);

                // assign playertwo points to the player two object score
                playerTwoObj.PlayerScore = playertwopoints;


                

                // calling my function to store the score of player to leaderboard
                ScattegoriesMVC.addScoreToLeaderBoard(playerTwoObj.PlayerScore, playerTwoObj.PlayerName);
                ScattegoriesMVC.addScoreToLeaderBoard(playerOneObj.PlayerScore, playerOneObj.PlayerName);

                // only display if rounds = 1 and num of players = 2
                if (numOfRounds == 1 && numOfPlayers == 2)
                {

                    // in the event player one has a higher score display this message
                    if (playerOneObj.PlayerScore > playerTwoObj.PlayerScore)
                    {
                        MessageBox.Show(playerOneObj.PlayerName + " recieved a score of " + playerOneObj.PlayerScore + "," + playerTwoObj.PlayerName + " recieved a score of " + playerTwoObj.PlayerScore + " " + " " + playerOneObj.PlayerName + ". Wins! Press Play Again button to Play again or press the Show LeaderBoards button to see your score and others!");

                    }
                    // in the event player to has a higher score display this message
                    else if (playerOneObj.PlayerScore < playerTwoObj.PlayerScore)
                    {
                        MessageBox.Show(playerOneObj.PlayerName + " recieved a score of " + playerOneObj.PlayerScore + "," + playerTwoObj.PlayerName + " recieved a score of " + playerTwoObj.PlayerScore + " " + playerTwoObj.PlayerName + ". Wins! Press Play Again button to Play again or press the Show LeaderBoards button to see your score and others!");

                    }

                    // in the event of a tie, display this message
                    else
                    {
                        MessageBox.Show(playerOneObj.PlayerName + " recieved a score of " + playerOneObj.PlayerScore + "," + playerTwoObj.PlayerName + " recieved a score of " + playerTwoObj.PlayerScore + " It's a tie! Press Play Again button to Play again or press the Show LeaderBoards button to see your score and others!");
                    }
                }
            }

            // go to second round form if num of rounds = 2 and num of players = 2 
            if (numOfRounds == 2 && numOfPlayers == 2)
            {
                
                this.Hide();
                SecondRoundPlayerOne f4 = new SecondRoundPlayerOne();
                // pass in the number of players, time, and number of rounds to next form
                f4.setPlayersRoundsTimer(numOfPlayers, numOfRounds, timer);
                // pass i nthe player one object to next form
                f4.SetPlayerOneclass(playerOneObj);
                // pass in the player one name to the next form
                f4.SetPlayerOne(playerOneObj.PlayerName);
                // pass in the prompts from this form to the next form
                f4.SetSamePrompts(label2.Text, label3.Text, label4.Text, label5.Text, label6.Text, label7.Text);
                // pass in the player two object to next form
                f4.SetPlayerTwoclass(playerTwoObj);
                // pass in player one score and player two score to use them in the next form
                f4.SetBothPlayerPoints(playerOneObj.PlayerScore, playerTwoObj.PlayerScore);
                // pass in player two name to the next form
                f4.SetPlayerTwo(playerTwoObj.PlayerName);
                // pass in player one points to the next form
                f4.SetPlayerPoints(playerOneObj.PlayerScore);
                // pass in player one's answers to next form for comparison 
                f4.SetPoneAnswers(txtBoxAnswerOne.Text.ToLower(), txtBoxAnswerTwo.Text.ToLower(), txtBoxAnswer3.Text.ToLower(), txtBoxAnswer4.Text.ToLower(), txtBoxAnswerFive.Text.ToLower(), txtBoxAnswer6.Text.ToLower());
                f4.ShowDialog();
            }
        }

        private void playerTwoRoundScreen_Load(object sender, EventArgs e)
        {
            // number of rounds label
            label8.Text = "Round 1/" + numOfRounds;
            //label1.Text = sg.Timer.ToString();
            MessageBox.Show("It's " + playerTwoObj.PlayerName + "'s" + " Turn. Press ok to start");

            // displaying the header of who's turn it is 
            lblHeader.Text = "Player " + playerTwoObj.PlayerName + "'s Turn";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;

            // setting the prompts to the textbox on screen
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

        private void btnLeaderBoards_Click(object sender, EventArgs e)
        {
            // going to the leaderboards form
            LeaderBoards f1 = new LeaderBoards();
            f1.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            // go to the start screen to play the game again
            this.Hide();
            StartScreen f6 = new StartScreen();
            f6.ShowDialog();
            
        }
    }
}
