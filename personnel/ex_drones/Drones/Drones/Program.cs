using Drones.View;

namespace Drones
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
            List<Drone> fleet= new List<Drone>();
            Drone drone = new Drone();
            Attributs()
            fleet.Add(drone);

            List<Building> area = new List<Building>();
            for (int i = 0; i < 10; i++)
            {
                Building building = new Building();
                area.Add(building);
                building.UpdateB();
            }

            // Démarrage
            Application.Run(new AirSpace(fleet, area));
        }
    }
}