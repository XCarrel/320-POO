namespace ParaClub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            ConsoleKeyInfo keyPressed;

            List<Para> parachutistsInTheAir = new List<Para>();
            Console.CursorVisible = false;

            Plane plane = new Plane();
            for (int i = 0; i < 8; i++)
            {
                plane.board(new Para("Bob " + i.ToString()));
            }

            while (true)
            {
                Console.Clear();
                if (Console.KeyAvailable) // L'utilisateur a pressé une touche
                {
                    keyPressed = Console.ReadKey(false);
                    switch (keyPressed.Key)
                    {
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                        case ConsoleKey.Spacebar:
                            Para jumper = plane.dropParachutist();
                            parachutistsInTheAir.Add(jumper);
                            break;
                        default:
                            break;
                    }
                }
                plane.update();
                foreach (Para para in parachutistsInTheAir)
                {
                    para.update();
                }

                plane.draw();
                foreach (Para para in parachutistsInTheAir)
                {
                    para.draw();
                }
                Thread.Sleep(100);
            }
        }
    }
}