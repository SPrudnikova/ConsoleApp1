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

            Console.WriteLine("Task 3");
            ArrayMaxValue();
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

        public static void ArrayMaxValue()
        {
            int[] randomArr = new int[13];
            Random randomGenerator = new Random();
            for (int i = 0; i < 13; i++)
            {
                randomArr[i] = randomGenerator.Next(0, 100);
            }

            Console.WriteLine("Random array values: ");
            for (int i = 0; i < randomArr.Length; i++)
            {
                Console.Write($"{randomArr[i]} ");
            }

            Console.WriteLine();

            int maxValue = 0;

            for (int i = 0; i < randomArr.Length; i++)
            {
                if (randomArr[i] > maxValue)
                {
                    maxValue = randomArr[i];
                }
            }

            Console.WriteLine($"Max value in array: {maxValue}");
        }
    }
}
