using System;
using System.Drawing;

namespace SnakeGame
{
    public class Food
    {
        public Brush Brush { get; set; }
        public Rectangle Piece;
        private int x, y, width = 10, height = 10;
       // private int rand = 1;
        public Food(Random rand)
        {
            Generate(rand);
            Piece = new Rectangle(x, y, width, height);
            Brush = Brushes.Red;
           
        }
        public void Draw(Graphics graphics)
        {
            Piece.X = x;
            Piece.Y = y;
            graphics.FillRectangle(Brush, Piece);
        }

        public void Generate(Random rand)
        {
            x = rand.Next(0, 50) * 10;
            y = rand.Next(0, 40) * 10;

        }
    }
}
