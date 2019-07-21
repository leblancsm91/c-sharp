using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_drill
{
    class Program
    {
        static void Main()
        {
            string color = "blue";
            string rainbow = "the rainbow consists of; \n red\n orange\n yellow\n green\n blue\n purple\n and most importantly - skittles !!!!";
            string question = "What is the second ot last color in a rainbow?";

            color = color.ToUpper();

            StringBuilder skittles = new StringBuilder();
            skittles.Append("skittles are in the rainbow.\n taste the rainbow");

            Console.WriteLine(rainbow);
            Console.WriteLine(question);
            Console.ReadLine();
        }
    }
}
