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
        private int _speedX = 0;
        private int _speedY = 0;
        public bool isFacingLeft;

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

        public void GoLeft(int speed)
        {
            _speedX = -speed;
            isFacingLeft = true;
        }
        public void GoRight(int speed)
        {
            _speedX = +speed;
        }
        public void GoUp(int speed)
        {
            _speedY = -speed;
        }
        public void GoDown(int speed)
        {
            _speedY = +speed;
        }
        public void MoveUp()
        {
            _y -= _speedY;
        }
        public void MoveDown()
        {
            _y += _speedY;
        }
        public void MoveLeft()
        {
            _x -= _speedX;
        }
        public void MoveRight()
        {
            _x += _speedX;
        }

        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update(int interval)
        {
            _x += _speedX;
            _y += _speedY;
        }
    }
}
