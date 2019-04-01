using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Public vacation duration: {Developer.VacationDurationPublic}" );
            Console.WriteLine($"Internal vacation duration: {Developer.VacationDurationInternal}");
            Console.WriteLine($"Protected internal vacation duration: {Developer.VacationDurationProtectedInternal}");
            Developer.DisplayPrivateProtectedVacationDuration();
            Developer.DisplayProtectedVacationDuration();

            Console.Read();
        }
    }
}
