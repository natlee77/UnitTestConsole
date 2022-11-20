using System;

namespace testConsole
{
    public class EmployeeStandart : IEmployee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BaseSalary { get; set; }
        public double TotalSalary { get { return BaseSalary * 1; } }

        
    }
}