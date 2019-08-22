`using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iquitDrill-126
{
    class Program
    {
        public void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "student";
            employee.LastName = "sample";

            employee.SayName();
        }
    }
}