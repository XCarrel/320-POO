using System.ComponentModel;

namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone : IExpellable
    {
        Random alea = new Random();
        private int charge = 1000;                     // La charge actuelle de la batterie
        private string name;                           // Un nom
        private int x ;                                // Position en X depuis la gauche de l'espace aérien
        private int y;                                 // Position en Y depuis le haut de l'espace aérien
        private EvacuationState state;

        public Drone(int x, int y)
        {
            this.x = x;
            this.y = y;
            state = EvacuationState.Free;
        }
        public void Attributs(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public bool Evacuate(Rectangle zone)
        {
            throw new NotImplementedException();
            if (zone.IntersectsWith(new Rectangle(x - 4, y - 2, 8, 8)))
            {
                state = EvacuationState.Evacuating;
                return false;
            }
            else
            {
                state = EvacuationState.Evacuated;
                return true;
            }
        }

        public void FreeFlight()
        {
            throw new NotImplementedException();
            state = EvacuationState.Free;
        }

        public EvacuationState GetEvacuationState()
        {
            throw new NotImplementedException();
            return state;
        }

        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update(int interval)
        {
            x += 2;                                    // Il s'est déplacé de 2 pixels vers la droite
            y += alea.Next(-2, 3);                     // Il s'est déplacé d'une valeur aléatoire vers le haut ou le bas
            charge--;                                  // Il a dépensé de l'énergie
        }
    }
}
