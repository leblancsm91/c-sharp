using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Math solution = new Math();
            
            Console.WriteLine("type a number");
            int number1 = Convert.ToInt32(Console.ReadLine()); //storing variable one here // always has to convert like this
            int result1 = solution.Add(number1); //storing results to variable result1 
            Console.WriteLine(result1);
            Console.ReadLine();

            Console.WriteLine("type another number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int result2 = solution.Subt(number2);
            Console.WriteLine(result2);
            Console.ReadLine();

            Console.WriteLine("type a numbe to be multiplied");
            int number3 = Convert.ToInt32(Console.ReadLine());
            int result3 = solution.Mult(number3);
            Console.WriteLine(result3);
            Console.ReadLine();
        }
    }
}
