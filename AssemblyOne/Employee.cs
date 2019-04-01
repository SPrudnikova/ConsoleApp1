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
    }
}
