using System;

namespace hw_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            SimpleSum();
            Console.WriteLine();

            Console.WriteLine("Task 2");
            SumWithCheck();
            Console.WriteLine();

            Console.WriteLine("Task 3");
            SumWithIntervalCheck();
            Console.WriteLine();

            Console.WriteLine("Task 4");
            MakeCalculation();
            Console.WriteLine();

            Console.Read();
        }

        public static void SimpleSum()
        {
            int firstOperand = RequestInteger("Enter first integer:");
            int secondOperand = RequestInteger("Enter second integer:");

            Console.WriteLine($"Result is: {GetSum(firstOperand, secondOperand)}");
        }

        public static void SumWithCheck()
        {
            int firstOperand = RequestInteger("Enter first integer:");
            int secondOperand = RequestInteger("Enter second integer:");
            int sumResult = GetSum(firstOperand, secondOperand);
            int userSumResult = RequestInteger("Enter sum result:");
            bool isCorrect = CheckEquality(sumResult, userSumResult);

            Console.WriteLine(isCorrect ? "Правильно" : "Неправильно");
        }

        public static void SumWithIntervalCheck()
        {
            int firstOperand = RequestInteger("Enter first integer:");
            int secondOperand = RequestInteger("Enter second integer:");
            int sumResult = GetSum(firstOperand, secondOperand);
            int userSumResult = RequestInteger("Enter sum result:");
            bool isCorrect = CheckEquality(sumResult, userSumResult);

            Console.WriteLine(isCorrect ? "Правильно" : "Неправильно");

            if (!isCorrect)
            {
                ShowMoreOrLess(sumResult, userSumResult);
            }
        }

        public static void MakeCalculation()
        {
            int firstOperand = RequestInteger("Enter first integer:");
            int secondOperand = RequestInteger("Enter second integer:");
            string operand = RequestOperand("Enter operand:");
            int calculationResult = Calculate(firstOperand, secondOperand, operand);
            int userCalculationResult = RequestInteger("Enter calculation result:");
            bool isCorrect = CheckEquality(calculationResult, userCalculationResult);

            Console.WriteLine(isCorrect ? "Правильно" : "Неправильно");

            if (!isCorrect)
            {
                ShowMoreOrLess(calculationResult, userCalculationResult);
            }
        }

        public static int RequestInteger(string requestTitle)
        {
            Console.WriteLine(requestTitle);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static string RequestOperand(string requestTitle)
        {
            Console.WriteLine(requestTitle);
            return Console.ReadLine();
        }

        public static int GetSum(int value1, int value2)
        {

            return value1 + value2;
        }

        public static int GetDiff(int value1, int value2)
        {

            return value1 - value2;
        }

        public static int Calculate(int value1, int value2, string operand)
        {
            switch (operand)
            {
                case "+":
                    return GetSum(value1, value2);
                case "-":
                    return GetDiff(value1, value2);
                default:
                    return GetSum(value1, value2);
            }
        }

        public static bool CheckEquality(int value1, int value2)
        {
            return value1 == value2;
        }

        public static void ShowMoreOrLess(int target, int inputNumber)
        {
            if (target > inputNumber)
            {
                Console.WriteLine("Должно быть больше");
            }
            else if (target < inputNumber)
            {
                Console.WriteLine("Должно быть меньше");
            }
        }
    }
}
