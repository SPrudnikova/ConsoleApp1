using System;

namespace Helpers
{
    public static class UserInput
    {
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

        public static string RequestInput(string requestTitle)
        {
            Console.WriteLine(requestTitle);
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

        public static TEnum RequestEnumValue<TEnum>(string requestTitle) where TEnum : struct
        {
            string[] availableValues = Enum.GetNames(typeof(TEnum));
            Console.WriteLine(requestTitle);
            Console.WriteLine($"Available genres are: {String.Join(", ", availableValues)}.");
            string userInput;

            while (true)
            {
                userInput = Console.ReadLine();
                TEnum enumValue;
                if (Enum.TryParse(userInput, true, out enumValue))
                {
                    return enumValue;
                }
                else
                {
                    Console.WriteLine("Enter valid value please.");
                }
            }
        }
    }
}
