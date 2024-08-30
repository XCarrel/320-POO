using System.Numerics;

namespace ex_parachutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Modifier le modèle (ce qui *est*)
                plane.update();
                ...

                // Modifier ce que l'on *voit*
                Console.Clear();
                plane.draw();

                // Temporiser
                Thread.Sleep(100);
            }
        }
    }
}
