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
            List<Foes2> ufo2 = new List<Foes2>();
            List<Projectile> projectiles = new List<Projectile>();
            List<Eggs> eggs = new List<Eggs>();
            coop.Add(new Chick(Land.WIDTH / 2, Land.HEIGHT / 2, "Joe"));
            ufo.Add(new Foes(15, 70, "Arthur"));
            ufo.Add(new Foes(120, 2, "Ricardo"));
            ufo.Add(new Foes(580, 120, "Ricardo"));
            ufo.Add(new Foes(120, 2, "Ricardo"));
            ufo.Add(new Foes(580, 120, "Ricardo"));
            ufo2.Add(new Foes2(20, 30, "Fabrice"));
            ufo2.Add(new Foes2(130, 80, "Fabrice"));
            ufo2.Add(new Foes2(90, 130, "Fabrice"));
            ufo2.Add(new Foes2(130, 80, "Fabrice"));
            ufo2.Add(new Foes2(90, 130, "Fabrice"));
            projectiles.Add(new Projectile(20, 20));
            //eggs.Add(new Eggs(10, 10));

            ufo.Add(new Foes(15, 15, "Arthur"));
            //ufo.Add(new Foes(0, 70, "Arthauer"));
            // Démarrage
            Application.Run(new Land(coop, ufo, ufo2, projectiles, eggs));
        }
    }
}