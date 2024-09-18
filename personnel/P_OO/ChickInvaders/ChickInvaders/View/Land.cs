using System.Security.Cryptography.X509Certificates;

namespace ChickInvaders
{
    // La classe AirSpace représente le territoire au dessus duquel les drones peuvent voler
    // Il s'agit d'un formulaire (une fenêtre) qui montre une vue 2D depuis en dessus
    // Il n'y a donc pas de notion d'altitude qui intervient

    public partial class Land : Form
    {
        public static readonly int WIDTH = 1200;        // Dimensions of the airspace
        public static readonly int HEIGHT = 600;

        // La flotte est l'ensemble des drones qui évoluent dans notre espace aérien
        private List<Chick> coop;

        BufferedGraphicsContext currentContext;
        BufferedGraphics airspace;

        // Initialisation de l'espace aérien avec un certain nombre de drones
        public Land(List<Chick> coop)
        {
            InitializeComponent();
            // Gets a reference to the current BufferedGraphicsContext
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Move);
            currentContext = BufferedGraphicsManager.Current;
            // Creates a BufferedGraphics instance associated with this form, and with
            // dimensions the same size as the drawing surface of the form.
            airspace = currentContext.Allocate(this.CreateGraphics(), this.DisplayRectangle);
            this.coop = coop;
        }

        // Affichage de la situation actuelle
        private void Render()
        {
            airspace.Graphics.Clear(Color.AliceBlue);

            // draw chicks
            foreach (Chick chick in coop)
            {
                chick.Render(airspace);
            }

            airspace.Render();
        }

        public void Move(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            foreach (Chick chick in coop)
            {
                switch (e.KeyCode)
                {
                    case Keys.W:
                        chick.MoveUp();
                        break;
                    case Keys.S:
                        chick.MoveDown();
                        break;
                    case Keys.D:
                        chick.MoveRight();
                        break;
                    case Keys.A:
                        chick.MoveLeft();
                        break;
                }
            }
        }

        // Calcul du nouvel état après que 'interval' millisecondes se sont écoulées
        private void Update(int interval)
        {
            foreach (Chick chick in coop)
            {
                chick.Update(interval);
            }
        }

        // Méthode appelée à chaque frame
        private void NewFrame(object sender, EventArgs e)
        {
            this.Update(ticker.Interval);
            this.Render();
        }
    }
}