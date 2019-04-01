using System;
using AssemblyOne;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Public vacation duration: {Developer.VacationDurationPublic}");
            Developer.DisplayPrivateProtectedVacationDuration();
            Developer.DisplayProtectedVacationDuration();
            SoftwareEngineer.DisplayProtectedVacationDurationInherit();
            SoftwareEngineer.DisplayProtectedInternalVacationDurationInherit();

            Console.Read();
        }
    }
}
