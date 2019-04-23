using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEllipsise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string userString = Console.ReadLine();
            Console.WriteLine(userString.Ellipsise());

            Console.Read();
        }
    }

    static class StringExtention {
        public static string Ellipsise (this string str)
        {
            if (str.Length > 5)
            {
                return $"{str.Substring(0, 5)}...";
            }
            return str;
        }
    }
}
