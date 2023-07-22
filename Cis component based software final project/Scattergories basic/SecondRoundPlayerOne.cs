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
    public partial class SecondRoundPlayerOne : Form
    {

        // this is the form for when the game has 2 rounds and 2 players and it is the second round and player one's turn
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


        public SecondRoundPlayerOne()
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
        //public void SetRandomizedLetter(string randletter)
        //{
        //    RandLetter = randletter;
        //}

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



        private void SecondRoundPlayerOne_Load(object sender, EventArgs e)
        {
            // displaying what round it is label
            label8.Text = "Round 2/" + numOfRounds;
            //label1.Text = sg.Timer.ToString();
            MessageBox.Show("The number of players is " + numOfPlayers);

            // displaying whose turn it is 
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
            // this.timer1.Enabled = true;


        }

        private void btnLeaderBoards_Click(object sender, EventArgs e)
        {
            //going to the leaderboards from
            LeaderBoards f1 = new LeaderBoards();
            f1.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //exiting out program
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Hide();
            // getting the points for player one
            int playerPoints = ScattegoriesMVC.CountPoints(playerOneObj, lblLetter.Text, txtBoxAnswerOne.Text.ToLower(), txtBoxAnswerTwo.Text.ToLower(), txtBoxAnswer3.Text.ToLower(), txtBoxAnswer4.Text.ToLower(), txtBoxAnswerFive.Text.ToLower(), txtBoxAnswer6.Text.ToLower());
           //assigning and adding the playerpoints to player one object score
            playerOneObj.PlayerScore += playerPoints;

            MessageBox.Show("You Recieved a Score of " + playerOneObj.PlayerScore);

            //calling the next form to display
            SecondRoundPlayerTwo f5 = new SecondRoundPlayerTwo();

            //passing the number of players, number of rounds, and timer to next form
            f5.setPlayersRoundsTimer(numOfPlayers, numOfRounds, timer);
            // passing the playerone object to the next form
            f5.SetPlayerOneclass(playerOneObj);
            // passing the player one class to the next form
            f5.SetPlayerOne(playerOneObj.PlayerName);
            // passing the prompt from this form to the next form
            f5.SetSamePrompts(label2.Text, label3.Text, label4.Text, label5.Text, label6.Text, label7.Text);
            //passing the player two class object to the next form
            f5.SetPlayerTwoclass(playerTwoObj);
            //passing the player two name to the next form
            f5.SetPlayerTwo(playerTwoObj.PlayerName);
            //passing the random letter that was generated to the next form to use
            f5.SetRandomizedLetter(lblLetter.Text);
            // passing the player one object score to the next form
            f5.SetPlayerPoints(playerOneObj.PlayerScore);
            // passing the player one answer's to the next form
            f5.SetPoneAnswers(txtBoxAnswerOne.Text.ToLower(), txtBoxAnswerTwo.Text.ToLower(), txtBoxAnswer3.Text.ToLower(), txtBoxAnswer4.Text.ToLower(), txtBoxAnswerFive.Text.ToLower(), txtBoxAnswer6.Text.ToLower());
            f5.ShowDialog();
        }
    }
}
