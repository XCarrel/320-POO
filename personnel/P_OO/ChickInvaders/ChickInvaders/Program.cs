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
            List<Chick> fleet= new List<Chick>();
            fleet.Add(new Chick(Land.WIDTH / 2, Land.HEIGHT / 2, "Joe"));

            // Démarrage
            Application.Run(new Land(fleet));
        }
    }
}