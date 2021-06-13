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
    public partial class Form1 : Form
    {
        List<UserScore> scores;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Marathon game = new Marathon(textBox1.Text);
                game.ShowDialog();
            }
            else
            {
                MessageBox.Show("Enter username!");
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                TimedRace game = new TimedRace(textBox1.Text);
                game.ShowDialog();
            }
            else
            {
                MessageBox.Show("Enter username!");
                textBox1.Focus();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
