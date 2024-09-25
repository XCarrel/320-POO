using ChickInvaders;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.VisualStyles;

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
        private List<Foes> ufo;

        BufferedGraphicsContext currentContext;
        BufferedGraphics airspace;

        private Image background;

        // Initialisation de l'espace aérien avec un certain nombre de drones
        public Land(List<Chick> coop, List<Foes> ufo) : base()
        {
            InitializeComponent();
            this.Size = new Size(WIDTH, HEIGHT);
            // Gets a reference to the current BufferedGraphicsContext
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Move);
            this.KeyUp += new KeyEventHandler(StopMove);
            currentContext = BufferedGraphicsManager.Current;
            // Creates a BufferedGraphics instance associated with this form, and with
            // dimensions the same size as the drawing surface of the form.
            airspace = currentContext.Allocate(this.CreateGraphics(), this.DisplayRectangle);
            this.coop = coop;
            this.ufo = ufo;
            SetBackgroundImage("background.png");
        }

        public void SetBackgroundImage(string filePath)
        {
            background = Image.FromFile("background.png");
            BackgroundImage = background;
            //this.Invalidate();
        }

        // Affichage de la situation actuelle
        private void Render()
        {
            // draw chicks
            foreach (Chick chick in coop)
            {
                chick.Render(airspace);
            }
            foreach (Foes foes in ufo)
            {
                foes.Render(airspace);
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
                        chick.GoUp(3);
                        break;
                    case Keys.S:
                        chick.GoDown(3);
                        break;
                    case Keys.D:
                        chick.GoRight(3);
                        break;
                    case Keys.A:
                        chick.GoLeft(3);
                        break;
                }
            }
        }

        public void StopMove(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            foreach (Chick chick in coop)
            {
                switch (e.KeyCode)
                {
                    case Keys.W:
                        chick.GoUp(0);
                        break;
                    case Keys.S:
                        chick.GoDown(0);
                        break;
                    case Keys.D:
                        chick.GoRight(0);
                        break;
                    case Keys.A:
                        chick.GoLeft(0);
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
            foreach (Foes foes in ufo)
            {
                foes.UpdateF(interval);
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