using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractDrill
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "student";
            employee.LastName = "sample";

            employee.SayName();

            Console.ReadLine();
            //always inside main method^
        }
    }
}
