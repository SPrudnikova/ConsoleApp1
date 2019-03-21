using System;

namespace practice_21_03_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            int[] emptyArr = CreateEmptyIntArray();
            Console.WriteLine($"Empty array length: {emptyArr.Length}");
            Console.WriteLine();

            Console.WriteLine("Task 2");
            CreateMixedArray();
            Console.WriteLine();

            Console.Read();
        }

        public static int[] CreateEmptyIntArray()
        {
            return new int[0];
        }

        public static void CreateMixedArray()
        {
            dynamic[] mixedArray= new dynamic[3];
            mixedArray[0] = 32;
            mixedArray[1] = 'A';
            mixedArray[2] = "Hello";

            for (int i = 0; i < mixedArray.Length; i++)
            {
                Console.Write($"{mixedArray[i]} ");
            }

            Console.WriteLine();

            mixedArray[0] = mixedArray[0] + 10;
            mixedArray[2] = mixedArray[2] + ", guys!";

            for (int i = 0; i < mixedArray.Length; i++)
            {
                Console.Write($"{mixedArray[i]} ");
            }
        }
    }
}
