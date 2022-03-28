using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Drawing2D;
using System.Media;

namespace BirdJump
{
    public partial class GameScreen : UserControl
    {
//global variables, lists, and player
        int pipeTimer = 0;
        int nextPipeCount;
        SoundPlayer boing = new SoundPlayer(Properties.Resources.boing);
        SoundPlayer deathSound = new SoundPlayer(Properties.Resources.deathSound);
        
        Size screenSize = new Size(400, 400);

        bool canGetPoints = true;
        bool canJump = true;
        
        Player p1 = new Player(0, 0, 400, Form1.playerColour);
        List<Pipe> pipes = new List<Pipe>();

        Random randGen = new Random();

        public GameScreen()
        {
            InitializeComponent();
            InitializeGame();
        }
        public void InitializeGame()
        {
            //reset variables whenever game starts
            gameOverLabel.Visible = false;
            Form1.points = 0;
            p1.y = 185;
            p1.x = 150;
            p1.ySpeed = 0;
            nextPipeCount = 0;
        }

        //controls
        private void GameScreen_MouseDown(object sender, MouseEventArgs e)
        {
            if (p1.y > 0)
            {
                p1.ySpeed = -6;
                boing.Play();
            }
        }
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    if (p1.y > 0 && canJump == true)
                    {
                        p1.ySpeed = -6;
                        canJump = false;
                    }
                    break;
            }
        }
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    canJump = true;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            pipeTimer++;

            //create a new pipe at random intervals
            if (pipeTimer > nextPipeCount)
            {
                NewPipe();
                nextPipeCount = randGen.Next(35, 60);
            }

            //check pipe collison, and points
            foreach (Pipe p in pipes)
            {
                p.Move();

                if (p1.Collision(p) == true)
                {
                    EndGame();
                }
                if (p1.Point(p) == true)
                {
                    if (canGetPoints == true)
                    {
                        Form1.points++;
                        canGetPoints = false;
                    }
                }
                if (p1.ExitPipe(p) == true)
                {
                    canGetPoints = true;
                }
            }

            //remove old pipes
            for(int i = 0; i < pipes.Count; i++)
            {
                if (pipes[i].x < 0 - pipes[i].width)
                {
                    pipes.RemoveAt(i);
                }
            }

            //move player
            p1.Move();

            if (p1.y > ClientSize.Height)
            {
                EndGame();
            }

            Refresh();
        }
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            pointsLabel.Text = $"{Form1.points}";

            //draw player
            switch (p1.colour)
            {
                case "reg":
                    e.Graphics.DrawImage(RotateImage(Properties.Resources.goodbird4, p1.ySpeed * 3), p1.x - 10, p1.y - 8);
                    //e.Graphics.DrawImage(Properties.Resources.goodbird4, p1.x - 10, p1.y - 8);
                    break;
                case "cardinal":
                    e.Graphics.DrawImage(RotateImage(Properties.Resources.goodbird5, p1.ySpeed * 3), p1.x - 10, p1.y - 8);
                    //e.Graphics.DrawImage(Properties.Resources.goodbird5, p1.x - 10, p1.y - 8);
                    break;
                case "bluejay":
                    e.Graphics.DrawImage(RotateImage(Properties.Resources.goodbird6, p1.ySpeed * 3), p1.x - 10, p1.y - 8);
                    //e.Graphics.DrawImage(Properties.Resources.goodbird6, p1.x - 10, p1.y - 8);
                    break;
            }
            //draw pipes
            foreach (Pipe p in pipes)
            {
                e.Graphics.FillRectangle(Brushes.Green, p.x, 0, p.width, p.height);
                e.Graphics.FillRectangle(Brushes.DarkGreen, p.x, p.height - 5, p.width, 5);
                e.Graphics.FillRectangle(Brushes.Green, p.x, (p.height + p.gapSize), p.width, ClientSize.Height - (p.height + p.gapSize));
                e.Graphics.FillRectangle(Brushes.DarkGreen, p.x, p.height + p.gapSize, p.width, 5);
            }
        }

        private void EndGame()
        {
            //end the game and change to gameover screen
            deathSound.Play();
            gameTimer.Enabled = false;
            gameOverLabel.Visible = true;
            Refresh();
            Thread.Sleep(1000);
            Form1.ChangeScreen(this, new GameOverScreen());
        }
        private void NewPipe()
        {
            pipes.Add(new Pipe(randGen.Next(50, 250), randGen.Next(80, 120), screenSize));
            pipeTimer = 0;
        }

        public Bitmap RotateImage(Image image, float angle)
        {
            PointF offset = new PointF((float)image.Width / 2, (float)image.Height / 2);

            //create a new empty bitmap to hold rotated image
            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            //make a graphics object from the empty bitmap
            Graphics g = Graphics.FromImage(rotatedBmp);

            //Put the rotation point in the center of the image
            g.TranslateTransform(offset.X, offset.Y);

            //rotate the image
            g.RotateTransform(angle);

            //move the image back
            g.TranslateTransform(-offset.X, -offset.Y);

            //draw passed in image onto graphics object
            g.DrawImage(image, new PointF(0, 0));

            return rotatedBmp;
        }
    }
}
