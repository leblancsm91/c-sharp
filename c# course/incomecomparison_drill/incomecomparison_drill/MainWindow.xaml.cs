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

        Console.WriteLine("Person 1");
        Console.WriteLine("What is the hourly rate?");
        int hourlyRate1 = Console.ReadLine(12);

        Console.WriteLine("What are the hours worked per week?");
        int hoursWorked1 = Console.ReadLine(30);

        Console.WriteLine("Person 2");
        Console.WriteLine("What is the hourly rate?");
        int hourlyRate2 = Console.ReadLine(13);

        Console.WriteLine("What are the hours worked per week?");
        int hoursWorked2 = Console.ReadLine(40);

        Console.WriteLine("Weekly salary of Person 1");
        int salaryp1 = Console.ReadLine(hourlyRate1 * hoursWorked1);

        Console.WriteLine("Weekly salary of Person 2");
        int salaryp2 = Console.ReadLine(hourlyRate2 * hoursWorked2);

        Console.WriteLine("Does Person1 make more than Person2?");
        bool answer = Console.ReadLine(if yes = true, else = false);
    }
}
