using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //1. 2. 3.
        string[] rainbow = { "red", "orange", "yellow", "green", "blue", "purple" };
        Console.WriteLine("chhoose a color: ");
        string answer = Console.ReadLine();
        answer = answer.ToUpper();
        
        if (answer == "blue")
        {
            Console.WriteLine("good. {0} is not apart of hte rainbow", answer);
        }
        else
        {
            Console.WriteLine("nope! {0} is actually in a rainbow!", answer);
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
        
        //9. 10. 
        List<string> weatherTypes = new List<string>() { "hot", "wet", "cold", "moderate", "hot" };

        Console.WriteLine("type a climate that is in the list");
        string answerW = Console.ReadLine();
        if (weatherTypes.Contains(answerW))
        {
            for (int W = 0; W < weatherTypes.Count; W++)
            {
                Console.WriteLine(W);
            }
        }
        else
        {
            Console.WriteLine("your input is n ot apart of the weatheer/climates on the list");
        }
        Console.ReadLine();

        //10.
        List<string> patterns = new List<string>() { "spots", "stripes", "stripes" };

        foreach (string pattern in patterns)
        {
            Console.WriteLine(pattern);
            if ("spots")
            {
                Console.WriteLine("it's on the list,your'eright!");
            }
            if ("stripes")
            {
                Console.WriteLine("it already appearsonthe list!");
            }
            else
            {
                Console.WriteLine("tha'ts not onthe array list");
            }
        }
        Console.ReadLine();
    }
}
