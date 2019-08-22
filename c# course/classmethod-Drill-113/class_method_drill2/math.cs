using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_method_drill2
{
    public class math
    {
        public void Add(int numb1, int numb2)
        {

            double answer1 = numb1 + 100;
            double answer2 = numb2 * answer1;

            Console.WriteLine("solution 1: {0} + 100 = {1}", numb1.ToString(), answer1.ToString());
            Console.WriteLine("solution 2: {0} * {1} = {2}", numb2.ToString(), answer2.ToString());
        }
    }
}
