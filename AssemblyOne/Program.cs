using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Developer dev = new Developer();

            Console.WriteLine($"Employee: public vacation duration: {Employee.VacationDurationPublic}");
            Console.WriteLine($"Employee: internal vacation duration: {Employee.VacationDurationInternal}");
            Console.WriteLine($"Employee: protected internal vacation duration: {Employee.VacationDurationProtectedInternal}");

            Console.WriteLine($"Developer: public vacation duration: {Developer.VacationDurationPublic}");
            Console.WriteLine($"Developer: internal vacation duration: {Developer.VacationDurationInternal}");
            Console.WriteLine($"Developer: protected internal vacation duration: {Developer.VacationDurationProtectedInternal}");

            employee.DisplayPrivateVacationDuration();
            employee.DisplayProtectedVacationDuration();
            employee.DisplayPrivateProtectedVacationDuration();

            Console.Write("Developer inherited: ");
            dev.DisplayPrivateVacationDuration();

            dev.DisplayPrivateProtectedVacationDuration();
            dev.DisplayProtectedVacationDuration();

            Console.Read();
        }
    }
}
