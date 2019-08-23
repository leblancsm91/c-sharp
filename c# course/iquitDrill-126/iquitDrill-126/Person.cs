using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iquitDrill_126
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    public virtual void SayName();
    {
        Console.WriteLine("FirstName : " + FirstName + "\n LastName : " + LastName);
    }
} //****** WHAT TO PUT HERE? ^^
// ******* WHY SAYNAME() DOENST WORK?
