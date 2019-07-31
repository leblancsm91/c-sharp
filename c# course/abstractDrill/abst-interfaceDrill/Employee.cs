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
    }
    public class Things<string> //GENERIC
    {
        public string value
        {
            get
            {
                return;
            }
            set
            {
                this.things = value;
            }
        }
        public int value
        {
            get
            {
                return;
            }
            set
            {
                this.otherThings = value;
            }
        }
    }

}
