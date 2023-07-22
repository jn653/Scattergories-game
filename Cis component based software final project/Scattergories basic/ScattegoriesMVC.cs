using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scattergories_basic
{
    class ScattegoriesMVC
    {

        // function to get the number of players 
        public static int NumberOfPlayers(object comboBoxItem)
        {
            int numofPlayers = int.Parse(comboBoxItem.ToString());

            return numofPlayers;
        }

        //function to get the number of rounds 
        public static int NumberOfRounds(object comboBoxItem)
        {
            int numofRounds = int.Parse(comboBoxItem.ToString());

            return numofRounds;
        }

        // function to get the time for the timer
        public static int TimeSeconds(object comboBoxItem)
        {

            int totalSeconds = (int.Parse(comboBoxItem.ToString()) * 60);

            return totalSeconds;
        }

        // function to randomly generate a letter
        public static string GenerateRandLetter()
        {
            char[] chars = "abcdefghijklmnoprst".ToCharArray();
            Random r = new Random();
            int i = r.Next(chars.Length);
            return chars[i].ToString();
        }

        // function to get the questions from the database that will be used to set the prompts
        public static DataSet GetDataSet()
        {
            OleDbConnection myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=ScattegoriesQuestionsDatabase.accdb;");
            string strSQL = "SELECT * FROM ScattegoriesQuestionTable";
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            DataSet questionDataSet = new DataSet("QuestionTable");
            myDataAdapter.Fill(questionDataSet, "QuestionTable");

            return questionDataSet;
        }

        // function that sets prompts to the screen
        public static string SetPrompts()
        {
            // using another function to get the prompts from the database and assinging to a string
            string prompt = ScattegoriesMVC.GetDataSet().Tables["QuestionTable"].Rows[RandNumGenerator()]["Questions"].ToString();
            return prompt;

        }


        //function to display random number
        public static int RandNumGenerator()
        {
            Random rnd = new Random();
            int num = rnd.Next(38);
            return num;
        }

        // function to get the info from the databse to display as leaderboard
        public static DataTable ShowLeaderBoard()
        {
            OleDbConnection myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=PlayerInfoDatabase.accdb;");
            string strSQL = "SELECT * FROM PlayerInfoTable";
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            DataSet playerDataSet = new DataSet("PlayerTable");
            myDataAdapter.Fill(playerDataSet, "PlayerTable");

            // add my table value to the data grid view
            DataTable LeaderBoardTable = new DataTable();
            LeaderBoardTable = playerDataSet.Tables["PlayerTable"];

            return LeaderBoardTable;
        }


        // function to add player to the leaderboard
        public static string addPlayer(string player)
        {
            string strConnection = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=PlayerInfoDatabase.accdb;";
            string strSQL = $"insert into PlayerInfoTable (PlayerName) VALUES ('{player}')";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand insertCommand = new OleDbCommand(strSQL, myConnection);

            try
            {

                myConnection.Open();
                insertCommand.ExecuteNonQuery();


            }
            catch (OleDbException ex)
            {
                MessageBox.Show("error" + ex);
            }
            catch (SystemException ex)
            {
                MessageBox.Show("erorr" + ex);
            }

            finally
            {

                myConnection.Close();
            }
            return "it worked";
        }

        // function to add the player's score to the leaderboard
        public static string addScoreToLeaderBoard(int playerScore, string playername)
        {
            string strConnection = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=PlayerInfoDatabase.accdb;";
            string strSQL = "Update PlayerInfoTable SET PlayerScore ='" + playerScore + "'" +
                               "WHERE PlayerName='" + playername + "'";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand modifyCommand = new OleDbCommand(strSQL, myConnection);


            try
            {

                myConnection.Open();
                modifyCommand.ExecuteNonQuery();


            }
            catch (OleDbException ex)
            {
                MessageBox.Show("error" + ex);
            }
            catch (SystemException ex)
            {
                MessageBox.Show("erorr" + ex);
            }

            finally
            {

                myConnection.Close();
            }
            return "it worked";
        }

        // function to count up the points
        public static int CountPoints(object player, string randLetter, string answerone, string answertwo, string answerthree, string answerfour, string answerfive, string answersix)
        {
            Player playerObj;
            playerObj = (Player)player;
            int playerScore = 0;
            string letter = randLetter;

            if (answerone != null && answerone.StartsWith(letter))
            {
                playerScore++;
            }
            playerObj.PlayerScore = playerScore;

            // playerOneScore = playerOneScore;

            if (answertwo != null && answertwo.StartsWith(letter))
            {
                playerScore++;
            }
            playerObj.PlayerScore = playerScore;


            if (answerthree != null && answerthree.StartsWith(letter))
            {
                playerScore++;
            }

            playerObj.PlayerScore = playerScore;

            if (answerfour != null && answerfour.StartsWith(letter))
            {
                playerScore++;
            }

            playerObj.PlayerScore = playerScore;

            if (answerfive != null && answerfive.StartsWith(letter))
            {
                playerScore++;
            }

            playerObj.PlayerScore = playerScore;


            if (answersix != null && answersix.StartsWith(letter))
            {
                playerScore++;

            }

            playerObj.PlayerScore = playerScore;


            return playerScore;

        }


        //function to count player two's points, I have to change it so that the other function for player on accepts the playerone score
        public static int CountPtwoPointsWithPlayerOneAnswer(object playerone, object playertwo, int playeronePoints, int playertwoPoints, string randLetter, string p1answerone, string p1answertwo, string p1answerthree, string p1answerfour, string p1answerfive, string p1answersix, string p2answerone, string p2answertwo, string p2answerthree, string p2answerfour, string p2answerfive, string p2answersix)

        {
            Player playerObj;
            playerObj = (Player)playerone;
            Player playerObjtwo = (Player)playertwo;
            int playeroneScore = playeronePoints;
            int playertwoScore = playertwoPoints;
            string letter = randLetter;


            if (p2answerone != null && p2answerone.StartsWith(letter) && p2answerone.Equals(p1answerone) == false)
            {

                playertwoScore = playertwoScore;

            }
            else if (p2answerone != null && p2answerone.StartsWith(letter) && p2answerone.Equals(p1answerone) == true)

            {
                playertwoScore--;
                playeroneScore--;
            }

            playerObjtwo.PlayerScore = playertwoScore;
            playerObj.PlayerScore = playeroneScore;



            if (p2answertwo != null && p2answertwo.StartsWith(letter) && p2answertwo.Equals(p1answertwo) == false)
            {

                playertwoScore = playertwoScore;
            }
            else if (p2answertwo != null && p2answertwo.StartsWith(letter) && p2answertwo.Equals(p1answertwo) == true)

            {

                playertwoScore--;
                playeroneScore--;
            }

            playerObjtwo.PlayerScore = playertwoScore;
            playerObj.PlayerScore = playeroneScore;

            if (p2answerthree != null && p2answerthree.StartsWith(letter) && p2answerthree.Equals(p1answerthree) == false)
            {

                playertwoScore = playertwoScore;
            }
            else if (p2answerthree != null && p2answerthree.StartsWith(letter) && p2answerthree.Equals(p1answerthree) == true)
            {
                playeroneScore--;
                playertwoScore--;
            }

            playerObjtwo.PlayerScore = playertwoScore;
            playerObj.PlayerScore = playeroneScore;

            if (p2answerfour != null && p2answerfour.StartsWith(letter) && p2answerfour.Equals(p1answerfour) == false)
            {

                playertwoScore = playertwoScore;
            }
            else if (p2answerfour != null && p2answerfour.StartsWith(letter) && p2answerfour.Equals(p1answerfour) == true)
            {
                playeroneScore--;
                playertwoScore--;
            }

            playerObjtwo.PlayerScore = playertwoScore;
            playerObj.PlayerScore = playeroneScore;

            if (p2answerfive != null && p2answerfive.StartsWith(letter) && p2answerfive.Equals(p1answerfive) == false)
            {

                playertwoScore = playertwoScore;
            }
            else if (p2answerfive != null && p2answerfive.StartsWith(letter) && p2answerfive.Equals(p1answerfive) == true)
            {
                playeroneScore--;
                playertwoScore--;
            }

            playerObjtwo.PlayerScore = playertwoScore;
            playerObj.PlayerScore = playeroneScore;


            if (p2answersix != null && p2answersix.StartsWith(letter) && p2answersix.Equals(p1answersix) == false)
            {

                playertwoScore = playertwoScore;

            }
            else if (p2answersix != null && p2answersix.StartsWith(letter) && p2answersix.Equals(p1answersix) == true)
            {
                playeroneScore--;
                playertwoScore--;
            }

            playerObjtwo.PlayerScore = playertwoScore;
            playerObj.PlayerScore = playeroneScore;


            return playertwoScore;

        }

    }


        

       
}
