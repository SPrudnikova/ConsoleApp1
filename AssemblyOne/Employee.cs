using System;

namespace AssemblyOne
{
    public class Employee
    {
        public const int VacationDurationPublic = 28;
        protected const int VacationDurationProtected = 28;
        protected internal const int VacationDurationProtectedInternal = 28;
        internal const int VacationDurationInternal = 28;
        private const int VacationDurationPrivate = 28;
        private protected const int VacationDurationPrivateProtected = 28;

        public void DisplayPrivateVacationDuration()
        {
            Console.WriteLine($"Employee method: private vacation duration: {Employee.VacationDurationPrivate}");
        }

        public virtual void DisplayPrivateProtectedVacationDuration()
        {
            Console.WriteLine($"Employee method: Private protected vacation duration: {Employee.VacationDurationPrivateProtected}");
        }

        public virtual void DisplayProtectedVacationDuration()
        {
            Console.WriteLine($"Employee method: Protected vacation duration: {Employee.VacationDurationProtected}");
        }
    }
}
