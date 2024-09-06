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
        public int y;
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
            x = 1;
            altitude = 0;
        }
        public void draw()
        {
                for (int j = 0; j < view.Length; j++)
                {
                    Console.SetCursorPosition(x, altitude + j);
                    Console.WriteLine(view[j]);
                }
        }

        public void update()
        {
            x++;
        }
    }
}
