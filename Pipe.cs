using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BirdJump
{
    class Pipe
    {
        public int height, gapSize;
        public int width = 60;
        public int x;

        public Pipe(int _height, int _gap, Size ss)
        {
            height = _height;
            gapSize = _gap;
            x = ss.Width;
        }

        public void Move()
        {
            x -= 5;
        }
    }
}
