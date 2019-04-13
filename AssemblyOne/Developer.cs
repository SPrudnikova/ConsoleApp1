using System;

namespace AssemblyOne
{
    public class Developer : Employee
    {
        public override void DisplayProtectedVacationDuration ()
        {
            Console.WriteLine($"Developer method: Protected vacation duration: {Developer.VacationDurationProtected}");
        }

        public override void DisplayPrivateProtectedVacationDuration()
        {
            Console.WriteLine($"Developer method: Private protected vacation duration: {Developer.VacationDurationPrivateProtected}");
        }
    }
}
