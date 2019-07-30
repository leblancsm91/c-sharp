using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractDrill
{
    public class Employee : Person, IQuit
    {
        public void SayName()
        {
            Console.WriteLine("");
        }
        public void Quit()
        {
        }

        int Emp1ID = 001;
        int Emp2ID = 002;


    }
}
