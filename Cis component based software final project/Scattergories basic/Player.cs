using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scattergories_basic
{
    class Player
    {
        string playerName;
        string Answerone;
        string Answertwo;
        string Answerthree;
        string Answerfour;
        string Answerfive;
        string Answersix;
        int playerScore;


        // Empty constructor
        public Player() { }

        // Custom Constructor
        public Player(string PlayerName, int PlayerScore, string answerOne, string answerTwo, string answerThree, string answerFour, string answerFive, string answerSix)
        {
            this.playerName = PlayerName;
            this.playerScore = PlayerScore;
            this.Answerone = answerOne;
            this.Answertwo = answerTwo;
            this.Answerthree = answerThree;
            this.Answerfour = answerFour;
            this.Answerfive = answerFive;
            this.Answersix = answerSix;
        }

        public int PlayerScore { get; set; }

        public string PlayerName { get; set; }
        public string answerOne { get; set; }
        public string answerTwo { get; set; }
        public string answerThree { get; set; }
        public string answerFour { get; set; }
        public string answerFive { get; set; }
        public string answerSix { get; set; }

    }
}
