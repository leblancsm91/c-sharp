using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{ 
    static void Main()
        {
        Console.WriteLine("What is your age?");
        int age = Convert.ToInt32(Console.ReadLine(if > 15));

        Console.WriteLine("Have you ever had a DUI?");
        string dui = Console.ReadLine(if no = true, else = false);

        Console.WriteLine("How many sppeeding tickets do you have?");
        int tickets = Convert.ToInt32(Console.ReadLine(if < 3 = tr));

        string approval = "";
        if (age > 15 && dui == "no" && tickets < 3)
        {
            approval = "are";
        }
        else
        {
            approval = "are not";
        }

        Console.WriteLine("you " + approval + "qualified for car insurance with this fake insurance company.");
       
    }

}
