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
    public partial class Form1 : Form
    {
        private int totalSeconds;
        private int totalScore = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.btnStopTimer.Enabled = false;
            this.label2.Visible = false;

            // Populating minute and second comboboxes with numbers
            for(int i = 0; i < 4; i++)
            {
                this.comboBox1.Items.Add(i.ToString());
            }
            
            for(int i = 0; i< 60; i++)
            {
                this.comboBox2.Items.Add(i.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Random character generator made to mimic the 20-sided die
             * used in Scattergories.
             * 
             * The die excludes the letters:
             * Q, U, V, X, Y, and Z
             */
            char[] chars = "ABCDEFGHIJKLMNOPRST".ToCharArray();
            Random r = new Random();
            int i = r.Next(chars.Length);
            label1.Text = chars[i].ToString();
            label1.Visible = true;
        }
        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            this.btnStartTimer.Enabled = false;
            this.btnStopTimer.Enabled = true;

            int minutes = int.Parse(this.comboBox1.SelectedIndex.ToString());
            int seconds = int.Parse(this.comboBox2.SelectedIndex.ToString());

            totalSeconds = (minutes * 60) + seconds;

            this.timer1.Enabled = true;
            this.label2.Visible = true;
        }

        private void btnStopTimer_Click(object sender, EventArgs e)
        {
            this.btnStopTimer.Enabled = false;
            this.btnStartTimer.Enabled = true;
            this.label2.Visible = false;

            totalSeconds = 0;
            this.timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(totalSeconds > 0)
            {
                totalSeconds--;
                int minutes = totalSeconds / 60;
                int seconds = totalSeconds - (minutes * 60);
                this.label2.Text = minutes.ToString() + ":" + seconds.ToString();
            }
            else
            {
                this.timer1.Stop();
                MessageBox.Show("Time's Up!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int score = totalScore;
            string str1 = tbCategory1.Text;
            string res1 = str1.Substring(0, 1);

            if(String.Equals(res1, label1.Text))
            {
                score++;
            }
            
            string str2 = tbCategory2.Text;
            string res2 = str2.Substring(0, 1);

            if(String.Equals(res2, label1.Text))
            {
                score++;
            }

            MessageBox.Show("Your score is " + score + " !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartScreen ss = new StartScreen(); // This is bad
            ss.Show();
            this.Hide();
        }
    }
}
