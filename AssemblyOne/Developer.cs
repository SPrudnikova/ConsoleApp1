using System;

namespace AssemblyOne
{
    public class Developer : Employee
    {
        public static void DisplayProtectedVacationDuration ()
        {
            Console.WriteLine($"Protected vacation duration from method: {Developer.VacationDurationProtected}");
        }

        public static void DisplayPrivateProtectedVacationDuration()
        {
            Console.WriteLine($"Private protected vacation duration from method: {Developer.VacationDurationPrivateProtected}");
        }
    }
}
