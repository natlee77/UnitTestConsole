using System;

namespace testConsole
{
    internal class EmployeeExecutive : IBonus, IEmployee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BaseSalary { get; set; }
        public double TotalSalary { get { return BaseSalary * 20; } }

        

        public double Bonus(double points)
        {
            throw new System.NotImplementedException();
        }
    }
}