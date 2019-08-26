using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractDrill
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("first name: " + FirstName.ToString());
            Console.WriteLine("last name: " + LastName.ToString());
        }
    }
}
