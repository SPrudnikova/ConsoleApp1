using System;

namespace hw_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1: string from single line to multi line");
            Task1();
            Console.WriteLine();

            Console.Read();
        }

        public static void Task1()
        {
            Console.WriteLine("Enter string, insert ; where new line should start:");
            string inputString = Console.ReadLine();
            string[] stringArr = inputString.Split(';');
            ReplaceOToA(stringArr);
            PrintAsColumn(stringArr);
        }

        public struct PairToReplace
        {
            public string from, to;

            public PairToReplace(string oldValue, string newValue)
            {
                from = oldValue;
                to = newValue;
            }
        }

        public static void ReplaceOToA(string[] arr)
        {
            PairToReplace[] pairsToReplace = new PairToReplace[4] {
                // latin
                new PairToReplace("o", "a"),
                new PairToReplace("O", "A"),
                // cyrillic
                new PairToReplace("о", "а"),
                new PairToReplace("О", "А")
            };

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Replace(arr[i], pairsToReplace);
            }
        }

        public static void PrintAsColumn(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].TrimStart());
            }
        }

        public static string Replace(string value, PairToReplace[] pairsToReplace)
        {
            string formattedString = value;

            for (int i = 0; i < pairsToReplace.Length; i++)
            {
                formattedString = formattedString.Replace(pairsToReplace[i].from, pairsToReplace[i].to);
            }

            return formattedString;
        }
    }
}
