namespace ParaClub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane();
            Console.CursorVisible = false;
            while (plane.vie > 0)
            {
                plane.update();

                Console.Clear();
                plane.draw();

                Thread.Sleep(100);
            }
        }
    }
}