using System;
using System.Collections.Generic;

namespace testConsole
{
//    Övningsdags :-träning Solid patterns
//    Ni ska skriva ett program som printer ut en lista av employees.
//    Varje employee har:
//    First Name
//    Last Name
//    Base Salary
//    Total Salary

//    Total Salary beräknas olika beroende på vilken typ av anställd det är.
//    Skriv programmet så att det går att lägga till nya typer av anställda utan att ändra I redan existerande kod

    class Program
    {
        static void Main(string[] args)
        {

            //====================== Med Interface - IEmployee ======================================

            List<IEmployee> employeeLista = new List<IEmployee>
            {
             new EmployeeStandart {FirstName="Stefan", LastName="Karlsson", BaseSalary=20000},//class EmployStandart
             new EmployeeExecutive {FirstName="Johan", LastName="Larsson", BaseSalary=20000},
             new EmployeeManager {FirstName="Niklas", LastName="Svensson", BaseSalary=20000},
             new EmployeeDog {FirstName="Good", LastName="Boy", BaseSalary=0}
            };


            //====================== Med Inheritance-arv-abstract class GrundAnstalld=====================================


            List<GrundAnstalld> employeeList = new List<GrundAnstalld>
            {
                   new GrundAnstalld  {FirstName="Lasse",LastName="Oskarsson",BaseSalary=4000},
                   //new BrevBarare  {FirstName="Karl", LastName="Blossom", BaseSalary=3000}
             
            };


            //==================================================
            foreach (var employee in employeeLista)
            {
                Console.WriteLine($"Name: {employee.FirstName} {employee.LastName}" +
                    $" Base Salary: {employee.BaseSalary} " +
                    $"Total Salary: {employee.TotalSalary}");
            }
            foreach (var employee in employeeList )
            {
                Console.WriteLine($"Name: {employee.FirstName} {employee.LastName}" +
                    $" Base Salary: {employee.BaseSalary} " +
                    $"Total Salary: {employee.TotalSalary}" +
                    $"Bonus:{employee.Bonus(4)}");
            }

            Console.WriteLine($"{employeeLista[1].FirstName } {employeeLista[1].LastName } ");
            //Console.WriteLine($"{employeeList[1].FirstName } {employeeList[1].LastName } Bonus:{employeeList[1].Bonus(4)}");
        }        
    }
}
