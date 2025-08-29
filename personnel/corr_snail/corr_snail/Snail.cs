using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace corr_snail
{
    public class Snail
    {
        // Attributs

        public int plife = 50;           // Points de vie
        public int x = 0;                // Position
        public int y = 0;                // Position
        public string alive = "_@_ö";    // Escargot "vivant"
        public string dead = "____";     // Escargot "mort"

        // Constructeur

        public Snail(int starty)        // public Snail(int y)
        {
            y = starty;                 // This.y = y;
        }

        public Snail()
        {
            y = 12;
        }

        // Méthodes

        public void Move()
        {
            x++;
            plife--;
        }
    }
}
