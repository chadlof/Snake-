namespace SnakeGame
{
    partial class WelcomForm
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
            this.welcomeLable = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLable
            // 
            this.welcomeLable.AutoSize = true;
            this.welcomeLable.BackColor = System.Drawing.SystemColors.Info;
            this.welcomeLable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.welcomeLable.Font = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLable.Location = new System.Drawing.Point(44, 19);
            this.welcomeLable.Name = "welcomeLable";
            this.welcomeLable.Size = new System.Drawing.Size(384, 140);
            this.welcomeLable.TabIndex = 0;
            this.welcomeLable.Text = "Snake \r\nCreated by Chad Lofgren\r\n\r\nEnter your name below and\r\nClick the button to" +
    " customize your snake\r\n\r\n";
            this.welcomeLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NameTextBox.Location = new System.Drawing.Point(134, 230);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(181, 22);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(150, 281);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(154, 39);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Click Me!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // WelcomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SnakeGame.Properties.Resources.snakeGuyResized;
            this.ClientSize = new System.Drawing.Size(564, 410);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.welcomeLable);
            this.MaximumSize = new System.Drawing.Size(582, 455);
            this.MinimumSize = new System.Drawing.Size(582, 455);
            this.Name = "WelcomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.Click += new System.EventHandler(this.startButton_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLable;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button startButton;
    }
}