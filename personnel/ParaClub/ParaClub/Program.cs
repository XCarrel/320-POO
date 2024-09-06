namespace ParaClub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyPressed;

            Plane plane = new Plane();
            Console.CursorVisible = false;
            while (true)
            {
                Console.Clear();

                plane.update();

                plane.draw();

                Thread.Sleep(100);

                if (Console.KeyAvailable) // L'utilisateur a pressé une touche
                {
                    keyPressed = Console.ReadKey(false);
                    switch (keyPressed.Key)
                    {
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
        }
    }
}