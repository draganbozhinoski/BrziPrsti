
namespace BrziPrsti
{
    partial class Game
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
            this.lblGeneratedWords = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblGuessed = new System.Windows.Forms.Label();
            this.startTimer = new System.Windows.Forms.Timer(this.components);
            this.pbMinuteTimer = new System.Windows.Forms.ProgressBar();
            this.timerMinute = new System.Windows.Forms.Timer(this.components);
            this.lblCount = new System.Windows.Forms.Label();
            this.wpmlbl = new System.Windows.Forms.Label();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.imgZeleno = new System.Windows.Forms.PictureBox();
            this.imgZholto = new System.Windows.Forms.PictureBox();
            this.imgCrveno = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgZeleno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgZholto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCrveno)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGeneratedWords
            // 
            this.lblGeneratedWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneratedWords.Location = new System.Drawing.Point(13, 13);
            this.lblGeneratedWords.Name = "lblGeneratedWords";
            this.lblGeneratedWords.Size = new System.Drawing.Size(822, 190);
            this.lblGeneratedWords.TabIndex = 0;
            this.lblGeneratedWords.Text = "Click the button to generate words..";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "GENERATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "I\'m ready, start the timer!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 242);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(873, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblGuessed
            // 
            this.lblGuessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessed.ForeColor = System.Drawing.Color.Lime;
            this.lblGuessed.Location = new System.Drawing.Point(17, 293);
            this.lblGuessed.Name = "lblGuessed";
            this.lblGuessed.Size = new System.Drawing.Size(876, 106);
            this.lblGuessed.TabIndex = 4;
            // 
            // startTimer
            // 
            this.startTimer.Interval = 1000;
            this.startTimer.Tick += new System.EventHandler(this.startTimer_Tick);
            // 
            // pbMinuteTimer
            // 
            this.pbMinuteTimer.Location = new System.Drawing.Point(18, 405);
            this.pbMinuteTimer.Maximum = 60;
            this.pbMinuteTimer.Name = "pbMinuteTimer";
            this.pbMinuteTimer.Size = new System.Drawing.Size(873, 23);
            this.pbMinuteTimer.TabIndex = 5;
            this.pbMinuteTimer.Value = 60;
            // 
            // timerMinute
            // 
            this.timerMinute.Interval = 1000;
            this.timerMinute.Tick += new System.EventHandler(this.timerMinute_Tick);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(521, 312);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(95, 67);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "10";
            this.lblCount.Visible = false;
            // 
            // wpmlbl
            // 
            this.wpmlbl.AutoSize = true;
            this.wpmlbl.Location = new System.Drawing.Point(22, 483);
            this.wpmlbl.Name = "wpmlbl";
            this.wpmlbl.Size = new System.Drawing.Size(86, 17);
            this.wpmlbl.TabIndex = 7;
            this.wpmlbl.Text = "Your wpm: 0";
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.AutoSize = true;
            this.lblAccuracy.Location = new System.Drawing.Point(743, 483);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(143, 17);
            this.lblAccuracy.TabIndex = 8;
            this.lblAccuracy.Text = "Your accuracy: 100%";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblSeconds.Location = new System.Drawing.Point(433, 431);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(43, 29);
            this.lblSeconds.TabIndex = 9;
            this.lblSeconds.Text = "60";
            // 
            // imgZeleno
            // 
            this.imgZeleno.Image = global::BrziPrsti.Properties.Resources.zeleno;
            this.imgZeleno.Location = new System.Drawing.Point(398, 289);
            this.imgZeleno.Name = "imgZeleno";
            this.imgZeleno.Size = new System.Drawing.Size(117, 110);
            this.imgZeleno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgZeleno.TabIndex = 12;
            this.imgZeleno.TabStop = false;
            this.imgZeleno.Visible = false;
            // 
            // imgZholto
            // 
            this.imgZholto.Image = global::BrziPrsti.Properties.Resources.zholto;
            this.imgZholto.Location = new System.Drawing.Point(398, 289);
            this.imgZholto.Name = "imgZholto";
            this.imgZholto.Size = new System.Drawing.Size(117, 110);
            this.imgZholto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgZholto.TabIndex = 11;
            this.imgZholto.TabStop = false;
            this.imgZholto.Visible = false;
            // 
            // imgCrveno
            // 
            this.imgCrveno.Image = global::BrziPrsti.Properties.Resources.crveno;
            this.imgCrveno.Location = new System.Drawing.Point(398, 289);
            this.imgCrveno.Name = "imgCrveno";
            this.imgCrveno.Size = new System.Drawing.Size(117, 110);
            this.imgCrveno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCrveno.TabIndex = 10;
            this.imgCrveno.TabStop = false;
            this.imgCrveno.Visible = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 593);
            this.Controls.Add(this.imgZeleno);
            this.Controls.Add(this.imgZholto);
            this.Controls.Add(this.imgCrveno);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblAccuracy);
            this.Controls.Add(this.wpmlbl);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.pbMinuteTimer);
            this.Controls.Add(this.lblGuessed);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblGeneratedWords);
            this.Name = "Game";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.imgZeleno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgZholto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCrveno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGeneratedWords;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblGuessed;
        private System.Windows.Forms.Timer startTimer;
        private System.Windows.Forms.ProgressBar pbMinuteTimer;
        private System.Windows.Forms.Timer timerMinute;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label wpmlbl;
        private System.Windows.Forms.Label lblAccuracy;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.PictureBox imgCrveno;
        private System.Windows.Forms.PictureBox imgZholto;
        private System.Windows.Forms.PictureBox imgZeleno;
    }
}