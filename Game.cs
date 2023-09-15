namespace Criminal
{
    internal class Game
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criminal: Interactive Antisocial Stories Generator\n");
            Console.WriteLine("1. New");
            Console.WriteLine("2. Continue");
            Console.WriteLine("0. Exit");
            switch (Console.ReadLine())
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    break;
                case "2":
                    break;    
            }
        }
    }
}