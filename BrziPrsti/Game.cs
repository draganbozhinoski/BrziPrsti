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
        private int guessedWords;
        private string textZaPogoduvanje;
        private int start;
        private int seconds;
        private float wpm;
        public Game()
        {
            InitializeComponent();
            rechenice = new List<string>() { 
            "Can you feel the sunshine? Does it brighten up your day? Don't you feel that sometimes you just need to run away? Reach out for the sunshine, forget about the rain. Just think about the good times and they will come back again.",
            "You gotta see it to believe it, the sky never looked so blue it's so hard to leave it, but that's what I always do. So I keep thinking back to a time under the canyon moon.",
            "with as then they how they form become same good no high which again find govern run home present govern these do can want become off",
            "Close your eyes in the night and I'll be right in front of you. So sit back, enjoy the view until the morning. When the sun comes from the west, that's where you'll find my silhouette. I'll ride a cloud, come back to you without a warning. So don't speak, 'cause it only makes my heart bleed. No matter what you say, I'll be only just a call away.",
            "We're no strangers to love. You know the rules and so do I. A full commitment's what I'm thinkin' of. You wouldn't get this from any other guy.",
            "You don't need money, don't take fame. Don't need no credit card to ride this train. It's strong and it's sudden and it's cruel sometimes, but it might just save your life. That's the power of love.",
            "All I'm asking is that you do the minimal amount of work in this class to give yourself the illusion that you're actually learning something, and to give me a modicum of self respect like I'm actually teaching a class.",
            "In the late 1960s, a growing number of people became concerned about the growing problems of pollution and the destruction of natural habitats. This movement led to the formation of groups like the Environmental Protection Agency (EPA). The primary goal of the environmental movement as a whole is to make sure that the environment is safe and intact for future generations to enjoy.",
            "I want to be very small, and I want you to put me in your pocket, and I wanna stay there and you can just reach in whenever you want and just pat me on the head.",
            "Never imagine yourself not to be otherwise than what it might appear to others that what you were or might have been was not otherwise than what you had been would have appeared to them to be otherwise.",
            "You never should settle for the lifetime that is handed to you. There's always a line to be cut and someone to barrel through. And if you should find that you're about to get the short of the stick, take what you want, return what you get.",
            "I know just how to whisper and I know just how to cry. I know just where to find the answers and I know just how to lie. I know just how to fake it and I know just how to scheme. I know just when to face the truth and then I know just when to dream.",
            "If someone is able to show me that what I think or do is not right, I will happily change, for I seek the truth, by which no one was ever truly harmed. It is the person who continues in his self-deception and ignorance who is harmed.",
            "Opening your eyes is all that is needing. The heart lies and the head plays tricks with us, but the eyes see true. Look with your eyes. Hear with your ears. Taste with your mouth. Smell with your nose. Feel with your skin. Then comes the thinking, afterward, and in that way knowing the truth.",
            "The sooner your kids appreciate the value of work, the more successful they will be. Work is part of life. You work to earn money, put food on the table, and keep your homes orderly and clean. For your kids, work involves schoolwork, homework, and teamwork at home and in the community."
            };
            textZaPogoduvanje = "Hello, Hope you will check here :)";
            reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generate();
        }
        private void reset()
        { 
            //boxes
            lblGuessed.Text = "";
            lblGeneratedWords.Text = "Click the button to generate words!";
            textBox1.Text = "Click the button to generate words!";
            // VALUES
            guessedWords = 0;
            start = 3;
            seconds = 60;
            pbMinuteTimer.Value = 60;
            wpm = 0;
            //TIMERS
            timerMinute.Stop();
            startTimer.Stop();
            //TB-buttons
            textBox1.ReadOnly = true;
            button1.Enabled = true;
            button2.Enabled = true;
        }
        private void generate()
        {
            reset();
            Random rand = new Random();
            int a = rand.Next(0, rechenice.Count);
            textZaPogoduvanje = rechenice[a];
            lblGeneratedWords.Text = textZaPogoduvanje;
            textBox1.Text = "Type the above text here when the race begins!";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "Type the above text here when the race begins!" && textBox1.Text != "Click the button to generate words!")
            {
                if (guessedWords == textZaPogoduvanje.Split().Length)
                {
                    reset();
                    if(wpm < 80)
                    {
                        if (MessageBox.Show("Congrats, you finished early.\nWPM: " + wpm.ToString() + "\nNEW GAME?", "GOOD JOB!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            generate();
                        }
                        else
                        {
                            textBox1.ReadOnly = true;
                        }
                    }
                    if (wpm > 100)
                    {
                        if (MessageBox.Show("YOU ARE OCTOPUS! GOOD JOB!\nWPM: " + wpm.ToString() + "\nNEW GAME?", "GOOD JOB!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            generate();
                        }
                        else
                        {
                            textBox1.ReadOnly = true;
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Congrats, you are middle-range writer!\nWPM: " + wpm.ToString() + "\nNEW GAME?", "GOOD JOB!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            generate();
                        }
                        else
                        {
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
                        wpm = guessedWords / ((float)seconds / 60);
                        wpmlbl.Text = wpm.ToString();
                        textBox1.Text = "";
                    }
                    else
                    {
                        if (!proverka.Contains(textBox1.Text))
                        {
                            lblGeneratedWords.ForeColor = Color.Red;
                        }
                        else
                        {
                            lblGeneratedWords.ForeColor = Color.Black;
                        }
                    }
                }
            }
        }

        private void startTimer_Tick(object sender, EventArgs e)
        {
            if(start > 0)
            {
                start -= 1;
                lblCount.Text = start.ToString();
                if (start == 0)
                    lblCount.Text = "GO!";
            }
            else if(start==0)
            {
                lblCount.Text = "GO!";
                lblCount.Visible = false;
                textBox1.Text = "";
                textBox1.ReadOnly = false;
                timerMinute.Start();
                start = -20;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            generate();
            startTimer.Start();
            button1.Enabled = false;
            button2.Enabled = false;
            lblCount.Visible = true;
        }

        private void timerMinute_Tick(object sender, EventArgs e)
        {
            if (seconds > 0)
            {
                seconds -= 1;
                pbMinuteTimer.Value = seconds;
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
