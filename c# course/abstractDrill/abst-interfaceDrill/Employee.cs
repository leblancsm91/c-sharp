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
            IQuit IQuittable = new IQuit();
            Quit.IQuittable;
        }

    }
}
