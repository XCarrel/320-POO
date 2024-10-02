using ChickInvaders;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.VisualStyles;
using System.Xml;

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
        private List<Foes2> ufo2;
        private List<Projectile> projectiles;
        private List<Eggs> eggs;

        BufferedGraphicsContext currentContext;
        BufferedGraphics airspace;

        private Image background;

        // Initialisation de l'espace aérien avec un certain nombre de drones
        public Land(List<Chick> coop, List<Foes> ufo, List<Foes2> ufo2, List<Projectile> projectiles, List<Eggs> eggs) : base()
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
            this.ufo2 = ufo2;
            this.projectiles = projectiles;
            this.eggs = eggs;
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
            Graphics g = airspace.Graphics;
            g.DrawImage(background, 0, 0, WIDTH, HEIGHT);

            // draw chicks
            foreach (Chick chick in coop)
            {
                chick.Render(airspace);
            }
            foreach (Foes foes in ufo)
            {
                foes.Render(airspace);
            }
            foreach (Foes2 foes2 in ufo2)
            {
                foes2.Render(airspace);
            }
            foreach (Projectile projectile in projectiles)
            {
                projectile.Render(airspace);
            }
            foreach (Eggs eggs in eggs)
            {
                eggs.Render(airspace);
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
                        chick.GoUp(5);
                        break;
                    case Keys.S:
                        chick.GoDown(5);
                        break;
                    case Keys.D:
                        chick.GoRight(5);
                        break;
                    case Keys.A:
                        chick.GoLeft(5);
                        break;
                    case Keys.Space:
                        foreach (Chick c in coop)
                        {
                            eggs.Add(new Eggs(c.X, c.Y));
                        }
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
                int randomX = GlobalHelpers.alea.Next(1, 50);
                foes.UpdateF(interval);
                if (randomX == 1)
                {
                    projectiles.Add(new Projectile(foes.X, foes.Y));
                }
            }
            foreach (Foes2 foes2 in ufo2)
            {
                int randomX = GlobalHelpers.alea.Next(1, 300);
                int randomXX = GlobalHelpers.alea.Next(1, 300);
                foes2.UpdateF2(interval);
                if (randomX == randomXX)
                {
                    projectiles.Add(new Projectile(foes2.X, foes2.Y));
                }
            }
            foreach (Projectile projectile in projectiles)
            {
                projectile.UpdateP(interval);
                if (projectile.Y > 550)
                {
                    projectiles.Remove(projectile);
                    break;
                }
            }
            foreach (Eggs egg in eggs)
            {
                egg.UpdateE(interval);
                if (egg.Y <= 0)
                {
                    eggs.Remove(egg);
                    break;
                }
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