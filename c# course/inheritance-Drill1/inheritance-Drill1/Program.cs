using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_Drill1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Person = new Employee();
            Employee.FirstName = "Sample";
            Employee.LastName = "Student";
            Person.SayName();
            Console.ReadLine();

        }
    }
}
