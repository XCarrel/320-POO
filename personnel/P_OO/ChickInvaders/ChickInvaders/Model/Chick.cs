namespace ChickInvaders
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Chick
    {
        public static readonly int FULLCHARGE = 1000;   // Charge maximale de la batterie
        private int _charge;                            // La charge actuelle de la batterie
        private string _name;                           // Un nom
        private int _x;                                 // Position en X depuis la gauche de l'espace aérien
        private int _y;                                 // Position en Y depuis le haut de l'espace aérien
        private Image chickImage;

        // Constructeur
        public Chick(int x, int y, string name)
        {
            _x = x;
            _y = y;
            _name = name;
            _charge = FULLCHARGE;
            //_charge = GlobalHelpers.alea.Next(FULLCHARGE); // La charge initiale de la batterie est choisie aléatoirement

            chickImage = Image.FromFile("chick.png");
        }
        public int X { get { return _x;} }
        public int Y { get { return _y;} }
        public string Name { get { return _name;} }

        public void MoveUp()
        {
            _y -= 2;
        }
        public void MoveDown()
        {
            _y += 2;
        }
        public void MoveLeft()
        {
            _x -= 2;
        }
        public void MoveRight()
        {
            _x += 2;
        }

        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update(int interval)
        {
        }

    }
}
