using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thingsDrill_131
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> thang = new Employee<string>();
            thang.things = new List<string>() { "these", "are", "things" };

            Employee<int> IDs = new Employee<int>();
            IDs.things = new List<int>() { 001, 002, 003 };



            foreach (thang in things)
            {
                Console.ReadLine(thang);
            }






            for (int i = 0; i < thang.things.Count; i++)
            {
                Console.WriteLine(IDs.things[i] + " " + thang.things[i]);
            }
            Console.ReadLine();

        }
    }
}
