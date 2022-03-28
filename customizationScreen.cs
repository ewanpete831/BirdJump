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
    public partial class customizationScreen : UserControl
    {
        public customizationScreen()
        {
            InitializeComponent();
        }
        
        //change global player colour to selected colour
        private void pidgeonButton_Click(object sender, EventArgs e)
        {
            Form1.playerColour = "reg";
            Form1.ChangeScreen(this, new MenuScreen());
        }

        private void cardinalButton_Click(object sender, EventArgs e)
        {
            Form1.playerColour = "cardinal";
            Form1.ChangeScreen(this, new MenuScreen());
        }

        private void jayButton_Click(object sender, EventArgs e)
        {
            Form1.playerColour = "bluejay";
            Form1.ChangeScreen(this, new MenuScreen());
        }
    }
}
