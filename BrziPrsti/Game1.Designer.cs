
namespace BrziPrsti
{
    partial class Game1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtText = new System.Windows.Forms.RichTextBox();
            this.txtGuessingWord = new System.Windows.Forms.RichTextBox();
            this.lblWords = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblWrong = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblWordsPerMinute = new System.Windows.Forms.Label();
            this.lblAcc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(12, 128);
            this.txtText.Name = "txtText";
            this.txtText.ReadOnly = true;
            this.txtText.Size = new System.Drawing.Size(623, 259);
            this.txtText.TabIndex = 7;
            this.txtText.Text = "";
            this.txtText.TextChanged += new System.EventHandler(this.txtText_TextChanged);
            // 
            // txtGuessingWord
            // 
            this.txtGuessingWord.Location = new System.Drawing.Point(12, 93);
            this.txtGuessingWord.Multiline = false;
            this.txtGuessingWord.Name = "txtGuessingWord";
            this.txtGuessingWord.ReadOnly = true;
            this.txtGuessingWord.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGuessingWord.Size = new System.Drawing.Size(190, 29);
            this.txtGuessingWord.TabIndex = 6;
            this.txtGuessingWord.Text = "";
            this.txtGuessingWord.TextChanged += new System.EventHandler(this.txtGuessingWord_TextChanged);
            this.txtGuessingWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuessingWord_KeyPress);
            // 
            // lblWords
            // 
            this.lblWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWords.Location = new System.Drawing.Point(218, 93);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(292, 23);
            this.lblWords.TabIndex = 5;
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine.Location = new System.Drawing.Point(208, 93);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(18, 25);
            this.lblLine.TabIndex = 4;
            this.lblLine.Text = "|";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.ForeColor = System.Drawing.Color.Green;
            this.lblCorrect.Location = new System.Drawing.Point(13, 70);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(70, 17);
            this.lblCorrect.TabIndex = 8;
            this.lblCorrect.Text = "Correct: 0";
            // 
            // lblWrong
            // 
            this.lblWrong.AutoSize = true;
            this.lblWrong.ForeColor = System.Drawing.Color.Red;
            this.lblWrong.Location = new System.Drawing.Point(139, 70);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWrong.Size = new System.Drawing.Size(66, 17);
            this.lblWrong.TabIndex = 9;
            this.lblWrong.Text = "Wrong: 0";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblWordsPerMinute
            // 
            this.lblWordsPerMinute.AutoSize = true;
            this.lblWordsPerMinute.Location = new System.Drawing.Point(13, 40);
            this.lblWordsPerMinute.Name = "lblWordsPerMinute";
            this.lblWordsPerMinute.Size = new System.Drawing.Size(57, 17);
            this.lblWordsPerMinute.TabIndex = 10;
            this.lblWordsPerMinute.Text = "WPM: 0";
            // 
            // lblAcc
            // 
            this.lblAcc.AutoSize = true;
            this.lblAcc.Location = new System.Drawing.Point(120, 40);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAcc.Size = new System.Drawing.Size(82, 17);
            this.lblAcc.TabIndex = 11;
            this.lblAcc.Text = "Accuracy: 0";
            // 
            // button1
            // 
            this.button1.Image = global::BrziPrsti.Properties.Resources.HILLBLU_button_background_svg;
            this.button1.Location = new System.Drawing.Point(490, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "LEADERBOARD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Game1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAcc);
            this.Controls.Add(this.lblWordsPerMinute);
            this.Controls.Add(this.lblWrong);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.txtGuessingWord);
            this.Controls.Add(this.lblWords);
            this.Controls.Add(this.lblLine);
            this.Name = "Game1";
            this.Text = "Game1";
            this.Load += new System.EventHandler(this.Game1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtText;
        private System.Windows.Forms.RichTextBox txtGuessingWord;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblWrong;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblWordsPerMinute;
        private System.Windows.Forms.Label lblAcc;
        private System.Windows.Forms.Button button1;
    }
}