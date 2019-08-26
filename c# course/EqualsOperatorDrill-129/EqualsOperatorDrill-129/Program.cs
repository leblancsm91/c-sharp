using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsOperatorDrill_129
{
    class Program
    {
        static void Main()
        {
            int emp1ID = 001;
            int emp2ID = 002;

            Console.WriteLine(object.ReferenceEquals(emp1ID, emp2ID));
            Console.ReadLine();



            //1ST DRAFT::
            /*public static ReferenceEquals operator =()
            {
                int empID1 = 001;
                Console.WriteLine("Employee #1 id is {0}", empID1);
                Console.WriteLine("what is employee #2's id?");
                int empID2 = Convert.ToInt32(Console.ReadLine());

                if (empID1 == empID2)
                {
                    Console.WriteLine("they have the same ID");
                }   
                else
                {
                Console.WriteLine("they do not have the same ID");
                }
            Console.ReadLine();
            }*/
        }
    }
}
