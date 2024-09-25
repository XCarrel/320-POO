using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickInvaders
{
    public partial class Foes
    {
        public static readonly int FULLCHARGE = 1000;   // Charge maximale de la batterie
        private int _charge;                            // La charge actuelle de la batterie
        private string _name;                           // Un nom
        private int fx;                                 // Position en X depuis la gauche de l'espace aérien
        private int fy;
        private Image foeImage;

        // Constructeur
        public Foes(int x, int y, string name)
        {
            fx = x;
            fy = y;
            _name = name;
            _charge = FULLCHARGE;
            //_charge = GlobalHelpers.alea.Next(FULLCHARGE); // La charge initiale de la batterie est choisie aléatoirement
            foeImage = Image.FromFile("foe1.png");
        }
        public int X { get { return fx; } }
        public string Name { get { return _name; } }

        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void UpdateF(int interval)
        {
            fx++;
        }
    }
}
