using corr_snail;
namespace corr_snail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Snail> snails = new List<Snail>();

            for (int i = 0; i < 10; i++)
            {
                snails.Add(new Snail);
            }

            Console.CursorVisible = false;
            while (snails[0].plife > 0)
            {
                Console.Clear();
                foreach (Snail snail in snails)
                {
                    Console.SetCursorPosition(snail.x, snail.y);
                    Console.Write(snail.alive);
                    snail.Move();
                }
            }
            Console.SetCursorPosition(snail.x, snail.y);
            Console.Write(toto.dead);
            Console.SetCursorPosition(titi.x, titi.y);
            Console.Write(titi.dead);
            Console.ReadLine();
        }
    }
}
