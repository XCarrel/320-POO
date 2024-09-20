namespace ChickInvaders
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Création de la flotte de drones
            List<Chick> coop= new List<Chick>();
            List<Foes> ufo = new List<Foes>();
            coop.Add(new Chick(Land.WIDTH / 2, Land.HEIGHT / 2, "Joe"));
            ufo.Add(new Foes(Land.WIDTH, Land.HEIGHT / 2, "Arthur"));
            // Démarrage
            Application.Run(new Land(coop, ufo));
        }
    }
}