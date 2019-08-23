using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iquitDrill_126
{
    class Employee : Person, IQuittable
    {
        public void SayName()
        { 
        }
        public void Quit() //adding inherited field here <
        {
            Console.WriteLine("first name: " + FirstName.ToString());
            Console.WriteLine("last name: " + LastName.ToString() + quit +);
        }
    }
}
