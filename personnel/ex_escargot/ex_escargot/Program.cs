namespace ex_escargot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(0, 15);
            Console.Write("_@_ö");
            int vie = 50;
            for (int i = 0; i < vie; i++)
            {
                Console.Clear();
                Console.SetCursorPosition(i, 15);
                Console.Write("_@_ö");
                Thread.Sleep(100);
            }
            Console.Clear();
            Console.SetCursorPosition(vie, 15);
            Console.Write("____");
            Console.Read();
        }
    }
}
