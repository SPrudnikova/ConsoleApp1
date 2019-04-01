using System;
using AssemblyOne;

namespace AssemblyTwo
{
    class SoftwareEngineer: Developer
    {
        public static void DisplayProtectedVacationDurationInherit()
        {
            Console.WriteLine($"Protected vacation duration from method in assembly two: {Developer.VacationDurationProtected}");
        }

        public static void DisplayProtectedInternalVacationDurationInherit()
        {
            Console.WriteLine($"Protected internal vacation duration from method in assembly two: {Developer.VacationDurationProtectedInternal}");
        }

    }
}
