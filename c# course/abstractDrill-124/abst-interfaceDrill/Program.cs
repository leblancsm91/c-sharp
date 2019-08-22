using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractDrill
{
    class Program
    {
        public void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.WriteLine("type employee's first name: ");
            employee.FirstName = "student";
            employee.LastName = "sample";

            employee.SayName();
        }
    }
}
