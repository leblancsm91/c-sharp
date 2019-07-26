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
            int answer1 = operation.Add(Number1);
            Console.WriteLine(answer1);
            Console.ReadLine();

            math2 operation2 = new math2();

            Console.WriteLine("type a number to be subtracted");
            float Number2 = Convert.ToInt32(Console.ReadLine());
            float answer2 = operation2.Subt(Number2);
            Console.WriteLine(answer2);
            Console.ReadLine();

            math3 operation3 = new math3();

            Console.WriteLine("type a number to be added");
            string Number3 = Convert.ToInt32(Console.ReadLine());
            string answer3 = operation3.Add(Number3);
            Console.WriteLine(answer3);
            Console.ReadLine();


        }
    }
}
