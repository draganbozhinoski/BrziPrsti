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
    public partial class Form1 : Form
    {
        SaveLoadData saveLoad = new SaveLoadData();
        public List<UserScore> users = new List<UserScore>();
        public Form1()
        {
            InitializeComponent();
            users = saveLoad.GetData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Game1 game = new Game1(textBox1.Text,users);
                game.ShowDialog();
            }
            else
            {
                MessageBox.Show("Enter username!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Game game = new Game(textBox1.Text,users);
                game.ShowDialog();
            }
            else
            {
                MessageBox.Show("Enter username!");
            }
        }
    }
}
