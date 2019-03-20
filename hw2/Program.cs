using System;

namespace hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 3.a");
            ConvertExplicit();
            Console.WriteLine();

            Console.WriteLine("Task 3.b");
            ConvertImplicit();
            Console.WriteLine();

            Console.WriteLine("Task 3.c, 3d");
            BoxingAndUnboxing();
            Console.WriteLine();

            Console.WriteLine("Task 4");
            CheckTypeDeclaration();
            Console.WriteLine();

            Console.Read();
        }

        enum EnumExample
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static float floatExample = 23.6f;
        static dynamic dynamicExample = "test";
        static char charExample = 'O';

        public static void ConvertExplicit()
        {
            int to1 = (int)floatExample;
            long to2 = (long)EnumExample.Saturday;
            ushort to3 = (ushort)charExample;

            Console.WriteLine(
                $"Convertion: " +
                $"from {floatExample.GetType()} {floatExample} => {to1.GetType()} {to1}, " +
                $"from {EnumExample.Saturday.GetType()} {EnumExample.Saturday} => {to2.GetType()} {to2}, " +
                $"from {charExample.GetType()} {charExample} => {to3.GetType()} {to3}. "
            );
        }

        public static void ConvertImplicit()
        {
            double to1 = (double)floatExample;
            EnumExample to2 = 0;
            string to3 = dynamicExample;

            Console.WriteLine(
                $"Convertion: " +
                $"from {floatExample.GetType()} {floatExample} => {to1.GetType()} {to1}, " +
                $"from literal 0 => enum {to2.GetType()}, " +
                $"from dynamic {dynamicExample} => {to3.GetType()} {to3}. "
            );
        }

        public static void BoxingAndUnboxing()
        {
            int a = 10;

            object boxed = a;
            Console.WriteLine($"Boxed {a.GetType()} {a} in {boxed.GetType()}");

            int unboxed = (int)boxed;
            Console.WriteLine($"Unboxed {boxed.GetType()} in {boxed.GetType()} {unboxed}");
        }

        public static void CheckTypeDeclaration()
        {
            sbyte sbyteCSharp = 1;
            SByte sbyteCLR = 1;
            Console.WriteLine($"sbyte: c# declaration {sbyteCSharp.GetType()}, CLR declaration {sbyteCLR.GetType()}");

            short shortCSharp = 1;
            Int16 shortCLR = 1;
            Console.WriteLine($"short: c# declaration {shortCSharp.GetType()}, CLR declaration {shortCLR.GetType()}");

            int intCSharp = 1;
            Int32 intCLR = 1;
            Console.WriteLine($"int: c# declaration {intCSharp.GetType()}, CLR declaration {intCLR.GetType()}");

            long longCSharp = 1;
            Int64 longCLR = 1;
            Console.WriteLine($"long: c# declaration {longCSharp.GetType()}, CLR declaration {longCLR.GetType()}");

            byte byteCSharp = 1;
            Byte byteCLR = 1;
            Console.WriteLine($"byte: c# declaration {byteCSharp.GetType()}, CLR declaration {byteCLR.GetType()}");

            ushort ushortCSharp = 1;
            UInt16 ushortCLR = 1;
            Console.WriteLine($"ushort: c# declaration {ushortCSharp.GetType()}, CLR declaration {ushortCLR.GetType()}");

            uint uintCSharp = 1;
            UInt32 uintCLR = 1;
            Console.WriteLine($"uint: c# declaration {uintCSharp.GetType()}, CLR declaration {uintCLR.GetType()}");

            ulong ulongCSharp = 1;
            UInt64 ulongCLR = 1;
            Console.WriteLine($"ulong: c# declaration {ulongCSharp.GetType()}, CLR declaration {ulongCLR.GetType()}");

            char charCSharp = '1';
            Char charCLR = '1';
            Console.WriteLine($"char: c# declaration {charCSharp.GetType()}, CLR declaration {charCLR.GetType()}");

            float floatCSharp = 1.1F;
            Single floatCLR = 1.1F;
            Console.WriteLine($"float: c# declaration {floatCSharp.GetType()}, CLR declaration {floatCLR.GetType()}");

            double doubleCSharp = 1.11;
            double doubleCLR = 1.11;
            Console.WriteLine($"double: c# declaration {doubleCSharp.GetType()}, CLR declaration {doubleCSharp.GetType()}");

            decimal decimalCSharp = 1;
            Decimal decimalCLR = 1;
            Console.WriteLine($"dcimal: c# declaration {decimalCSharp.GetType()}, CLR declaration {decimalCLR.GetType()}");

            bool boolCSharp = true;
            Boolean boolCLR = true;
            Console.WriteLine($"bool: c# declaration {boolCSharp.GetType()}, CLR declaration {boolCLR.GetType()}");

            string stringCSharp = "1";
            String stringCLR = "1";
            Console.WriteLine($"string: c# declaration {stringCSharp.GetType()}, CLR declaration {stringCLR.GetType()}");

            object objectCSharp = 1;
            Object objectCLR = 1;
            Console.WriteLine($"object: c# declaration {objectCSharp.GetType()}, CLR declaration {objectCLR.GetType()}");
        }

    }
}
