using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            DaysOfWeek day = new DaysOfWeek();
            Console.WriteLine("what is the day today?");

            try
            {
                string answer = (Console.ReadLine().ToUpper());
            }
            catch ()
            {
                Console.WriteLine("")
            }

        }
        public enum DaysOfWeek
        {
            Monday,
            Tuesday, 
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
}
