using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SnakeGame
{
    public class Snake
    {
        public Brush Brush { get; set; }
        public Rectangle rect;
        public static int x { get; set; }
        public static int y { get; set; }
        public  Rectangle[] Body;
        //private int x = 0, y = 0, width = 10, height = 10;
        private const int Width = 10, Height = 10;
        private string color;
        //public Snake(int _x, int _y)
        //{
        //    x = _x;
        //    y = _y;
        //}

        public Snake()
        {
            Body = new Rectangle[1];
            Body[0] = new Rectangle(x, y, Width, Height);
            Brush = Brushes.Green;

        }
        public void Draw()
        {
            for (int i = Body.Length - 1; i > 0; i--)
                Body[i] = Body[i - 1];
          
        }
        public void Draw(Graphics graphics)
        {
          
            graphics.FillRectangles(Brush, Body);
        }

        



        public void  Move(int direction) // 0 = Right, 1 = Down, 2 = Left, 3 = Up
        {
            Draw();
            switch(direction)
            {
                case 0:
                    Body[0].X += 10;
                    break;
                case 1:
                    Body[0].Y += 10;
                    break;
                case 2:
                    Body[0].X -= 10;
                    break;
                case 3:
                    Body[0].Y -= 10;
                    break;
            }
                
        }

        public void Grow()
        {
            List<Rectangle> temp = Body.ToList();
            temp.Add(new Rectangle(Body[Body.Length - 1].X, Body[Body.Length - 1].Y, Width, Height));
            Body = temp.ToArray();
        }

       

        //public string playerName;
        //private int playerScore = 1;
        //private Int32 snakeColor;
        //private int foodColor;
        //private int speed;
        //public List<Int32> ScoreList = new List<Int32>();

        //public Player(string _name, int _score, int _foodColor, int _snakeColor, int _speed, List<Int32> _scoreList)
        //{
        //    Name = _name;
        //    Score = _score;
        //    FoodColor = _foodColor;
        //    SnakeColor = _snakeColor;
        //    Speed = _speed;

        //    ScoreList = _scoreList;


        //}


    }
}
