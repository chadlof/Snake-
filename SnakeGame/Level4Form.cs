using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Level4Form : Form
    {
        private int direction = 0;
        private int level = 1;
        private Timer gameLoop = new Timer();
        private Random rand = new Random();
        private Graphics graphics;
        private Snake snake;
        private Food food;
        public string playerName;
        private int playerScore;
        private int snakeColor;
        private int foodColor;
        private int speed;
        public List<Int32> ScoreList;
        //public Rectangle body;
        //public Rectangle Piece;

        public Level4Form()
        {
            InitializeComponent();
            snake = new Snake();
            food = new Food(rand);
           // gameLoop.Interval += 100;
            gameLoop.Tick += Update;
            levelNumberLabel.Text = level.ToString();

        }
        //coming from optionsForm
        public Level4Form(string _name, Int32 _score, int _foodColor, int _snakeColor, int _speed)
        {
            playerName = _name;
            playerScore = _score;
            foodColor = _foodColor;
            snakeColor = _snakeColor;
            speed = _speed;
           

            InitializeComponent();
            //snake = new Snake();  //creats snake
            food = new Food(rand);  //creats food
            //gameLoop.Interval += 100;  //sets the speed of the snake
            gameLoop.Tick += Update;  //sets the timer
            levelNumberLabel.Text = level.ToString();
           

            scoreNumberLabel.Visible = false;
            staticScoreLable.Visible = false;
            staticNameLabel.Visible = false;
            nameLabel.Visible = false;
         
        }

        //coming from gameoverForm
        public Level4Form(string _name, Int32 _score, int _foodColor, int _snakeColor, int _speed, List<Int32>_scoreList, Snake snake, Food _food)
        {
            playerName = _name;
            playerScore = 0;
            foodColor = _foodColor;
            snakeColor = _snakeColor;
            speed = _speed;
            ScoreList = _scoreList;
            
            

            InitializeComponent();
            snake = new Snake();  //creats snake
            food = new Food(rand);  //creats food
            //gameLoop.Interval += 100;  //sets the speed of the snake
            gameLoop.Tick += Update;  //sets the timer
            levelNumberLabel.Text = level.ToString();

            scoreNumberLabel.Visible = false;
            staticScoreLable.Visible = false;
            staticNameLabel.Visible = false;
            nameLabel.Visible = false;
          

        }

      
        private void Update(object sender, EventArgs e)
        {
            Text = string.Format("{0}     Score: {1}     Level: {2}    Speed: {3} Snake: {4} food: {5}",playerName, playerScore, level, speed, snakeColor, foodColor);
            snake.Move(direction);
            for(int i = 1; i < snake.Body.Length; i++)
                if (snake.Body[0].IntersectsWith(snake.Body[i]))
                    Restart();
            if (snake.Body[0].X < 0 || snake.Body[0].X > 575)
                Restart();
            if (snake.Body[0].Y < 0 || snake.Body[0].Y > 455)
                Restart();
            if (snake.Body[0].IntersectsWith(food.Piece))
            {
                playerScore++;
                snake.Grow();
                food.Generate(rand);
               

                if (playerScore > 9 && playerScore <20)
                {
               
                  
                    Level2Form playGame = new Level2Form(playerName, playerScore, foodColor, snakeColor, speed, ScoreList, snake, food);
                    playGame.ShowDialog();
                  
                }
              
            }
            
         
            this.Invalidate();
            //if (snakeColor == 1)
            //{
            //    snake.Draw(graphics.FillRectangles(Brushes.Red, snake.Body));
            //}
            //if (speed == 1)
            //{
            //    gameLoop.Interval += 10;
            //}
            //else if (speed == 2)
            //{
            //    gameLoop.Interval += 5;
            //}
            //else
            //{
            //    gameLoop.Interval += 0;
            //}
        }

        private void Restart()
        {
            Cursor.Show();
            gameLoop.Stop();
            graphics.Clear(SystemColors.Control);
            GameOverForm endGame = new GameOverForm(playerName, playerScore, foodColor, snakeColor, speed, ScoreList, snake, food);
            endGame.ShowDialog();
            
        }

        private void gameBoardForm_KeyDown_1(object sender, KeyEventArgs e)
        {

            switch (e.KeyData)
            {
                case Keys.Enter:
                    if (menuBackgroungLable.Visible)
                    {
                        menuBackgroungLable.Visible = false;
                        menuLable.Visible = false;
                        staticLevelLabel.Visible = false;
                        levelNumberLabel.Visible = false;
                        Cursor.Hide();
                        gameLoop.Start();
                    }
                    break;
                case Keys.Space:
                    if (!menuBackgroungLable.Visible)
                        gameLoop.Enabled = (gameLoop.Enabled) ? false : true;

                    //if (menuLeabel.Visible)
                    //    gameLoop.Enabled = false;      //same as the above statment
                    //else
                    //    gameLoop.Enabled = true;
                    break;
                case Keys.Right:
                    if (direction != 2)
                        direction = 0;
                    break;
                case Keys.Down:
                    if (direction != 3)
                        direction = 1;
                    break;
                case Keys.Left:
                    if (direction != 0)
                        direction = 2;
                    break;
                case Keys.Up:
                    if (direction != 1)
                        direction = 3;
                    break;

            }
        }

        private void gameBoardForm_Paint(object sender, PaintEventArgs e)
        {
            graphics = this.CreateGraphics();
            snake.Draw(graphics);
            food.Draw(graphics);
        }

        private void gameBoardForm_Load(object sender, EventArgs e)
        {

        }

        private void menuLeabel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void gamoverLable_Click(object sender, EventArgs e)
        {

        }

        private void gamoverLable_Click_1(object sender, EventArgs e)
        {

        }
    }
}
