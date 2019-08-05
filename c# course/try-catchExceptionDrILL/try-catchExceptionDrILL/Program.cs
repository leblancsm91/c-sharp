using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catchExceptionDrILL
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("what is your age?");
            int Age = Convert.ToInt32(Console.ReadLine());
            int answer = 2019 - Age;
            Console.ReadLine();

            try
            {
                
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("whole and positive numbers only please! ");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("try again");
                Console.ReadLine();
                return;
            }
        }
    }
}
