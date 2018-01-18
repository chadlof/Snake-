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
    public partial class GameOverForm : Form
    {
       

       
     
        private Graphics graphics;
        private Snake snake;
        private Food food;
        public string playerName;
        private Int32 playerScore;
        private int snakeColor;
        private int foodColor;
        private int speed;
        public List<Int32> ScoreList;
        //private List<Int32> ScoreList;
        
        public GameOverForm()
        {
            InitializeComponent();
             Cursor.Show();
    }

        public GameOverForm(string _name, Int32 _score, int _foodColor, int _snakeColor, int _speed, List<Int32> _ScoreList, Snake _snake, Food _food)
        {
         

            InitializeComponent();
            
            playerName = _name;
            playerScore = _score;
            foodColor = _foodColor;
            snakeColor = _snakeColor;
            speed = _speed;
            ScoreList = _ScoreList;
            snake = _snake;
            food = _food;

            
            ScoreList.Add(playerScore);

            nameLabel.Text = playerName;
            scoreLabel.Text = playerScore.ToString();
            avergLabel.Text = ScoreList.Average().ToString();
            //avergLabel.Text = (ScoreList.Capacity / ScoreList.Count).ToString();
            lowLabel.Text = ScoreList.Min().ToString();
            highLabel.Text = ScoreList.Max().ToString();
            Cursor.Show();


        }
        private void gameOverForm_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
           // Text = string.Format("{0}     Score: {1}     Level: {2}", playerName, playerScore);
        }

        private void retryButton_MouseClick(object sender, MouseEventArgs e)
        {
            Level1Form playGame = new Level1Form(playerName, playerScore,  speed, snake, food);
            playGame.ShowDialog();
        }
    }
}
