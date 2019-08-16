using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classmethod_Drill3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            math operation = new math();

            Console.WriteLine("type a number to add");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            int numAnswer1 = Number1 + 12;
            int answer1 = operation.Add(numAnswer1);

            math2 operation2 = new math2();

            Console.WriteLine("type a number to be subtracted");
            double Number2 = Convert.ToDouble(Console.ReadLine());
            double answer2 = operation2.Subt(Number2);

            math3 operation3 = new math3();

            Console.WriteLine("type a number to be added");
            Console.ReadLine();


        }
    }
}
