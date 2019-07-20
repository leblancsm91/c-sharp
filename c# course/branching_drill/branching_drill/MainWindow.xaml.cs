using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branching_drill
{
    static void Main(string[] args)
    {
        Console.Write("welcome to package express. please follow the instructions below");
        Console.WriteLine("what is your package's weight?");
        int pWeight = Console.ReadLine();
        if (pWeight > 50)
        {
            Console.WriteLine("pacckage to heavy to be shipped via package express. Have a good day!");

        }
        Console.WriteLine("what is your package's width?");
        int pWidth = Console.ReadLine();
        Console.WriteLine("what is package's hheight?");
        int pHeight = Console.ReadLine();
        Console.WriteLine("what is the package length?");
        int pLength = Console.ReadLine();

        if (pWidth + pHeight + pLength > 50)
        {
            Console.WriteLine("package too big to be shipped via package express");
            int 
        }
        int result = (pWidth + pHeight + pLength) * pWidth / 100;
        Console.WriteLine("estimated total for shipping this package is" + result + "dollars.");
        Console.ReadLine();

    }
}
