using System;
using AssemblyOne;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Developer dev = new Developer();
            SoftwareEngineer se = new SoftwareEngineer();

            Console.WriteLine($"Employee: public vacation duration: {Employee.VacationDurationPublic}");
            Console.WriteLine($"Developer: public vacation duration: {Developer.VacationDurationPublic}");
            Console.WriteLine($"SE: public vacation duration: {SoftwareEngineer.VacationDurationPublic}");
            
            employee.DisplayPrivateVacationDuration();
            employee.DisplayProtectedVacationDuration();
            employee.DisplayPrivateProtectedVacationDuration();

            Console.Write("SE inherited: ");
            dev.DisplayPrivateVacationDuration();

            dev.DisplayPrivateProtectedVacationDuration();
            dev.DisplayProtectedVacationDuration();

            Console.Write("SE inherited: ");
            se.DisplayPrivateVacationDuration();
            Console.Write("SE inherited: ");
            se.DisplayPrivateProtectedVacationDuration();

            se.DisplayProtectedVacationDuration();
            se.DisplayProtectedInternalVacationDuration();
            
            
            Console.Read();
        }
    }
}
