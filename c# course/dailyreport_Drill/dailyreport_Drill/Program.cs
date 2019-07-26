using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");
        Console.ReadLine();

        Console.WriteLine("What course are you on?");
        string course = Console.ReadLine();

        Console.WriteLine("What page number?");
        int pageNumber = Console.ReadLine();

        Console.WriteLine("Do you need help with anything?");
        bool answer = Console.ReadLine(if yes = true, else = false);

        Console.WriteLine("Were there any positive experiences you had? If so, please be specific");
        string positiveExp = Console.ReadLine();

        Console.WriteLine("Is there any feedback you would like to provide?");
        string feedBack = Console.ReadLine();

        Console.WriteLine("How many hours did you study today?");
        char hoursStudied = Console.ReadLine();

        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

    }
}
