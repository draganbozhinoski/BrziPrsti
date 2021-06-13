
namespace BrziPrsti
{
    partial class Leaderboard
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
            this.leaderGrid = new System.Windows.Forms.DataGridView();
            this.rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accuracy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wpm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.leaderGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // leaderGrid
            // 
            this.leaderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rank,
            this.Name,
            this.Accuracy,
            this.wpm});
            this.leaderGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leaderGrid.Location = new System.Drawing.Point(0, 0);
            this.leaderGrid.Name = "leaderGrid";
            this.leaderGrid.RowHeadersWidth = 51;
            this.leaderGrid.RowTemplate.Height = 24;
            this.leaderGrid.Size = new System.Drawing.Size(573, 492);
            this.leaderGrid.TabIndex = 0;
            this.leaderGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.leaderGrid_CellContentClick);
            // 
            // rank
            // 
            this.rank.HeaderText = "Rank";
            this.rank.MinimumWidth = 6;
            this.rank.Name = "rank";
            this.rank.ReadOnly = true;
            this.rank.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 125;
            // 
            // Accuracy
            // 
            this.Accuracy.HeaderText = "accuracy";
            this.Accuracy.MinimumWidth = 6;
            this.Accuracy.Name = "Accuracy";
            this.Accuracy.ReadOnly = true;
            this.Accuracy.Width = 125;
            // 
            // wpm
            // 
            this.wpm.HeaderText = "Words Per Minute";
            this.wpm.MinimumWidth = 6;
            this.wpm.Name = "wpm";
            this.wpm.ReadOnly = true;
            this.wpm.Width = 125;
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 492);
            this.Controls.Add(this.leaderGrid);
            this.Text = "Leaderboard";
            this.Load += new System.EventHandler(this.Leaderboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leaderGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView leaderGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accuracy;
        private System.Windows.Forms.DataGridViewTextBoxColumn wpm;
    }
}