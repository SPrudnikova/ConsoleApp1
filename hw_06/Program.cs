using System;
using System.Collections;

namespace hw_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1: string from single line to multi line");
            Task1();
            Console.WriteLine();

            Console.WriteLine("Task2a: remove the longest word");
            Task2a();
            Console.WriteLine();

            Console.WriteLine("Task2b: swap the longest word and the smallest word");
            Task2b();
            Console.WriteLine();

            Console.WriteLine("Task2c: calculate letters, punctiation");
            Task2c();
            Console.WriteLine();

            Console.WriteLine("Task2d: sort string by words length");
            Task2d();
            Console.WriteLine();

            Console.Read();
        }

        public static void Task1()
        {
            Console.WriteLine("Enter string, insert ; where new line should start:");
            string inputString = RequestInput();
            string[] stringArr = inputString.Split(';');
            ReplaceOToA(stringArr);
            PrintAsColumn(stringArr);
        }

        public static void Task2a()
        {
            Console.WriteLine("Enter string:");
            string inputString = RequestInput();
            string[] longestWords = GetLongestWords(inputString);

            string clearedString = inputString;
            for (int i = 0; i < longestWords.Length; i++)
            {
                clearedString = clearedString.Replace(longestWords[i], String.Empty);
            }

            Console.WriteLine("Cleared string:");
            Console.WriteLine(clearedString);
        }

        public static void Task2b()
        {
            Console.WriteLine("Enter string:");
            string inputString = RequestInput();
            StringInfo[] stringInfoArr = ConvertStringToStringInfoArr(inputString);
            StringInfo[] wordsInfoArr = Array.FindAll(stringInfoArr, stringInfo => stringInfo.IsWord);
            bool allWordsHasSameLength = Array.TrueForAll(wordsInfoArr, w => w.Value.Length == wordsInfoArr[0].Value.Length);

            if (wordsInfoArr.Length < 2 || allWordsHasSameLength)
            {
                Console.WriteLine("Swap result:");
                Console.WriteLine(inputString);
                return;
            }

            StringInfo[] longestWords = GetLongestWords(stringInfoArr);
            StringInfo[] shortestWords = GetShortestWords(stringInfoArr);

            UpdateStringInfo[] closestShortestWords = GetClosestStrings(longestWords, shortestWords, inputString.Length);
            UpdateStringInfo[] closestLongestWords = GetClosestStrings(shortestWords, longestWords, inputString.Length);
            UpdateStringInfo[] resultToUpdate = new UpdateStringInfo[closestShortestWords.Length + closestLongestWords.Length];
            closestShortestWords.CopyTo(resultToUpdate, 0);
            closestLongestWords.CopyTo(resultToUpdate, closestShortestWords.Length);

            foreach (UpdateStringInfo item in resultToUpdate)
            {
                stringInfoArr[item.InitialIndex].Value = item.NewValue;
            }

            string resultString = String.Empty;
            foreach (StringInfo item in stringInfoArr)
            {
                resultString = resultString + item.Value;
            }

            Console.WriteLine("Swap result:");
            Console.WriteLine(resultString);
        }

        public static void Task2c()
        {
            Console.WriteLine("Enter string:");
            string inputString = Console.ReadLine();
            int lettersCount = 0;
            int punctuationsCount = 0;

            if (!String.IsNullOrWhiteSpace(inputString))
            {
                char[] charArr = inputString.ToCharArray();
                lettersCount = Array.FindAll(charArr, c => Char.IsLetter(c)).Length;
                punctuationsCount = Array.FindAll(charArr, c => Char.IsPunctuation(c)).Length;
            }

            Console.WriteLine($"Letters count - {lettersCount}, punctuations count - {punctuationsCount}.");
        }

        public static void Task2d()
        {
            Console.WriteLine("Enter string:");
            string inputString = RequestInput();
            string[] stringArr = inputString.Split(' ');
            for (int i = 0; i < stringArr.Length; i++)
            {
                stringArr[i] = stringArr[i].Trim();
            }

            Array.Sort(stringArr, (string s1, string s2) => s1.Length > s2.Length ? -1 : 1);

            Console.WriteLine("Sorted array: ");
            foreach (string item in stringArr)
            {
                Console.WriteLine(item);
            }
        }

        public struct StringInfo
        {
            public bool IsWord;
            public int IndexInString;
            public int IndexInArr;
            public string Value;

            public StringInfo(bool isWord, int indexInString, int indexInArr)
            {
                IsWord = isWord;
                IndexInString = indexInString;
                IndexInArr = indexInArr;
                Value = String.Empty;
            }
        }

        public struct UpdateStringInfo
        {
            public int InitialIndex;
            public string NewValue;

            public UpdateStringInfo(int initialIndex, string newValue)
            {
                InitialIndex = initialIndex;
                NewValue = newValue;
            }
        }

        public static StringInfo[] ConvertStringToStringInfoArr(string value)
        {
            char[] charArr = value.ToCharArray();
            StringInfo[] stringInfoArr = new StringInfo[charArr.Length];
            int processingIndex = 0;

            for (int i = 0; i < charArr.Length; i++)
            {
                char item = charArr[i];
                StringInfo currentStringInfo = stringInfoArr[processingIndex];
                bool hasSameIsWordField = currentStringInfo.IsWord == Char.IsLetter(item);

                if (hasSameIsWordField && currentStringInfo.Value != null)
                {
                    stringInfoArr[processingIndex].Value = stringInfoArr[processingIndex].Value + item.ToString();
                }
                else
                {
                    processingIndex = i == 0 ? processingIndex : processingIndex + 1;
                    stringInfoArr[processingIndex] = new StringInfo(Char.IsLetter(item), i, processingIndex);
                    stringInfoArr[processingIndex].Value = item.ToString();
                }
            }

            return Array.FindAll(stringInfoArr, stringInfo => stringInfo.Value != null);
        }

        public static void ReplaceOToA(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                string item = arr[i];
                // latin
                string formattedString = item.Replace("o", "a");
                formattedString = formattedString.Replace("O", "A");
                // cyrillic
                formattedString = formattedString.Replace("о", "а");
                formattedString = formattedString.Replace("О", "А");

                arr[i] = formattedString;
            }
        }

        public static void PrintAsColumn(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].TrimStart());
            }
        }

        public static string[] GetLongestWords(string value)
        {
            int longestWordLength = 0;
            string[] stringArr = value.Split(' ');

            for (int i = 0; i < stringArr.Length; i++)
            {
                string formattedString = stringArr[i].Trim();
                stringArr[i] = formattedString;

                if (formattedString.Length > longestWordLength)
                {
                    longestWordLength = formattedString.Length;
                }
            }

            return Array.FindAll(stringArr, s => s.Length == longestWordLength);
        }

        public static StringInfo[] GetLongestWords(StringInfo[] stringInfoArr)
        {
            int longestWordLength = 0;

            for (int i = 0; i < stringInfoArr.Length; i++)
            {
                int currentStringLength = stringInfoArr[i].Value.Length;
                if (currentStringLength > longestWordLength && stringInfoArr[i].IsWord)
                {
                    longestWordLength = currentStringLength;
                }
            }

            return Array.FindAll(stringInfoArr, s => s.Value.Length == longestWordLength && s.IsWord);
        }

        public static StringInfo[] GetShortestWords(StringInfo[] stringInfoArr)
        {
            int shortestWordLength = 1;

            for (int i = 0; i < stringInfoArr.Length; i++)
            {
                int currentStringLength = stringInfoArr[i].Value.Length;
                if (currentStringLength < shortestWordLength && currentStringLength > 0 && stringInfoArr[i].IsWord)
                {
                    shortestWordLength = currentStringLength;
                }
            }

            return Array.FindAll(stringInfoArr, s => s.Value.Length == shortestWordLength && s.IsWord);
        }

        public static UpdateStringInfo[] GetClosestStrings(StringInfo[] stringsTarget, StringInfo[] stringsSource, int maxDistance)
        {
            UpdateStringInfo[] closestStrings = new UpdateStringInfo[stringsTarget.Length];

            StringInfo closestString = stringsSource[0];
            for (int i = 0; i < stringsTarget.Length; i++)
            {
                StringInfo currentTarget = stringsTarget[i];
                int minDistance = maxDistance;

                foreach (StringInfo currentSource in stringsSource)
                {
                    int currentDistance = currentTarget.IndexInString < currentSource.IndexInString ?
                        currentSource.IndexInString - (currentTarget.IndexInString + currentTarget.Value.Length) :
                        currentTarget.IndexInString - (currentSource.IndexInString + currentSource.Value.Length);

                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        closestString = currentSource;
                    }
                }

                closestStrings[i] = new UpdateStringInfo(currentTarget.IndexInArr, closestString.Value);
            }

            return closestStrings;
        }

        public static string RequestInput()
        {
            string userInput;

            while (true)
            {
                userInput = Console.ReadLine();
                if (String.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("Enter value please.");
                }
                else
                {
                    return userInput;
                }
            }
        }
    }
}
