using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdJump
{
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();
            //show image of chosen bird
            switch (Form1.playerColour)
            {
                case "reg":
                    birdBox.BackgroundImage = Properties.Resources.goodbird7;
                    break;
                case "cardinal":
                    birdBox.BackgroundImage = Properties.Resources.goodbird8;
                    break;
                case "bluejay":
                    birdBox.BackgroundImage = Properties.Resources.goodbird9;
                    break;
            }
        }

        private void GameOverScreen_Load(object sender, EventArgs e)
        {
            //display final score
            finalScoreLabel.Text = $"Final Score: {Form1.points}";
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new GameScreen());
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new MenuScreen());
        }
    }
}
