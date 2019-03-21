using System;

namespace hw_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1:");
            Task1();
            Console.WriteLine();

            Console.WriteLine("Task 2:");
            Task2();
            Console.WriteLine();

            Console.WriteLine("Task 3:");
            Task3();
            Console.WriteLine();

            Console.Read();
        }

        public static void Task1()
        {
            int arrSize = 5;

            int[] randomArr = FillArrayRandom(new int[arrSize], 0, arrSize);

            Console.WriteLine($"Enter {arrSize} integer to fill an array");
            int[] userArr = FillArrayByUser(new int[arrSize], 0, arrSize);

            int[] resultArr = new int[arrSize];
            for (int i = 0; i < arrSize; i++)
            {
                resultArr[i] = userArr[i] + randomArr[i];
            }

            Console.WriteLine("Random array values:");
            PrintArray(randomArr);
            Console.WriteLine();

            Console.WriteLine("User array values:");
            PrintArray(userArr);
            Console.WriteLine();

            Console.WriteLine("Result array values:");
            PrintArray(resultArr);
            Console.WriteLine();
        }

        public static void Task2()
        {
            int arrSize = 10;
            int arrFillSize = 9;

            Console.WriteLine($"Enter {arrFillSize} integer to fill array");
            int[] userArr = FillArrayByUser(new int[arrSize], 0, arrFillSize);

            Console.WriteLine("Initial array:");
            PrintArray(userArr);
            Console.WriteLine();

            int insertIndex = RequestInteger($"Enter insert index from 0 to {arrSize - 1}:", 0, arrSize);
            int insertValue = RequestInteger("Enter integer to insert:");

            Insert(userArr, insertIndex, insertValue);

            Console.WriteLine("Result array:");
            PrintArray(userArr);
        }

        public static void Task3()
        {
            int arrSize = 11;
            int[] randomArr = FillArrayRandom(new int[11], 0, arrSize);

            Console.WriteLine("Initial array:");
            PrintArray(randomArr);
            Console.WriteLine();

            Reverse(randomArr);

            Console.WriteLine("Result array:");
            PrintArray(randomArr);

        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        public static int[] Insert(int[] arr, int index, int value)
        {
            for (int i = arr.Length - 1; i >= index && i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[index] = value;

            return arr;
        }

        public static int[] FillArrayByUser(int[] arr, int from, int to)
        {
            for (int i = from; i < to; i++)
            {
                arr[i] = RequestInteger();
            }

            return arr;
        }

        public static int[] FillArrayRandom(int[] arr, int from, int to)
        {
            Random randomGenerator = new Random();
            for (int i = from; i < to; i++)
            {
                arr[i] = randomGenerator.Next(0, 100);
            }

            return arr;
        }

        public static T[] Reverse<T>(T[] arr)
        {
            int arrHalf = arr.Length / 2;
            for (int i = 0; i < arrHalf; i++)
            {
                int reverseIndex = arr.Length - 1 - i;
                var reverseValue = arr[reverseIndex];

                arr[reverseIndex] = arr[i];
                arr[i] = reverseValue;
            }

            return arr;
        }

        public static int RequestInteger()
        {
            int value;

            while (true)
            {
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Entered value is not valid. Enter integer please.");
                }
            }
        }

        public static int RequestInteger(string requestTitle)
        {
            Console.WriteLine(requestTitle);
            int value;

            while (true)
            {
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Entered value is not valid. Enter integer please.");
                }
            }
        }

        public static int RequestInteger(string requestTitle, int from, int to)
        {
            Console.WriteLine(requestTitle);
            int value;

            while (true)
            {
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out value))
                {
                    if (value >= from && value < to)
                    {
                        return value;
                    } else
                    {
                        Console.WriteLine($"Entered value is not valid. Enter from {from} up to {to} please.");
                    }
                }
                else
                {
                    Console.WriteLine("Entered value is not valid. Enter integer please.");
                }
            }
        }
    }
}
