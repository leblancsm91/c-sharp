using System;
using System.Collections.Generic;
class Program
{
    private static void Main(string[] args)
    {
        List<int> intList = new List<int>();
        intList.Add(50);
        intList.Add(30);
        intList.Add(10);

        Console.ReadLine();

        try
        {
            Console.WriteLine("pick a number");
            int numberOne = Convert.ToInt32(Console.ReadLine());

            foreach (int number in intList)
            {
                int answer1 = number / numberOne;
                Console.WriteLine(answer1);
            }
        }

        catch (FormatException ex)
        {
            Console.WriteLine("type whole number only");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("don't divide by zero");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine("the program is continuinig");
        Console.ReadLine();
    }
}

