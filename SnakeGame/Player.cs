using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Player
    {
        Random randName = new Random();
        string[] names = new string[10] { "Blind Sally", "Kristin", "Ham Face", "Pippi NoStockings", "Jabba", "Pyro",
                                            "Smelly Dave", "The Stache", "Lionel the Klepto", "Lice Inspector Tammy"  };

        public  static Int32 Score { get; set; }
        public  static int FoodColor { get; set; }
        public  static int SnakeColor { get; set; }
        public  static int Speed { get; set; }
        public  static string Name { get; set; }
        public static List<Int32> ScoreList { get; set; }

        //Default constructor - If no name is entered
        public Player()
        {
            Name = names[randName.Next(10)];

        }

        //When a name is entered
        public Player(string name)
        {
            Name = name;
            Score = 0;
        }
        
        //all perameters
        public Player(string _name, int _score, int _foodColor, int _snakeColor, int _speed, List<Int32> _scoreList)
        {
            Name = _name;
            Score = _score;
            FoodColor = _foodColor;
            SnakeColor = _snakeColor;
            Speed = _speed;
            
            ScoreList = _scoreList;

        }
    }
}
