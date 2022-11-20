using System;

namespace testConsole
{
    internal class EmployeeDog : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BaseSalary { get; set; }
        public Guid Id { get  ; set  ; }

        double  IEmployee.TotalSalary { get { return BaseSalary * 1; } }
    }
}