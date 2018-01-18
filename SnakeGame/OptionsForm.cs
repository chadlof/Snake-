using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class OptionsForm : Form
    {
        public string playerName;
        public Int32 playerScore;
        private int snakeColor;
        private int foodColor;
        private int speed;
        private Snake snake;
        private Food food;
        private Random rand = new Random();
        //private List<Int32> scorelist;
        //List<Int32> ScoreList = new List<Int32>();
        public OptionsForm()
        {
            InitializeComponent();
        }
        public OptionsForm(string _playerName, int _playerScore)
        {
            playerName = _playerName;
            playerScore = _playerScore;
            snake = new Snake();  //creats snake
            food = new Food(rand);
            InitializeComponent();
            
        }
        



        private void OptionsForm_Load(object sender, EventArgs e)
        {
         
        }
        private void greenSnakeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (greenSnakeRadio.Checked)
            {
                snakeColor = 1;
               
            }
        }

        private void blueSnakeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (blueSnakeRadio.Checked)
            {
                snakeColor = 2;
            }
        }

        private void orangeSnakeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (orangeSnakeRadio.Checked)
            {
                snakeColor = 3;
            }
        }

        private void redFoodRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (redFoodRadio.Checked)
            {
                foodColor = 1;
            }
        }

        private void indigoFoodRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (indigoFoodRadio.Checked)
            {
                foodColor = 2;
            }
        }
        private void yellowFoodRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (yellowFoodRadio.Checked)
            foodColor = 3;
            
        }

        private void slowRadio_CheckedChanged(object sender, EventArgs e)
        {
            //if (slowRadio.Checked)
            //{
            //    speed = 1;
            //}
        }

        private void mediumRadio_CheckedChanged(object sender, EventArgs e)
        {
            speed = 2;
            
        }

        private void fastRadio_CheckedChanged(object sender, EventArgs e)
        {
            speed = 2;
            
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (orangeSnakeRadio.Checked)
            {
                snakeColor = 3;

            }
            else if (blueSnakeRadio.Checked)
            {
                snakeColor = 2;
            }
            else
            {
                snakeColor = 1;
            }
            if (yellowFoodRadio.Checked)
            {
                foodColor = 3;
            }
            else if (indigoFoodRadio.Checked)
            {
                foodColor = 2;
            }
            else
            {
                foodColor = 1;
            }

            if (slowRadio.Checked)
            {
                speed = 1;
            }
            else if (fastRadio.Checked)
            {
                speed = 3;
            }
            else
            {
                speed = 2;
            }

            
            if (snakeColor == 3)
            {
                snake.Brush = Brushes.DarkOrange;
            }
            else if (snakeColor == 2)
            {
                snake.Brush = Brushes.Blue;
            }
            else
            {
                snake.Brush = Brushes.Green;
            }
                    

            

            if (foodColor == 3)
            {
                food.Brush = Brushes.Yellow;
            }
            else if (foodColor == 2)
            {
                food.Brush = Brushes.Indigo;
            }
            else
            {
                food.Brush = Brushes.Red;
            }


            //if (speed == 1)
            //{
            //    gameLoop.Interval = 150;
            //}
            //else if (speed == 2)
            //{
            //    gameLoop.Interval = 100;
            //}
            //else
            //{
            //    gameLoop.Interval = 75;
            //}
            Level1Form playGame = new Level1Form(playerName, playerScore, foodColor, snakeColor, speed, snake, food);
            playGame.ShowDialog();
            
        }
         






        private void greenSnakeRadio_Click(object sender, EventArgs e)
        {
            
        }

        private void blueSnakeRadio_Click(object sender, EventArgs e)
        {

        }

        private void orangeSnakeRadio_Click(object sender, EventArgs e)
        {

        }

        private void redFoodRadio_Click(object sender, EventArgs e)
        {

        }

        private void indigoFoodRadio_Click(object sender, EventArgs e)
        {

        }

        private void yellowFoodRadio_Click(object sender, EventArgs e)
        {

        }

        private void slowRadio_Click(object sender, EventArgs e)
        {

        }

        private void mediumRadio_Click(object sender, EventArgs e)
        {

        }

        private void fastRadio_Click(object sender, EventArgs e)
        {

        }



        
    }
}
