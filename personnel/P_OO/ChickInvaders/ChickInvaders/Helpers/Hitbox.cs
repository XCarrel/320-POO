using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickInvaders.Helpers
{
    public partial class Hitbox
    {
        public int hX;
        public int hY;
        public int Width;
        public int Height;

        public Hitbox(int hX, int hY, int width, int height)
        {
            this.hX = hX;
            this.hY = hY;
            Width = width;
            Height = height;
        }

        public bool Intersects(Hitbox other)
        {
            return hX <other.hX + other.Width &&
        }
    }
}
