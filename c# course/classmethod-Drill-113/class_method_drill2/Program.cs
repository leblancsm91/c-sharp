using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_method_drill2
{
    class Program
    {
        int numb1 = 2;
        int numb2 = 3;

        static void Main(string[] args)
        {

            Console.WriteLine("white a whole number")
            int numb1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("type another number");
            int numb2 = Convert.ToInt32(Conole.ReadLine());

            math solution = new math();

            solution = Add(numb1,numb2);
        }
    }
}
