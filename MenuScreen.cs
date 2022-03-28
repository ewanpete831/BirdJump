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
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
            //change picture box to users selected colour
            switch(Form1.playerColour)
            {
                case "reg":
                    birdBox.BackgroundImage = Properties.Resources.goodbird4;
                    break;
                case "cardinal":
                    birdBox.BackgroundImage = Properties.Resources.goodbird5;
                    break;
                case "bluejay":
                    birdBox.BackgroundImage = Properties.Resources.goodbird6;
                    break;
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new GameScreen());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customizeButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new customizationScreen());
        }
    }
}
