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
    public partial class Game : Form
    {
        private List<string> rechenice;
        private List<UserScore> scores { get; set; }
        private UserScore score { get; set; }
        private string userName { get; set; }
        private int guessedWords;
        private string textZaPogoduvanje;
        private int start;
        private int seconds;
        private float wpm;
        private float accuracy;
        private int numLetters, wrongLetters;
        private bool generated;
        public Game(string userName)
        {
            InitializeComponent();
            scores = new List<UserScore>();
            score = new UserScore();
            score.userName = userName;
            scores.Add(score);
            rechenice = new List<string>() { 
            "onlytesting",
            "Can you feel the sunshine? Does it brighten up your day? Don't you feel that sometimes you just need to run away? Reach out for the sunshine, forget about the rain. Just think about the good times and they will come back again.",
            "You gotta see it to believe it, the sky never looked so blue it's so hard to leave it, but that's what I always do. So I keep thinking back to a time under the canyon moon.",
            "So what did I do for this honour, you are asking? Well, perhaps the fact that he asked me to read his book, and write a ‘postface’ assessment both of his writing and of the issues he covers, and the fact that I said yes, has something to do with it. He says some blushmakingly kind things in his ‘preface to the postface’, which I will have to leave to French readers of the whole thing (published by Plon).",
            "Close your eyes in the night and I'll be right in front of you. So sit back, enjoy the view until the morning. When the sun comes from the west, that's where you'll find my silhouette. I'll ride a cloud, come back to you without a warning. So don't speak, 'cause it only makes my heart bleed. No matter what you say, I'll be only just a call away.",
            "Just take my hand, lead, dance with me...and I will simply follow the blueness of the water, the white waves rolling free...where the earth beneath my feet and stars make my heart whole again...in long and priceless moments of shared solitude...",
            "You don't need money, don't take fame. Don't need no credit card to ride this train. It's strong and it's sudden and it's cruel sometimes, but it might just save your life. That's the power of love.",
            "All I'm asking is that you do the minimal amount of work in this class to give yourself the illusion that you're actually learning something, and to give me a modicum of self respect like I'm actually teaching a class.",
            "In the late 1960s, a growing number of people became concerned about the growing problems of pollution and the destruction of natural habitats. This movement led to the formation of groups like the Environmental Protection Agency (EPA). The primary goal of the environmental movement as a whole is to make sure that the environment is safe and intact for future generations to enjoy.",
            "Jacques Seguela writes about political campaigns and communications not merely as an expert analyst, but as an experienced practitioner. Hence his latest book contains both insights worth heeding, but also enlivening tales of his own experience. He is observer and participant; outsider looking in, and insider looking out.  There is much to look at, not least in France with a Presidential election looming, and the outcome far from easy to predict.",
            "If Lula is a star of this book, so too is Barack Obama. American elections are of enormous interest to all political campaign junkies, a category in which both Seguela and I would almost certainly qualify. Much is made of Obama's use of the internet, a relatively new phenomenon in historical terms and one the young Senator used brilliantly in his quest to become President. Yet though it was an accurate expression of his modernity, underpinning its use were some very old-fashioned campaign principles.",
            "You never should settle for the lifetime that is handed to you. There's always a line to be cut and someone to barrel through. And if you should find that you're about to get the short of the stick, take what you want, return what you get.",
            "I know just how to whisper and I know just how to cry. I know just where to find the answers and I know just how to lie. I know just how to fake it and I know just how to scheme. I know just when to face the truth and then I know just when to dream.",
            "If someone is able to show me that what I think or do is not right, I will happily change, for I seek the truth, by which no one was ever truly harmed. It is the person who continues in his self-deception and ignorance who is harmed.",
            "Opening your eyes is all that is needing. The heart lies and the head plays tricks with us, but the eyes see true. Look with your eyes. Hear with your ears. Taste with your mouth. Smell with your nose. Feel with your skin. Then comes the thinking, afterward, and in that way knowing the truth.",
            "The sooner your kids appreciate the value of work, the more successful they will be. Work is part of life. You work to earn money, put food on the table, and keep your homes orderly and clean. For your kids, work involves schoolwork, homework, and teamwork at home and in the community."
            };
            textZaPogoduvanje = "Hello, Hope you will check here :)";
            this.userName = userName;
            reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generate();
            generated = true;
        }
        private void reset()
        { 
            //boxes
            lblGuessed.Text = "";
            lblGeneratedWords.Text = "Click the button to generate words!";
            textBox1.Text = "Click the button to generate words!";
            wpmlbl.Text = "Your wpm: 0";
            lblAccuracy.Text = "Your accuracy: 100%";
            lblSeconds.Text = "60";
            // VALUES
            guessedWords = 0;
            start = 10;
            seconds = 60;
            pbMinuteTimer.Value = 60;
            wpm = 0;
            accuracy = 100;
            numLetters = 0;
            wrongLetters = 1;
            //TIMERS
            timerMinute.Stop();
            startTimer.Stop();
            //TB-buttons
            textBox1.ReadOnly = true;
            button1.Enabled = true;
            button2.Enabled = true;
            generated = false;
            lblSeconds.ForeColor = Color.Black;
            lblCount.ForeColor = Color.Black;
        }
        private void generate()
        {
            reset();
            Random rand = new Random();
            int a = rand.Next(0, rechenice.Count);
            textZaPogoduvanje = rechenice[a];
            numLetters = textZaPogoduvanje.Length;
            lblGeneratedWords.Text = textZaPogoduvanje;
            textBox1.Text = "Type the above text here when the race begins!";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "Type the above text here when the race begins!" && textBox1.Text != "Click the button to generate words!")
            {
                if (guessedWords == textZaPogoduvanje.Split().Length)
                {
                    score.userName = userName;
                    score.wpm = wpm;
                    score.accuracy = accuracy;
                    score.update(new UserScore(userName, accuracy, wpm));
                    if (wpm < 80)
                    {
                        float wpmm = wpm;
                        float acc = accuracy;
                        reset();
                        if (MessageBox.Show("Congrats, you finished early.\nWPM: " + wpmm.ToString() + "\nAccuracy: " + acc + "%\nNEW GAME?", "GOOD JOB!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            generate();
                        }
                        else
                        {
                            textBox1.ReadOnly = true;
                        }
                    }
                    else if (wpm > 100)
                    {
                        float wpmm = wpm;
                        float acc = accuracy;
                        reset();
                        if (MessageBox.Show("YOU ARE OCTOPUS! GOOD JOB!\nWPM: " + wpmm.ToString() + "\nAccuracy: "+acc+"%\nNEW GAME ?", "GOOD JOB!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            generate();
                        }
                        else
                        {
                            reset();
                            textBox1.ReadOnly = true;
                        }
                    }
                    else
                    {
                        float wpmm = wpm;
                        float acc = accuracy;
                        reset();
                        if (MessageBox.Show("Congrats, you are middle-range writer!\nWPM: " + wpmm.ToString() + "%\nAccuracy: "+acc+"\nNEW GAME?", "GOOD JOB!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            generate();
                        }
                        else
                        {
                            reset();
                            textBox1.ReadOnly = true;
                        }
                    }

                }
                else
                {
                    string proverka = textZaPogoduvanje.Split()[guessedWords] + " ";
                    if (textBox1.Text == proverka)
                    {
                        guessedWords += 1;
                        lblGuessed.Text += textBox1.Text + " ";
                        wpm = guessedWords / ((float)(60-seconds) / 60);
                        wpmlbl.Text = "Your wpm: "+wpm.ToString();
                        textBox1.Text = "";
                    }
                    else
                    {
                        if (!proverka.Contains(textBox1.Text))
                        {
                            lblGeneratedWords.ForeColor = Color.Red;
                            wrongLetters += 1;
                            accuracy = (((float) numLetters - wrongLetters/2 )/ numLetters); // deleno so 2 deka gi zema kako pogresni i na brisenje.
                            int acc = (int)accuracy*100;
                            lblAccuracy.Text = "Your accuracy: " + acc.ToString() + "%";
                        }
                        else
                        {
                            lblGeneratedWords.ForeColor = Color.Black;
                            int acc = (int)accuracy;
                            lblAccuracy.Text = "Your accuracy: " + acc.ToString() + "%";
                        }
                    }
                }
            }
        }

        private void startTimer_Tick(object sender, EventArgs e)
        {
            if(start > 0)
            {
                if (start > 6)
                    imgCrveno.Visible = true;
                else
                {
                    lblCount.ForeColor = Color.Yellow;
                    imgCrveno.Visible = false;
                    imgZholto.Visible = true;
                }
                start -= 1;
                lblCount.Text = start.ToString();
                if (start == 0)
                {
                    imgZholto.Visible = false;
                    imgZeleno.Visible = true;
                    lblCount.ForeColor = Color.Green;
                    lblCount.Text = "GO!";
                }
            }
            else if(start==0)
            {
                imgZeleno.Visible = false;
                lblCount.Text = "GO!";
                lblCount.Visible = false;
                textBox1.Text = "";
                textBox1.ReadOnly = false;
                timerMinute.Start();
                textBox1.Focus();
                start = -20;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!generated)
                generate();
            startTimer.Start();
            button1.Enabled = false;
            button2.Enabled = false;
            lblCount.Visible = true;
            imgCrveno.Visible = true;
        }

        private void lblGeneratedWords_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Leaderboard board = new Leaderboard();
            board.scores = scores;
            if(scores.Count > 0)
                MessageBox.Show(scores[0].userName);
            board.init();
            board.ShowDialog();
        }

        private void timerMinute_Tick(object sender, EventArgs e)
        {
            if (seconds > 0)
            {
                seconds -= 1;
                pbMinuteTimer.Value = seconds;
                lblSeconds.Text = seconds.ToString();
                if(seconds<11)
                {
                    lblSeconds.ForeColor = Color.Red;
                }
            }
            else if (seconds == 0)
            {
                seconds = -10;
                if (MessageBox.Show("You did not finish your game in time. Give me another try?", "I'm sorry!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    generate();
                }
                else
                {
                    reset();
                }
            }
        }
    }
}
