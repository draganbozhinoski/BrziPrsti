using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrziPrsti
{
    public partial class Leaderboard : Form
    {
        public List<UserScore> scores1 = new List<UserScore>();
        public int MyProperty { get; set; }
        public int numScores { get; set; }
        SaveLoadData saveLoad = new SaveLoadData();

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
            scores1 = saveLoad.GetData();
            List<UserScore> sorted = scores1.OrderBy(m => m.wpm * m.accuracy).ToList();
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
