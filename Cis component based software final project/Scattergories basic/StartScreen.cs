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
    public partial class StartScreen : Form
    {
        Scattergories sg = new Scattergories();
        private int totalSeconds;
        
        public StartScreen()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // TO DO

            // Store number of players, number of rounds, and the timer duration into their proper classes to be transferred to another form
            sg.NumOfPlayers = ScattegoriesMVC.NumberOfPlayers(cbPlayers.SelectedItem);
            sg.NumOfRounds = ScattegoriesMVC.NumberOfRounds(cbRounds.SelectedItem);
            sg.Timer = ScattegoriesMVC.TimeSeconds(cbTimer.SelectedItem);

            int minutes = int.Parse(this.cbTimer.SelectedIndex.ToString());
            totalSeconds = (minutes * 60);


            MessageBox.Show("A game is starting with " + sg.NumOfPlayers + " players!" +
                "\n" + sg.NumOfRounds + " rounds" +
                "\nIt will last " + sg.Timer + " seconds", "Starting Game");


            // create a player class to store player one name
            Player playerOne = new Player();
            playerOne.PlayerName = txtBoxPlayerOneName.Text;
            

            // create player class to store playe two name
            Player playerTwo = new Player();
            playerTwo.PlayerName = txtBoxPlayerTwoName.Text;
            


            // Switch to new form
            GameScreen gs = new GameScreen();
            gs.SetPlayerOneclass(playerOne); // pass over playerone class to second form 
            gs.SetPlayerTwoclass(playerTwo); // pass over playertwo class to second form
            gs.SetPlayerOne(playerOne.PlayerName); // function to set playername to next form
            gs.SetPlayerTwo(playerTwo.PlayerName); // function to set playername to next form
            gs.setPlayersRoundsTimer(sg.NumOfPlayers, sg.NumOfRounds, sg.Timer); // fucntion to set num of players rounds and time to next form
            gs.ShowDialog();
            this.Hide();

           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //exiting out the program
            this.Close();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            //showing the rules of the game
            MessageBox.Show("Rules of the Game:" + "Choose how many players are playing " + "If two players are playing then player one and player two " + " will put their name in the textbox." + " Choose how many rounds" + " you will play. Then choose the " + " time you want"
                + "Once you click start, a random letter will be generated and depending on the letter you get you will have to give an answer to each of the prompt on the screen and your answer must start with the letter that was randomly generated. A player earns points if the other player answer doesn't match." + 
                "The player at the end with the most points win");
        }

        private void txtBoxPlayerTwoName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLeaderBoards_Click(object sender, EventArgs e)
        {
            LeaderBoards f1 = new LeaderBoards();
            f1.ShowDialog();

        }

        private void cbTimer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
