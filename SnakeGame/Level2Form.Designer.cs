namespace SnakeGame
{
    partial class Level2Form
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
            this.menuLable = new System.Windows.Forms.Label();
            this.staticLevelLabel = new System.Windows.Forms.Label();
            this.levelNumberLabel = new System.Windows.Forms.Label();
            this.staticScoreLable = new System.Windows.Forms.Label();
            this.scoreNumberLabel = new System.Windows.Forms.Label();
            this.staticNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.menuBackgroungLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuLable
            // 
            this.menuLable.AutoSize = true;
            this.menuLable.BackColor = System.Drawing.SystemColors.Info;
            this.menuLable.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLable.Location = new System.Drawing.Point(44, 28);
            this.menuLable.Name = "menuLable";
            this.menuLable.Size = new System.Drawing.Size(375, 161);
            this.menuLable.TabIndex = 1;
            this.menuLable.Text = "\r\nUse the arrow keys to change directions\r\n\r\nUse the spacebar to pause\r\n\r\nPress e" +
    "nter to begain\r\n\r\n";
            this.menuLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // staticLevelLabel
            // 
            this.staticLevelLabel.AutoSize = true;
            this.staticLevelLabel.BackColor = System.Drawing.SystemColors.Info;
            this.staticLevelLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticLevelLabel.Location = new System.Drawing.Point(45, 303);
            this.staticLevelLabel.Name = "staticLevelLabel";
            this.staticLevelLabel.Size = new System.Drawing.Size(94, 34);
            this.staticLevelLabel.TabIndex = 2;
            this.staticLevelLabel.Text = "Level:";
            // 
            // levelNumberLabel
            // 
            this.levelNumberLabel.AutoSize = true;
            this.levelNumberLabel.BackColor = System.Drawing.SystemColors.Info;
            this.levelNumberLabel.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelNumberLabel.Location = new System.Drawing.Point(192, 283);
            this.levelNumberLabel.Name = "levelNumberLabel";
            this.levelNumberLabel.Size = new System.Drawing.Size(51, 56);
            this.levelNumberLabel.TabIndex = 3;
            this.levelNumberLabel.Text = "0";
            // 
            // staticScoreLable
            // 
            this.staticScoreLable.AutoSize = true;
            this.staticScoreLable.BackColor = System.Drawing.SystemColors.Info;
            this.staticScoreLable.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticScoreLable.Location = new System.Drawing.Point(45, 115);
            this.staticScoreLable.Name = "staticScoreLable";
            this.staticScoreLable.Size = new System.Drawing.Size(101, 34);
            this.staticScoreLable.TabIndex = 4;
            this.staticScoreLable.Text = "Score:";
            // 
            // scoreNumberLabel
            // 
            this.scoreNumberLabel.AutoSize = true;
            this.scoreNumberLabel.BackColor = System.Drawing.SystemColors.Info;
            this.scoreNumberLabel.Font = new System.Drawing.Font("Century Gothic", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreNumberLabel.Location = new System.Drawing.Point(206, 91);
            this.scoreNumberLabel.Name = "scoreNumberLabel";
            this.scoreNumberLabel.Size = new System.Drawing.Size(52, 58);
            this.scoreNumberLabel.TabIndex = 5;
            this.scoreNumberLabel.Text = "0";
            // 
            // staticNameLabel
            // 
            this.staticNameLabel.AutoSize = true;
            this.staticNameLabel.BackColor = System.Drawing.SystemColors.Info;
            this.staticNameLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticNameLabel.Location = new System.Drawing.Point(42, 28);
            this.staticNameLabel.Name = "staticNameLabel";
            this.staticNameLabel.Size = new System.Drawing.Size(106, 34);
            this.staticNameLabel.TabIndex = 6;
            this.staticNameLabel.Text = "Name:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.SystemColors.Info;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(198, 36);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(148, 34);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Bob Smith";
            // 
            // menuBackgroungLable
            // 
            this.menuBackgroungLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuBackgroungLable.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBackgroungLable.Image = global::SnakeGame.Properties.Resources.snakeGuyResized;
            this.menuBackgroungLable.Location = new System.Drawing.Point(0, 0);
            this.menuBackgroungLable.Name = "menuBackgroungLable";
            this.menuBackgroungLable.Size = new System.Drawing.Size(582, 455);
            this.menuBackgroungLable.TabIndex = 0;
            this.menuBackgroungLable.Text = "\r\n\r\n\r\n\r\n";
            this.menuBackgroungLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menuBackgroungLable.Click += new System.EventHandler(this.menuLeabel_Click);
            // 
            // Level2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(582, 455);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.staticNameLabel);
            this.Controls.Add(this.scoreNumberLabel);
            this.Controls.Add(this.staticScoreLable);
            this.Controls.Add(this.levelNumberLabel);
            this.Controls.Add(this.staticLevelLabel);
            this.Controls.Add(this.menuLable);
            this.Controls.Add(this.menuBackgroungLable);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Level2Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake    Score 1";
            this.Load += new System.EventHandler(this.gameBoardForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.gameBoardForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameBoardForm_KeyDown_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label menuBackgroungLable;
        private System.Windows.Forms.Label menuLable;
        private System.Windows.Forms.Label staticLevelLabel;
        private System.Windows.Forms.Label levelNumberLabel;
        private System.Windows.Forms.Label staticScoreLable;
        private System.Windows.Forms.Label scoreNumberLabel;
        private System.Windows.Forms.Label staticNameLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}

