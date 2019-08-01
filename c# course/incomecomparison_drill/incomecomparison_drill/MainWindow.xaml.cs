using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Console.Write("Anonymous Income Comparison Program");

        Console.WriteLine("Weekly hourly rate of person 1");
        int hourlyRate1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What are the hours worked per week?");
        int hoursWorked1 = Console.ReadLine();

        Console.WriteLine("Person 2");
        Console.WriteLine("What is the hourly rate?");
        int hourlyRate2 = Console.ReadLine();

        Console.WriteLine("What are the hours worked per week?");
        int hoursWorked2 = Console.ReadLine();

        int salaryp1 = (hourlyRate1 * hoursWorked1);

        int salaryp2 = (hourlyRate2 * hoursWorked2);

        Console.WriteLine("Does Person1 make more than Person2?");
        bool answer = salaryp1 > salaryp2;
        if (answer == true)
        {
            Console.WriteLine(answer);
        }
        else
        {
            Console.WriteLine(answer);
        }
        Console.ReadLine();
    }
}
