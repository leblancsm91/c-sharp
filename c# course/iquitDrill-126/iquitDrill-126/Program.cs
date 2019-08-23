 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iquitDrill_126
{
    class Program
    {
        public void Main(string[] args)
        {
            Employee employee = new Employee() {FirstName = "student", LastName = "sample" };
            employee.SayName();

            //imlpement each part here:
            IQuittable quit = new Employee() { FirstName = "quittable", LastName = "employee"};
            quit.Quit();
        }
    }
}