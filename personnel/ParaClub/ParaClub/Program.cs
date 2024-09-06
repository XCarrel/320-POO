namespace ParaClub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane();
            Console.CursorVisible = false;
            while (true)
            {
                Console.Clear();

                plane.update();

                plane.draw();

                Thread.Sleep(100);
            }
        }
    }
}