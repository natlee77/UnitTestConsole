using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testConsole
{
    public  class GrundAnstalld: IBonus, IEmployee
    {

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BaseSalary { get; set; }
        public double TotalSalary { get { return BaseSalary * 1.1; } }

        public string FullName =>$"{ FirstName} { LastName  }";

      

        public GrundAnstalld(string firstName, string lastName, int salary)
        {
            FirstName = firstName;
            LastName = lastName;
            BaseSalary = salary;
        }

        public GrundAnstalld()
        {
        }

        public double Bonus(double points)
        {
            if (   points> 0 & points  <= 50)
            {
                return BaseSalary / 100 * points;
            }
            else
            {
                Console.WriteLine("write points more then 0");
                return 0;
            }

            
        }
    }
}
