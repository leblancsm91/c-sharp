using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var_constDrill
{
    class Program
    {
        static void Main(string[] args)
        {

            var mySpace = new Old();

            const string youAre = "you are";

            Console.WriteLine("do you like myspace,  or use myspce?");
            string answer = Console.ReadLine();

            if (answer == "yes" || answer == "yeah")
            {
                Console.WriteLine(youAre + " old");

            }
            else
            {
                Console.WriteLine(youAre + " not as old");
            }
            Console.ReadLine();
        }
    }
}
