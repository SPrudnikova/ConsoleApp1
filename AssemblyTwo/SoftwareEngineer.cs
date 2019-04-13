using System;
using AssemblyOne;

namespace AssemblyTwo
{
    class SoftwareEngineer: Developer
    {
        public override void DisplayProtectedVacationDuration()
        {
            Console.WriteLine($"SoftwareEngineer method: Protected vacation duration: {SoftwareEngineer.VacationDurationProtected}");
        }

        public void DisplayProtectedInternalVacationDuration()
        {
            Console.WriteLine($"SoftwareEngineer method: Protected internal vacation duration: {SoftwareEngineer.VacationDurationProtectedInternal}");
        }

    }
}
