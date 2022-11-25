using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using testConsole;
 

namespace UnitTest.Tests
{
    // arrange -- setapp
    // act -- actual
    // assert
    public class Employee_XUnitTest
    {
        private List<GrundAnstalld> _employees { get; set; }
        
        public  Employee_XUnitTest()
        {
            _employees = new  List<GrundAnstalld>();
        }


       
        [Theory]       
        [InlineData("Hans", "Mattin", 22000)]    // 1) data  som jag testa
        
        public void AddStadare_ShouldAdd(string firstName, string lastName, int salary)
        {
            // arrange -- setapp
            var employee = new Stadare(firstName, lastName, salary);
            // act -- actual
            _employees.Add(employee);
            // assert
            Assert.Contains(employee, _employees);
        }
        [Theory]
        [InlineData("Haaas", "HKLldkdfmK", 23000)]
        public void AddBrevBarare_ShouldAdd(string firstName, string lastName, int salary)
        {   
            var employee = new BrevBarare(firstName, lastName, salary);
            _employees.Add(employee);
            Assert.Contains(employee, _employees);
        }
         [Theory]

        [InlineData(-5, 22000, 0)]     // inte accepterar negativa värden,

        [InlineData(0.5, 22000, 110)]    //   accepterar float , double

        [InlineData(2, 22000, 440)]      //   accepterar integer

        [InlineData(51, 22000, 0)]     // grans for bonus max 50 points

        public void CreateBonus_ShouldDo(double points, int baseSalary, int expected)
        {
            // arrange -- setapp
            var empl = new GrundAnstalld("Hans", "Mattin", baseSalary);            
            // act -- actual
            var result = empl.Bonus(points);
            // assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void FullName_ShouldReturnFullName()
        {   // arrange -- setapp
            GrundAnstalld empl = new GrundAnstalld() {FirstName="Nana" , LastName="Green", BaseSalary=43723};
            // act -- actual
            string fullname = empl.FullName;
            // assert
            Assert.Equal("Nana Green", empl.FullName);
        }



        [Fact]
        public void TotalSalary_ShouldReturnTotalSalary()
        {
            // arrange -- setapp
            GrundAnstalld empl = new GrundAnstalld() { FirstName = "Nana", LastName = "Green", BaseSalary = 20000 };
            // act -- actual
            double totalSalary = empl.TotalSalary;
            // assert
            Assert.Equal(22000, empl.TotalSalary);
        }

        [Fact]
        public void Id_ShouldCreateUniqueID()
        {

            Guid _id = Guid.NewGuid();
            EmployeeStandart employee = new EmployeeStandart() { Id = _id };
            Assert.Equal(_id, employee.Id);
        }
    }
}
