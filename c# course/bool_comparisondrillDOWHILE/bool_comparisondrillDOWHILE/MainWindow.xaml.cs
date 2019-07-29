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

            do
            {
                Console.WriteLine("choose a color: \nRed \nOrange \nYellow \nGreen \nBlue \nPurple");
                Console.ReadLine(); .ToUpper();
                if (color == "Red" || "Orange" || "Yellow" || "Green" || "Blue" || "Purple")
                {
                    break;
                }
            }
            while (color != "Red" || "Orange" || "Yellow" || "Green" || "Blue" || "Purple");
            Console.WriteLine("Good job!");
            Console.ReadLine();
        }
    }
}
