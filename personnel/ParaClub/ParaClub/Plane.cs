using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaClub
{
    internal class Plane
    {
        public const int WIDTH = 28;
        public const int HEIGHT = 6;

        public int x;
        public int altitude;
        private string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };

        public Plane()
        {
            x = 0;
            altitude = Config.SCREEN_HEIGHT;
        }
        public void draw()
        {

        }

        public void update()
        {

        }
    }
}
