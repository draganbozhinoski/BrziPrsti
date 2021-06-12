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
    public partial class Game1 : Form
    {
        List<string> sentences;
        Random random = new Random();
        string s;
        Queue<char> charsForGues = new Queue<char>();
        bool isWordCorrect = true;
        int wordsCorrect = 0;
        int wordsWrong = 0;
        float accuracy = 0;
        int minutes = 0;
        public Game1()
        {
            sentences = new List<string>() {
            "Can you feel the sunshine? Does it brighten up your day? Don't you feel that sometimes you just need to run away? Reach out for the sunshine, forget about the rain. Just think about the good times and they will come back again.",
            "You gotta see it to believe it, the sky never looked so blue it's so hard to leave it, but that's what I always do. So I keep thinking back to a time under the canyon moon.",
            "So what did I do for this honour, you are asking? Well, perhaps the fact that he asked me to read his book, and write a ‘postface’ assessment both of his writing and of the issues he covers, and the fact that I said yes, has something to do with it. He says some blushmakingly kind things in his ‘preface to the postface’, which I will have to leave to French readers of the whole thing (published by Plon).",
            "Close your eyes in the night and I'll be right in front of you. So sit back, enjoy the view until the morning. When the sun comes from the west, that's where you'll find my silhouette. I'll ride a cloud, come back to you without a warning. So don't speak, 'cause it only makes my heart bleed. No matter what you say, I'll be only just a call away.",
            "Just take my hand, lead, dance with me...and I will simply follow the blueness of the water, the white waves rolling free...where the earth beneath my feet and stars make my heart whole again...in long and priceless moments of shared solitude...",
            "You don't need money, don't take fame. Don't need no credit card to ride this train. It's strong and it's sudden and it's cruel sometimes, but it might just save your life. That's the power of love.",
            "All I'm asking is that you do the minimal amount of work in this class to give yourself the illusion that you're actually learning something, and to give me a modicum of self respect like I'm actually teaching a class.",
            "In the late 1960s, a growing number of people became concerned about the growing problems of pollution and the destruction of natural habitats. This movement led to the formation of groups like the Environmental Protection Agency (EPA). The primary goal of the environmental movement as a whole is to make sure that the environment is safe and intact for future generations to enjoy.",
            "Jacques Seguela writes about political campaigns and communications not merely as an expert analyst, but as an experienced practitioner. Hence his latest book contains both insights worth heeding, but also enlivening tales of his own experience. He is observer and participant; outsider looking in, and insider looking out.  There is much to look at, not least in France with a Presidential election looming, and the outcome far from easy to predict.",
            "If Lula is a star of this book, so too is Barack Obama. American elections are of enormous interest to all political campaign junkies, a category in which both Seguela and I would almost certainly qualify. Much is made of Obama’s use of the internet, a relatively new phenomenon in historical terms and one the young Senator used brilliantly in his quest to become President. Yet though it was an accurate expression of his modernity, underpinning its use were some very old-fashioned campaign principles.",
            "You never should settle for the lifetime that is handed to you. There's always a line to be cut and someone to barrel through. And if you should find that you're about to get the short of the stick, take what you want, return what you get.",
            "I know just how to whisper and I know just how to cry. I know just where to find the answers and I know just how to lie. I know just how to fake it and I know just how to scheme. I know just when to face the truth and then I know just when to dream.",
            "If someone is able to show me that what I think or do is not right, I will happily change, for I seek the truth, by which no one was ever truly harmed. It is the person who continues in his self-deception and ignorance who is harmed.",
            "Opening your eyes is all that is needing. The heart lies and the head plays tricks with us, but the eyes see true. Look with your eyes. Hear with your ears. Taste with your mouth. Smell with your nose. Feel with your skin. Then comes the thinking, afterward, and in that way knowing the truth.",
            "The sooner your kids appreciate the value of work, the more successful they will be. Work is part of life. You work to earn money, put food on the table, and keep your homes orderly and clean. For your kids, work involves schoolwork, homework, and teamwork at home and in the community."
            };
            InitializeComponent();
            GenerateSentences();
        }

        public void GenerateSentences()
        {
            int r = random.Next(0, sentences.Count);
            s = sentences[r];
            lblWords.Text = s;
            foreach (var c in s)
            {
                charsForGues.Enqueue(c);
            }
        }

        private void txtGuessingWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            KeysConverter converter = new KeysConverter();
            string keyPressed = e.KeyChar.ToString();
            if (charsForGues.Count > 0)
            {
                string nextChar = charsForGues.Dequeue().ToString();
                if (e.KeyChar != (char)Keys.Back)
                {
                   
                    if (keyPressed.Equals(nextChar))
                    {
                        txtGuessingWord.SelectionColor = Color.Green;
                        txtGuessingWord.AppendText(nextChar);
                    }
                    else
                    {
                        txtGuessingWord.SelectionColor = Color.Red;
                        txtGuessingWord.AppendText(nextChar);
                        isWordCorrect = false;
                    }
                    if (nextChar.Equals(" "))
                    {
                        if (!isWordCorrect)
                        {
                            txtText.SelectionColor = Color.Red;
                            wordsWrong++;
                            lblWrong.Text = $"Wrong: {wordsWrong}";

                        }
                        else
                        {
                            txtText.SelectionColor = Color.Green;
                            wordsCorrect++;
                            lblCorrect.Text = $"Correct: {wordsCorrect}";
                        }
                        txtText.AppendText(txtGuessingWord.Text);
                        txtGuessingWord.Text = "";
                        isWordCorrect = true;
                    }
                    s = s.Remove(0, 1);
                    lblWords.Text = s;
                }
            }
            else
            {

                if (keyPressed.Equals(" ") || e.KeyChar == (char)Keys.Enter)
                {
                    if (!isWordCorrect)
                    {
                        txtText.SelectionColor = Color.Red;
                        wordsWrong++;
                        lblWrong.Text = lblWrong.Text = $"Wrong: {wordsWrong}";

                    }
                    else
                    {
                        txtText.SelectionColor = Color.Green;
                        wordsCorrect++;
                        lblCorrect.Text = $"Correct: {wordsCorrect}";
                    }
                    txtText.AppendText(txtGuessingWord.Text);
                    txtGuessingWord.Text = "";
                    isWordCorrect = true;
                    if (minutes > 0)
                    {
                        lblWordsPerMinute.Text = $"WPM: {wordsCorrect / minutes}";
                    }
                    else
                    {
                        lblWordsPerMinute.Text = $"WPM: {wordsCorrect}";
                    }
                    accuracy = (float)wordsCorrect / (wordsCorrect + wordsWrong);
                    lblAcc.Text = $"Accuracy: {accuracy * 100}%";
                    
                }
            }
                      

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            minutes++;
        }
    }
}
