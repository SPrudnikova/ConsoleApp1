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
            Operands operand = RequestOperand("Enter operand + or - :");
            int calculationResult = Calculate(firstOperand, secondOperand, operand);
            int userCalculationResult = RequestInteger("Enter calculation result:");
            bool isCorrect = CheckEquality(calculationResult, userCalculationResult);

            Console.WriteLine(isCorrect ? "Правильно" : "Неправильно");

            if (!isCorrect)
            {
                ShowMoreOrLess(calculationResult, userCalculationResult);
            }
        }

       public enum Operands
        {
            Plus,
            Minus
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

        public static Operands RequestOperand(string requestTitle)
        {
            Console.WriteLine(requestTitle);
            while (true)
            {
                string operand = Console.ReadLine();
                if (operand == "+")
                {
                    return Operands.Plus;
                }
                else if (operand == "-")
                {
                    return Operands.Minus;
                }
                else
                {
                    Console.WriteLine("Entered value is not valid. Enter valid operand please.");
                }
            }
        }

        public static int GetSum(int value1, int value2)
        {

            return value1 + value2;
        }

        public static int GetDiff(int value1, int value2)
        {

            return value1 - value2;
        }

        public static int Calculate(int value1, int value2, Operands operand)
        {
            switch (operand)
            {
                case Operands.Plus:
                    return GetSum(value1, value2);
                case Operands.Minus:
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
