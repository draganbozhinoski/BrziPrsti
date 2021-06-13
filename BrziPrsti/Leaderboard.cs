using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrziPrsti
{
    public partial class Leaderboard : Form
    {
        public List<UserScore> scores { get; set; }
        public int MyProperty { get; set; }
        public int numScores { get; set; }

        public Leaderboard()
        {
            InitializeComponent();
            numScores = 0;
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            
        }
        public void init()
        {
            List<UserScore> sorted = scores.OrderBy(m => m.wpm * m.accuracy).ToList();
            foreach(var score in sorted)
            {
                DataGridViewRow row = (DataGridViewRow) leaderGrid.Rows[0].Clone();
                row.Cells[0].Value = numScores++;
                row.Cells[1].Value = score.userName;
                row.Cells[2].Value = score.accuracy;
                row.Cells[3].Value = score.wpm;
                leaderGrid.Rows.Add(row);
            }
            
        }

        private void leaderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
