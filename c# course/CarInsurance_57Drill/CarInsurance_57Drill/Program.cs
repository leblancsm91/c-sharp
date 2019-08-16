using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance_57Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your age?");
            int driverAge = Convert.ToInt32(Console.ReadLine());
            if (driverAge > 15)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.WriteLine("have you ever had a dui?");
            string dui = Console.ReadLine();
            if (dui == "yes")
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
                Convert.ToBoolean(Console.ReadLine());
            }
            Console.WriteLine("how many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            if (tickets > 3)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }
            Convert.ToBoolean(Console.ReadLine());
        }
    }
}
