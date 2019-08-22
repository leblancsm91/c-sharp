using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolean_comparisondrill
{
    class Program
    {
        static void Main(string[] args)
        {
            string color = "";
            bool go = true;

            do
            {
                Console.WriteLine("choose a color: \nRed \nOrange \nYellow \nGreen \nBlue \nPurple");
                color = Console.ReadLine().ToUpper();
                if (color == "RED" || color == "ORANGE")
                {
                    Console.WriteLine("{0}} was the right color!", color);
                    go = false;
                }

                else
                {
                    Console.WriteLine(" {0} was an incorrect color", color);
                    break;
                }
            }
            while (go == true);
            Console.WriteLine("Good job!");
            Console.ReadLine();
        }
    }
}
