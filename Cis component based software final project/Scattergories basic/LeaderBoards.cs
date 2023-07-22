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
    public partial class LeaderBoards : Form
    {
        public LeaderBoards()
        {
            InitializeComponent();
        }

        private void LeaderBoards_Load(object sender, EventArgs e)
        {
            // use the function to show the items in the leaderboard to the datagrid view
            dataGridLeaderBoards.DataSource = ScattegoriesMVC.ShowLeaderBoard();
        }

        private void dataGridLeaderBoards_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
