
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
            this.txtText = new System.Windows.Forms.RichTextBox();
            this.txtGuessingWord = new System.Windows.Forms.RichTextBox();
            this.lblWords = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
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
            // 
            // txtGuessingWord
            // 
            this.txtGuessingWord.Location = new System.Drawing.Point(12, 50);
            this.txtGuessingWord.Multiline = false;
            this.txtGuessingWord.Name = "txtGuessingWord";
            this.txtGuessingWord.ReadOnly = true;
            this.txtGuessingWord.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGuessingWord.Size = new System.Drawing.Size(190, 29);
            this.txtGuessingWord.TabIndex = 6;
            this.txtGuessingWord.Text = "";
            this.txtGuessingWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuessingWord_KeyPress);
            // 
            // lblWords
            // 
            this.lblWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWords.Location = new System.Drawing.Point(220, 50);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(292, 23);
            this.lblWords.TabIndex = 5;
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine.Location = new System.Drawing.Point(208, 50);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(18, 25);
            this.lblLine.TabIndex = 4;
            this.lblLine.Text = "|";
            // 
            // Game1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.txtGuessingWord);
            this.Controls.Add(this.lblWords);
            this.Controls.Add(this.lblLine);
            this.Name = "Game1";
            this.Text = "Game1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtText;
        private System.Windows.Forms.RichTextBox txtGuessingWord;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Label lblLine;
    }
}