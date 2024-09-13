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
            drone.x = 100;
            drone.y = 100;
            drone.name = "Joe";
            fleet.Add(drone);

            List<Building> area = new List<Building>();
            Building building = new Building();
            for (int i = 0; i < 3; i++)
            {
                building.emplacementX = 400;
                building.emplacementY = random.Next(0, 100);
                area.Add(building);
            }

            // Démarrage
            Application.Run(new AirSpace(fleet, area));
        }
    }
}