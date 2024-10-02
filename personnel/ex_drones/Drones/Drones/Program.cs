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
            List<Drone> fleet = new List<Drone>();
            List<Building> area = new List<Building>();
            Console.WriteLine("Nombre de drones :");
            string nbDrones = Console.ReadLine();
            int nb;
            if (int.TryParse(nbDrones, out nb))
            {
                if (nb <= 10)
                {
                    for (int i = 0; i < nb; i++)
                    {
                        Drone drone = new Drone();
                        drone.Attributs(100, 100, "joe");
                        fleet.Add(drone);
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        Building building = new Building();
                        area.Add(building);
                        building.UpdateB();
                    }
                    try
                    {
                        // Démarrage
                        Application.Run(new AirSpace(fleet, area));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("La valeur doit valoire 10 ou moins !");
                }
            }
            else
            {
                Console.WriteLine("Valeur incorrecte !");
            }
        }
    }
}