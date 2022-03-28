using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace BirdJump
{
    class Player
    {
        public int y, x, ySpeed;
        public int xsize = 40;
        public int ysize = 46;
        public string colour;
        int fallCount = 0;
        int screenHeight;
        public Player(int _y, int _ySpeed, int _screenHeight, string _colour)
        {
            y = _y;
            ySpeed = _ySpeed;
            screenHeight = _screenHeight;
            colour = _colour;
        }

        public void Move()
        {
            fallCount++;

            if (fallCount > 1)
            {
                ySpeed++;
                fallCount = 0;
            }

            y += ySpeed;
        }

        public bool Collision(Pipe p)
        {
            //setup rectangles
            Rectangle playerFrontRect = new Rectangle(x + xsize / 2, y + 2, xsize / 2, (ysize / 3) * 2);
            Rectangle playerBackRect = new Rectangle(x, y + ysize / 2, xsize, ysize / 2);
            Rectangle pipeTopRect = new Rectangle(p.x, 0, p.width, p.height);
            Rectangle pipeBotRect = new Rectangle(p.x, p.height + p.gapSize, p.width, screenHeight - (p.height + p.gapSize));

            //check if player collides with either top or bottom pipe
            if (playerFrontRect.IntersectsWith(pipeTopRect) || playerFrontRect.IntersectsWith(pipeBotRect))
            {
                return true;
            }
            if (playerBackRect.IntersectsWith(pipeTopRect) || playerBackRect.IntersectsWith(pipeBotRect))
            {
                return true;
            }
            return false;
        }
        public bool Point(Pipe p)
        {
            //create rectangles
            Rectangle pointRect = new Rectangle(p.x + p.width / 2, p.height, 1, p.gapSize);
            Rectangle playerRect = new Rectangle(x, y, xsize, ysize);

            //check if player enters a gap between two pipes
            if(playerRect.IntersectsWith(pointRect))
            {
                return true;
            }
            return false;
        }
        public bool ExitPipe(Pipe p)
        {
            //create rectangles
            Rectangle playerRect = new Rectangle(x, y, xsize, ysize);
            Rectangle exitRect = new Rectangle(p.x + p.width + 5, p.height, 1, p.gapSize);

            //check if player exits gap between two pipes
            if(playerRect.IntersectsWith(exitRect))
            {
                return true;
            }
            return false;
        }
    }
}
