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
            Employee name = new Employee();
            name.persons = new List<Person>();
            Person Emp1ID = new Person();
            Emp1ID.Name = 001;
            Person Emp2ID = new Person();
            Emp2ID.Name = 002;

            name.FirstName = "Sample";
            name.LastName = "Student";
            name.SayName();
            Console.ReadLine();

            IQuit IQuittble = new IQuit();
            IQuittable.Quit();
        }
    }
}
