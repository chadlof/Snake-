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
    public partial class WelcomForm : Form
    {
        public string playerName;
        public Int32 playerScore;

        Random randName = new Random();
        string[] names = new string[10] { "Blind Sally", "Kristin", "Ham Face", "Pippi NoStockings", "Jabba", "Pyro",
                                            "Smelly Dave", "The Stache", "Lionel the Klepto", "Lice Inspector Tammy"  };
        public WelcomForm()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

       

        private void startButton_Click(object sender, EventArgs e)
        {
           
            playerName = NameTextBox.Text;

            if (playerName == "")
            {
                
                Player Player1 = new Player();
                playerName = Name = names[randName.Next(10)];
                OptionsForm playGame = new OptionsForm(playerName, playerScore);
                playGame.ShowDialog();
                this.Dispose();
            }

            if (playerName != "")
            {
                
               
                Player Player1 = new Player();
                playerName = NameTextBox.Text;
                OptionsForm playGame = new OptionsForm(playerName, playerScore);
                playGame.ShowDialog();
               
            }
            this.Dispose();





        }
    }
}
