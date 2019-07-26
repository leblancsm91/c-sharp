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
        int hourlyRate1 = Convert.ToInt((Console.ReadLine());

        Console.WriteLine("What are the hours worked per week?");
        int hoursWorked1 = Console.ReadLine(30);

        Console.WriteLine("Person 2");
        Console.WriteLine("What is the hourly rate?");
        int hourlyRate2 = Console.ReadLine(13);

        Console.WriteLine("What are the hours worked per week?");
        int hoursWorked2 = Console.ReadLine(40);

        Console.WriteLine("Weekly salary of Person 1");
        int salaryp1 = (hourlyRate1 * hoursWorked1);
        Console.ReadLine();

        Console.WriteLine("Weekly salary of Person 2");
        int salaryp2 = (hourlyRate2 * hoursWorked2);
        Console.ReadLine();

        Console.WriteLine("Does Person1 make more than Person2?");
        bool answer = salaryp1 > salaryp2;
        Console.WriteLine(answer);
        Console.ReadLine();
    }
}
