using System;

namespace hw_04_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ConsoleKey direction = Console.ReadKey().Key;
                Console.WriteLine();

                switch (direction)
                {
                    case ConsoleKey.W:
                        Console.WriteLine("Top");
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine("Down");
                        break;
                    case ConsoleKey.A:
                        Console.WriteLine("Left");
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine("Right");
                        break;
                    default:
                        Console.WriteLine("Direction is not defined");
                        break;
                }
            }
        }
    }
}
