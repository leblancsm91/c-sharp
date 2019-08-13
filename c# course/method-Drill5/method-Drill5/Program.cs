using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_Drill5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            division product = new division();

            Console.WriteLine("type number");
            int numb1 = Convert.ToInt32(Console.ReadLine());
            double result = product.Divide(numb1);
            Console.WriteLine(result);
            Console.ReadLine();

            Console.WriteLine("type a different number");
            int numb2 = Convert.ToInt32(Console.ReadLine());
            double result2 = product.Divide(numb2);
            Console.WriteLine(result2);
            Console.ReadLine();

        }
    }
}
