using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaClub
{
    internal class Para
    {
        private const int PARA_HEIGHT = 6;

        private string[] withoutParachute =
        {
             @"     ",
             @"     ",
             @"     ",
             @"  o  ",
             @" /░\ ",
             @" / \ ",
        };

        private string[] withParachute =
        {
             @" ___ ",
             @"/|||\",
             @"\   /",
             @" \o/ ",
             @"  ░  ",
             @" / \ ",
        };

        public string name;
        public int x;
        public int altitude;
        public bool parachuteIsOpen;

        public Para(string name)
        {
            this.name = name;
        }

        public void update()
        {
            if (altitude > PARA_HEIGHT)
            {
                if (parachuteIsOpen)
                {
                    altitude -= 1;
                }
                else
                {
                    altitude -= 3;
                }
                if (altitude < Config.SCREEN_HEIGHT / 2)
                {
                    parachuteIsOpen = true;
                }
            }
            else // il est au sol
            {
                parachuteIsOpen = false;
            }
        }
        public void draw()
        {
            string[] view = parachuteIsOpen ? withParachute : withoutParachute;
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(x, Config.SCREEN_HEIGHT - this.altitude + i);
                Console.WriteLine(view[i]);
            }
            Console.SetCursorPosition(x, Config.SCREEN_HEIGHT - this.altitude - 1);
            Console.Write(this.name);
        }
    }
}
