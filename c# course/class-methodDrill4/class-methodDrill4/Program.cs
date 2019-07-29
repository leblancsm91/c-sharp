using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_methodDrill4
{
    class Program
    {
        static void Main(string[] args)
        {
            math solution = new math();

            Console.WriteLine("enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            int result = solution.Add(a, b);
            Console.WriteLine(result);
            Console.ReadLine();

            int b = Convert.ToInt32(Console.ReadLine());
            int result2 = solution.Add(a, int b = 2);
            Console.WriteLine(result2);
            Console.ReadLine();

        }
    }
}
