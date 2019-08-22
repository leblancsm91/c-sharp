using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iquitDrill_126
{
    public class Employee : Person, Quit
    {
        public void SayName()
        {
            Console.WriteLine("first name: " + FirstName.ToString());
            Console.WriteLine("last name: " + LastName.ToString());
        }

        public void Quit()
        {
            Console.WriteLine(FirstName + LastName + quit);
        }
    }
}
