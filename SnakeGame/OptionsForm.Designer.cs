namespace SnakeGame
{
    partial class OptionsForm
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
            this.speedLable = new System.Windows.Forms.Label();
            this.snakeColorLable = new System.Windows.Forms.Label();
            this.foodColorLable = new System.Windows.Forms.Label();
            this.redFoodRadio = new System.Windows.Forms.RadioButton();
            this.greenSnakeRadio = new System.Windows.Forms.RadioButton();
            this.slowRadio = new System.Windows.Forms.RadioButton();
            this.blueSnakeRadio = new System.Windows.Forms.RadioButton();
            this.orangeSnakeRadio = new System.Windows.Forms.RadioButton();
            this.indigoFoodRadio = new System.Windows.Forms.RadioButton();
            this.yellowFoodRadio = new System.Windows.Forms.RadioButton();
            this.mediumRadio = new System.Windows.Forms.RadioButton();
            this.fastRadio = new System.Windows.Forms.RadioButton();
            this.StartButton = new System.Windows.Forms.Button();
            this.snakeColorGroupBox = new System.Windows.Forms.GroupBox();
            this.foodColorGroupBox = new System.Windows.Forms.GroupBox();
            this.speedGroupBox = new System.Windows.Forms.GroupBox();
            this.snakeColorGroupBox.SuspendLayout();
            this.foodColorGroupBox.SuspendLayout();
            this.speedGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // speedLable
            // 
            this.speedLable.AutoSize = true;
            this.speedLable.BackColor = System.Drawing.SystemColors.Info;
            this.speedLable.Location = new System.Drawing.Point(-1, 20);
            this.speedLable.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.speedLable.Name = "speedLable";
            this.speedLable.Size = new System.Drawing.Size(111, 38);
            this.speedLable.TabIndex = 0;
            this.speedLable.Text = "Speed";
            // 
            // snakeColorLable
            // 
            this.snakeColorLable.AutoSize = true;
            this.snakeColorLable.BackColor = System.Drawing.SystemColors.Info;
            this.snakeColorLable.Location = new System.Drawing.Point(-1, 19);
            this.snakeColorLable.Name = "snakeColorLable";
            this.snakeColorLable.Size = new System.Drawing.Size(225, 38);
            this.snakeColorLable.TabIndex = 1;
            this.snakeColorLable.Text = "Color of snake";
            // 
            // foodColorLable
            // 
            this.foodColorLable.AutoSize = true;
            this.foodColorLable.BackColor = System.Drawing.SystemColors.Info;
            this.foodColorLable.Location = new System.Drawing.Point(-1, 16);
            this.foodColorLable.Name = "foodColorLable";
            this.foodColorLable.Size = new System.Drawing.Size(204, 38);
            this.foodColorLable.TabIndex = 2;
            this.foodColorLable.Text = "Color of food";
            // 
            // redFoodRadio
            // 
            this.redFoodRadio.AutoSize = true;
            this.redFoodRadio.BackColor = System.Drawing.Color.Transparent;
            this.redFoodRadio.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redFoodRadio.Location = new System.Drawing.Point(37, 68);
            this.redFoodRadio.Name = "redFoodRadio";
            this.redFoodRadio.Size = new System.Drawing.Size(69, 27);
            this.redFoodRadio.TabIndex = 3;
            this.redFoodRadio.TabStop = true;
            this.redFoodRadio.Text = "Red";
            this.redFoodRadio.UseVisualStyleBackColor = false;
            this.redFoodRadio.CheckedChanged += new System.EventHandler(this.redFoodRadio_CheckedChanged);
            this.redFoodRadio.Click += new System.EventHandler(this.redFoodRadio_Click);
            // 
            // greenSnakeRadio
            // 
            this.greenSnakeRadio.AutoSize = true;
            this.greenSnakeRadio.BackColor = System.Drawing.Color.Transparent;
            this.greenSnakeRadio.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenSnakeRadio.Location = new System.Drawing.Point(37, 80);
            this.greenSnakeRadio.Name = "greenSnakeRadio";
            this.greenSnakeRadio.Size = new System.Drawing.Size(92, 27);
            this.greenSnakeRadio.TabIndex = 4;
            this.greenSnakeRadio.TabStop = true;
            this.greenSnakeRadio.Text = "Green";
            this.greenSnakeRadio.UseVisualStyleBackColor = false;
            this.greenSnakeRadio.CheckedChanged += new System.EventHandler(this.greenSnakeRadio_CheckedChanged);
            // 
            // slowRadio
            // 
            this.slowRadio.AutoSize = true;
            this.slowRadio.BackColor = System.Drawing.Color.Transparent;
            this.slowRadio.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slowRadio.Location = new System.Drawing.Point(37, 61);
            this.slowRadio.Name = "slowRadio";
            this.slowRadio.Size = new System.Drawing.Size(75, 27);
            this.slowRadio.TabIndex = 5;
            this.slowRadio.TabStop = true;
            this.slowRadio.Text = "Slow";
            this.slowRadio.UseVisualStyleBackColor = false;
            this.slowRadio.CheckedChanged += new System.EventHandler(this.slowRadio_CheckedChanged);
            this.slowRadio.Click += new System.EventHandler(this.slowRadio_Click);
            // 
            // blueSnakeRadio
            // 
            this.blueSnakeRadio.AutoSize = true;
            this.blueSnakeRadio.BackColor = System.Drawing.Color.Transparent;
            this.blueSnakeRadio.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueSnakeRadio.Location = new System.Drawing.Point(156, 80);
            this.blueSnakeRadio.Name = "blueSnakeRadio";
            this.blueSnakeRadio.Size = new System.Drawing.Size(73, 27);
            this.blueSnakeRadio.TabIndex = 6;
            this.blueSnakeRadio.TabStop = true;
            this.blueSnakeRadio.Text = "Blue";
            this.blueSnakeRadio.UseVisualStyleBackColor = false;
            this.blueSnakeRadio.CheckedChanged += new System.EventHandler(this.blueSnakeRadio_CheckedChanged);
            this.blueSnakeRadio.Click += new System.EventHandler(this.blueSnakeRadio_Click);
            // 
            // orangeSnakeRadio
            // 
            this.orangeSnakeRadio.AutoSize = true;
            this.orangeSnakeRadio.BackColor = System.Drawing.Color.Transparent;
            this.orangeSnakeRadio.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orangeSnakeRadio.Location = new System.Drawing.Point(251, 80);
            this.orangeSnakeRadio.Name = "orangeSnakeRadio";
            this.orangeSnakeRadio.Size = new System.Drawing.Size(105, 27);
            this.orangeSnakeRadio.TabIndex = 7;
            this.orangeSnakeRadio.TabStop = true;
            this.orangeSnakeRadio.Text = "Orange";
            this.orangeSnakeRadio.UseVisualStyleBackColor = false;
            this.orangeSnakeRadio.CheckedChanged += new System.EventHandler(this.orangeSnakeRadio_CheckedChanged);
            this.orangeSnakeRadio.Click += new System.EventHandler(this.orangeSnakeRadio_Click);
            // 
            // indigoFoodRadio
            // 
            this.indigoFoodRadio.AutoSize = true;
            this.indigoFoodRadio.BackColor = System.Drawing.Color.Transparent;
            this.indigoFoodRadio.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indigoFoodRadio.Location = new System.Drawing.Point(156, 68);
            this.indigoFoodRadio.Name = "indigoFoodRadio";
            this.indigoFoodRadio.Size = new System.Drawing.Size(93, 27);
            this.indigoFoodRadio.TabIndex = 8;
            this.indigoFoodRadio.TabStop = true;
            this.indigoFoodRadio.Text = "Indigo";
            this.indigoFoodRadio.UseVisualStyleBackColor = false;
            this.indigoFoodRadio.CheckedChanged += new System.EventHandler(this.indigoFoodRadio_CheckedChanged);
            this.indigoFoodRadio.Click += new System.EventHandler(this.indigoFoodRadio_Click);
            // 
            // yellowFoodRadio
            // 
            this.yellowFoodRadio.AutoSize = true;
            this.yellowFoodRadio.BackColor = System.Drawing.Color.Transparent;
            this.yellowFoodRadio.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowFoodRadio.Location = new System.Drawing.Point(255, 68);
            this.yellowFoodRadio.Name = "yellowFoodRadio";
            this.yellowFoodRadio.Size = new System.Drawing.Size(95, 27);
            this.yellowFoodRadio.TabIndex = 9;
            this.yellowFoodRadio.TabStop = true;
            this.yellowFoodRadio.Text = "Yellow";
            this.yellowFoodRadio.UseVisualStyleBackColor = false;
            this.yellowFoodRadio.CheckedChanged += new System.EventHandler(this.yellowFoodRadio_CheckedChanged);
            this.yellowFoodRadio.Click += new System.EventHandler(this.yellowFoodRadio_Click);
            // 
            // mediumRadio
            // 
            this.mediumRadio.AutoSize = true;
            this.mediumRadio.BackColor = System.Drawing.Color.Transparent;
            this.mediumRadio.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumRadio.Location = new System.Drawing.Point(118, 61);
            this.mediumRadio.Name = "mediumRadio";
            this.mediumRadio.Size = new System.Drawing.Size(111, 27);
            this.mediumRadio.TabIndex = 10;
            this.mediumRadio.TabStop = true;
            this.mediumRadio.Text = "Medium";
            this.mediumRadio.UseVisualStyleBackColor = false;
            this.mediumRadio.CheckedChanged += new System.EventHandler(this.mediumRadio_CheckedChanged);
            this.mediumRadio.Click += new System.EventHandler(this.mediumRadio_Click);
            // 
            // fastRadio
            // 
            this.fastRadio.AutoSize = true;
            this.fastRadio.BackColor = System.Drawing.Color.Transparent;
            this.fastRadio.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fastRadio.Location = new System.Drawing.Point(251, 61);
            this.fastRadio.Name = "fastRadio";
            this.fastRadio.Size = new System.Drawing.Size(69, 27);
            this.fastRadio.TabIndex = 11;
            this.fastRadio.TabStop = true;
            this.fastRadio.Text = "Fast";
            this.fastRadio.UseVisualStyleBackColor = false;
            this.fastRadio.CheckedChanged += new System.EventHandler(this.fastRadio_CheckedChanged);
            this.fastRadio.Click += new System.EventHandler(this.fastRadio_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.Control;
            this.StartButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(112, 360);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(152, 28);
            this.StartButton.TabIndex = 12;
            this.StartButton.Text = "Click to start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // snakeColorGroupBox
            // 
            this.snakeColorGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.snakeColorGroupBox.Controls.Add(this.greenSnakeRadio);
            this.snakeColorGroupBox.Controls.Add(this.blueSnakeRadio);
            this.snakeColorGroupBox.Controls.Add(this.orangeSnakeRadio);
            this.snakeColorGroupBox.Controls.Add(this.snakeColorLable);
            this.snakeColorGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.snakeColorGroupBox.Location = new System.Drawing.Point(12, 0);
            this.snakeColorGroupBox.Name = "snakeColorGroupBox";
            this.snakeColorGroupBox.Size = new System.Drawing.Size(379, 113);
            this.snakeColorGroupBox.TabIndex = 13;
            this.snakeColorGroupBox.TabStop = false;
            // 
            // foodColorGroupBox
            // 
            this.foodColorGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.foodColorGroupBox.Controls.Add(this.foodColorLable);
            this.foodColorGroupBox.Controls.Add(this.redFoodRadio);
            this.foodColorGroupBox.Controls.Add(this.indigoFoodRadio);
            this.foodColorGroupBox.Controls.Add(this.yellowFoodRadio);
            this.foodColorGroupBox.Location = new System.Drawing.Point(12, 113);
            this.foodColorGroupBox.Name = "foodColorGroupBox";
            this.foodColorGroupBox.Size = new System.Drawing.Size(379, 101);
            this.foodColorGroupBox.TabIndex = 14;
            this.foodColorGroupBox.TabStop = false;
            // 
            // speedGroupBox
            // 
            this.speedGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.speedGroupBox.Controls.Add(this.speedLable);
            this.speedGroupBox.Controls.Add(this.slowRadio);
            this.speedGroupBox.Controls.Add(this.mediumRadio);
            this.speedGroupBox.Controls.Add(this.fastRadio);
            this.speedGroupBox.Location = new System.Drawing.Point(12, 234);
            this.speedGroupBox.Name = "speedGroupBox";
            this.speedGroupBox.Size = new System.Drawing.Size(356, 94);
            this.speedGroupBox.TabIndex = 15;
            this.speedGroupBox.TabStop = false;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SnakeGame.Properties.Resources.snakeGuyResized;
            this.ClientSize = new System.Drawing.Size(578, 451);
            this.Controls.Add(this.speedGroupBox);
            this.Controls.Add(this.foodColorGroupBox);
            this.Controls.Add(this.snakeColorGroupBox);
            this.Controls.Add(this.StartButton);
            this.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose your options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.snakeColorGroupBox.ResumeLayout(false);
            this.snakeColorGroupBox.PerformLayout();
            this.foodColorGroupBox.ResumeLayout(false);
            this.foodColorGroupBox.PerformLayout();
            this.speedGroupBox.ResumeLayout(false);
            this.speedGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label speedLable;
        private System.Windows.Forms.Label snakeColorLable;
        private System.Windows.Forms.Label foodColorLable;
        private System.Windows.Forms.RadioButton redFoodRadio;
        private System.Windows.Forms.RadioButton greenSnakeRadio;
        private System.Windows.Forms.RadioButton slowRadio;
        private System.Windows.Forms.RadioButton blueSnakeRadio;
        private System.Windows.Forms.RadioButton orangeSnakeRadio;
        private System.Windows.Forms.RadioButton indigoFoodRadio;
        private System.Windows.Forms.RadioButton yellowFoodRadio;
        private System.Windows.Forms.RadioButton mediumRadio;
        private System.Windows.Forms.RadioButton fastRadio;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.GroupBox snakeColorGroupBox;
        private System.Windows.Forms.GroupBox foodColorGroupBox;
        private System.Windows.Forms.GroupBox speedGroupBox;
    }
}