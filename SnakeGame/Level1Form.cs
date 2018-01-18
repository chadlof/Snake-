using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Level1Form : Form
    {
        private int direction = 0;
        private int level = 1;
        private Timer gameLoop = new Timer();
        private Random rand = new Random();
        private Graphics graphics;
        private Snake snake;
        private Food food;
        public string playerName;
        private int playerScore = 1;
        private int snakeColor;
        private int foodColor;
        private int speed;
        
        public List<Int32> ScoreList = new List<Int32>();
        




        public Level1Form()
        {
            InitializeComponent();
           // snake = new Snake();
            //food = new Food(rand);
           // gameLoop.Interval += 100;
            gameLoop.Tick += Update;
            levelNumberLabel.Text = level.ToString();

        }
        //coming from optionsForm
        public Level1Form(string _name, Int32 _score, int _foodColor, int _snakeColor, int _speed, Snake _snake,Food _food )
        {
            playerName = _name;
            playerScore = _score;
            foodColor = _foodColor;
            snakeColor = _snakeColor;
            speed = _speed;
            snake = _snake;
            food = _food;
            Snake.x = 0;
            Snake.y = 0;
           


            InitializeComponent();
            //snake = new Snake();  //creats snake
            //food = new Food(rand);  //creats food
            //gameLoop.Interval += 100;  //sets the speed of the snake
            gameLoop.Tick += Update;  //sets the timer
            levelNumberLabel.Text = level.ToString();
           

            scoreNumberLabel.Visible = false;
            staticScoreLable.Visible = false;
            staticNameLabel.Visible = false;
            nameLabel.Visible = false;
            
        }

        //coming from gameoverForm
        public Level1Form(string _name, Int32 _score, int _speed, Snake _snake, Food _food )
             // Level1Form playGame = new Level1Form(playerName, playerScore, foodColor, snakeColor, speed, snake, food);
        {
            playerName = _name;
            playerScore = 0;
            speed = _speed;
            snake = new Snake();  //creats snake
            food = _food;
            Snake.x = 0;
            Snake.y = 0;
            Cursor.Hide();

            InitializeComponent();
            //snake = new Snake();  //creats snake
            //food = new Food(rand);  //creats food
            //gameLoop.Interval = 100;  //sets the speed of the snake
            gameLoop.Tick += Update;  //sets the timer
            levelNumberLabel.Text = level.ToString();

            scoreNumberLabel.Visible = false;
            staticScoreLable.Visible = false;
            staticNameLabel.Visible = false;
            nameLabel.Visible = false;
          

        }

      
        private void Update(object sender, EventArgs e)
        {

            //switch (snakeColor)
            //{
            //    case 1:
            //    {

            //        snake.Brush = Brushes.Orange;
            //    }
            //        break;
            //    case 2:
            //        {
            //            snake.Brush = Brushes.Blue;
            //        }
            //        break;
            //    case 3:
            //        {
            //            snake.Brush = Brushes.Green;
            //        }
            //        break;

            //}

            //if (foodColor == 1)
            //{
            //    food.Brush = Brushes.Yellow;
            //}
            //else if (foodColor == 2)
            //{
            //    food.Brush = Brushes.Indigo;
            //}
            //else
            //{
            //    food.Brush = Brushes.Red;
            //}


            if (speed == 1)
            {
                gameLoop.Interval = 150;
            }
            else if (speed == 2)
            {
                gameLoop.Interval = 100;
            }
            else
            {
                gameLoop.Interval = 75;
            }

            //Text = string.Format("{0}     Score: {1}     Level: {2}    Speed: {3} Snake: {4} food: {5}",playerName, playerScore, level, speed, snakeColor, foodColor);
            Text = string.Format("{0}     Score: {1}     Level: {2}  ", playerName, playerScore, level);
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

                    gameLoop.Stop();
                    graphics.Clear(SystemColors.Control);
                    Level2Form playGame = new Level2Form(playerName, playerScore, foodColor, snakeColor, speed, ScoreList, snake, food);
                    playGame.ShowDialog();
                    this.Dispose();

                }
                
            }
            
         
            this.Invalidate();
           
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
                        //label1.Visible = true;
                        //label2.Visible = true;
                        
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

            //Brush red = new SolidBrush(Color.Blue);
            //Pen bluePen = new Pen(red, 0);
            //e.Graphics.DrawLine(Pens.Red, 200, 50, 100, 200);
            //e.Graphics.DrawLine(Pens.Blue, 10, 10, 400, 400);


            



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
