using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testConsole
{
    public class Stadare : GrundAnstalld
    {
        public string v1;
        public Stadare(string firstName, string lastName, int salary) : base(firstName, lastName, salary)
        {
            v1 = firstName;
        }
    }
}
