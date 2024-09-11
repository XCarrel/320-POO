using System;
using System.Threading;

namespace ChickenGame
{
    class Program
    {
        // Console dimensions
        static int consoleWidth = 40;
        static int consoleHeight = 20;

        // Chicken's initial position
        static int chickenX = consoleWidth / 2;
        static int chickenY = consoleHeight - 2;

        // Egg's position
        static int eggX = -1;
        static int eggY = -1;

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            bool running = true;

            while (running)
            {
                // Draw the game
                Draw();

                // Handle input
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            if (chickenX > 0) chickenX--;
                            break;
                        case ConsoleKey.RightArrow:
                            if (chickenX < consoleWidth - 1) chickenX++;
                            break;
                        case ConsoleKey.Spacebar:
                            if (eggY == -1) // If no egg is currently thrown
                            {
                                eggX = chickenX;
                                eggY = chickenY - 1;
                            }
                            break;
                        case ConsoleKey.Escape:
                            running = false;
                            break;
                    }
                }

                // Move the egg
                if (eggY > -1)
                {
                    eggY--;
                    if (eggY < 0)
                    {
                        eggY = -1; // Reset the egg when it goes off-screen
                    }
                }

                // Control the game speed
                Thread.Sleep(100);
            }
        }

        static void Draw()
        {
            Console.Clear();

            // Draw the chicken
            Console.SetCursorPosition(chickenX, chickenY);
            Console.WriteLine(" (o>");

            // Draw the egg
            if (eggY > -1)
            {
                Console.SetCursorPosition(eggX, eggY);
                Console.WriteLine("*");
            }

            // Draw the ground (for visual reference)
            for (int i = 0; i < consoleWidth; i++)
            {
                Console.SetCursorPosition(i, consoleHeight - 1);
                Console.Write("-");
            }
        }
    }
}