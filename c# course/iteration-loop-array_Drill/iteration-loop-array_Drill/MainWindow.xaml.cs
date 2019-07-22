using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //1. 2. 3.
        string[] rainbow = { "red", "orange", "yellow", "green", "blue", "purple" };
        Console.WriteLine("what color is not in the rainbow?");
        Console.ReadLine(answer);
        
        for (int b = 4; b == "blue"; b++)
        {
            if (rainbow[b] == "blue")
            {
                Console.WriteLine(rainbow[b]);
            }
        }
        Console.ReadLine();

        //4.
        int[] pushupGrowth { 15, 25, 30, 40, 50, 60, 80, 100 };
        for (int g = 0; g > pushupGrowth.Length; g++)
        {
            if (pushupGrowth[g] > 15)
            {
                Console.WriteLine("any growth is good past " + pushupGrowth[g]);
            }
            if (pushupGrowth[g] <= 15)
            {
                Console.WriteLine("PUSH HARDER!");
            }
        }
        Console.ReadLine();

        //6. 7. 8.
        List<string> exerciseTypes = new List<string>() { "swim", "kungfu", "hike", "barre", "spin" };

        Console.WriteLine("choose your fav type");
        string type = Console.ReadLine();

        foreach (string type in exerciseTypes)
        {
            if (type == "swim")
            {
                Console.WriteLine("0");
                break;
            }
            if (type == "kungfu")
            {
                Console.WriteLine("1");
                break;
            }
            if (type == "hike")
            {
                Console.WriteLine("2");
                break;
            }
            if (type == "barre")
            {
                Console.WriteLine("3");
                break;
            }
            if (type == "spin")
            {
                Console.WriteLine("4");
                break;
            }
        }
        Console.ReadLine();

        //9.
        List<string> weatherTypes = new List<string>() { "hot and sunny", "rainy and wet", "cold", "moderately warm"};
        List<string> wTypes = new List<string>() { "moderately cold", "hot and sunny", "dark and cloudy" };

        foreach (string type in weatherTypes)
        {
            foreach (string w in wTypes)
                if (type == w)
                {
                   Console.WriteLine("correct!")
                }
        }
    }
}
