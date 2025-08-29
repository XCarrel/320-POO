using Drones;

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
                if (nb > 0 && nb <= 10)
                {
                    for (int i = 0; i < nb; i++)
                    {
                        Drone drone = new Drone(1, 2);
                        drone.Attributs(100, 100, "joe");
                        fleet.Add(drone);
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        area.Add(new Factory(i));
                    }
                    for(int i = 0;i < 2; i++)
                    {
                        area.Add(new Store());
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
                    foreach (Building building in area)
                    {
                        if (building.boxIsCreated)
                        {
                            Box box = new Box();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("La valeur doit être entre 0 et 10 !");
                }
            }
            else
            {
                Console.WriteLine("Valeur incorrecte !");
            }
        }
    }
}