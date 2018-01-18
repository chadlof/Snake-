namespace SnakeGame
{
    partial class GameOverForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.staticNameLabel = new System.Windows.Forms.Label();
            this.scoreLable = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.staticAvegScoreLabel = new System.Windows.Forms.Label();
            this.avergLabel = new System.Windows.Forms.Label();
            this.lowScore = new System.Windows.Forms.Label();
            this.lowLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.highLabel = new System.Windows.Forms.Label();
            this.retryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(330, 285);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(91, 21);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Bob Smith";
            // 
            // staticNameLabel
            // 
            this.staticNameLabel.AutoSize = true;
            this.staticNameLabel.Location = new System.Drawing.Point(161, 285);
            this.staticNameLabel.Name = "staticNameLabel";
            this.staticNameLabel.Size = new System.Drawing.Size(162, 21);
            this.staticNameLabel.TabIndex = 1;
            this.staticNameLabel.Text = "Thanks for playing ";
            // 
            // scoreLable
            // 
            this.scoreLable.AutoSize = true;
            this.scoreLable.BackColor = System.Drawing.Color.Transparent;
            this.scoreLable.Location = new System.Drawing.Point(120, 23);
            this.scoreLable.Name = "scoreLable";
            this.scoreLable.Size = new System.Drawing.Size(147, 21);
            this.scoreLable.TabIndex = 2;
            this.scoreLable.Text = "Score this game:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Location = new System.Drawing.Point(360, 23);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(61, 21);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "0";
            // 
            // staticAvegScoreLabel
            // 
            this.staticAvegScoreLabel.AutoSize = true;
            this.staticAvegScoreLabel.Location = new System.Drawing.Point(120, 60);
            this.staticAvegScoreLabel.Name = "staticAvegScoreLabel";
            this.staticAvegScoreLabel.Size = new System.Drawing.Size(139, 21);
            this.staticAvegScoreLabel.TabIndex = 4;
            this.staticAvegScoreLabel.Text = "Average Score:";
            // 
            // avergLabel
            // 
            this.avergLabel.AutoSize = true;
            this.avergLabel.Location = new System.Drawing.Point(360, 60);
            this.avergLabel.Name = "avergLabel";
            this.avergLabel.Size = new System.Drawing.Size(20, 21);
            this.avergLabel.TabIndex = 5;
            this.avergLabel.Text = "0";
            // 
            // lowScore
            // 
            this.lowScore.AutoSize = true;
            this.lowScore.Location = new System.Drawing.Point(120, 96);
            this.lowScore.Name = "lowScore";
            this.lowScore.Size = new System.Drawing.Size(117, 21);
            this.lowScore.TabIndex = 6;
            this.lowScore.Text = "Lowest Score";
            // 
            // lowLabel
            // 
            this.lowLabel.AutoSize = true;
            this.lowLabel.Location = new System.Drawing.Point(360, 96);
            this.lowLabel.Name = "lowLabel";
            this.lowLabel.Size = new System.Drawing.Size(20, 21);
            this.lowLabel.TabIndex = 7;
            this.lowLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Highest Score:";
            // 
            // highLabel
            // 
            this.highLabel.AutoSize = true;
            this.highLabel.Location = new System.Drawing.Point(360, 132);
            this.highLabel.Name = "highLabel";
            this.highLabel.Size = new System.Drawing.Size(20, 21);
            this.highLabel.TabIndex = 9;
            this.highLabel.Text = "0";
            // 
            // retryButton
            // 
            this.retryButton.BackColor = System.Drawing.Color.DarkBlue;
            this.retryButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.retryButton.Location = new System.Drawing.Point(223, 335);
            this.retryButton.Name = "retryButton";
            this.retryButton.Size = new System.Drawing.Size(156, 38);
            this.retryButton.TabIndex = 10;
            this.retryButton.Text = "Try Again";
            this.retryButton.UseVisualStyleBackColor = false;
            this.retryButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.retryButton_MouseClick);
            // 
            // GameOverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::SnakeGame.Properties.Resources.gameOver3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(582, 455);
            this.Controls.Add(this.retryButton);
            this.Controls.Add(this.highLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lowLabel);
            this.Controls.Add(this.lowScore);
            this.Controls.Add(this.avergLabel);
            this.Controls.Add(this.staticAvegScoreLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.scoreLable);
            this.Controls.Add(this.staticNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "GameOverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game over!";
            this.Load += new System.EventHandler(this.gameOverForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label staticNameLabel;
        private System.Windows.Forms.Label scoreLable;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label staticAvegScoreLabel;
        private System.Windows.Forms.Label avergLabel;
        private System.Windows.Forms.Label lowScore;
        private System.Windows.Forms.Label lowLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label highLabel;
        private System.Windows.Forms.Button retryButton;
    }
}