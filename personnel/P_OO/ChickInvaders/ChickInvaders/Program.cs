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
            // Cr�ation des listes des entit�s
            List<Chick> coop= new List<Chick>();
            List<Foes> ufo = new List<Foes>();
            List<Foes2> ufo2 = new List<Foes2>();
            List<Projectile> projectiles = new List<Projectile>();
            List<Eggs> eggs = new List<Eggs>();
            coop.Add(new Chick(Land.WIDTH / 2, Land.HEIGHT / 2, "Joe"));

            ufo.Add(new Foes(1200, 0, "Sajad"));
            ufo.Add(new Foes(1200, 0, "Arthur"));
            ufo.Add(new Foes(1200, 0, "Ricardo"));
            ufo.Add(new Foes(1200, 0, "Gabriel"));
            ufo.Add(new Foes(1200, 0, "Pubert"));
            ufo.Add(new Foes(1200, 0, "Arnold"));
            ufo2.Add(new Foes2(0, 0, "Sambi"));
            ufo2.Add(new Foes2(0, 0, "Miguel"));
            ufo2.Add(new Foes2(0, 0, "Andr�"));
            ufo2.Add(new Foes2(0, 0, "Lucio"));
            ufo2.Add(new Foes2(0, 0, "Joe"));
            //ufo.Add(new Foes(0, 70, "Arthauer"));
            // D�marrage
            Application.Run(new Land(coop, ufo, ufo2, projectiles, eggs));
        }
    }
}