using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {

        string[] colorArray = new string[] { "red", "orange", "yellow", "green", "blue", "purple" };

        List<string> intList = new List<string>();
        stringList.Add(red);
        stringList.Add(orange);
        stringList.Add(yellow);
        stringList.Add(green);
        stringList.Add(blue);
        stringList.Add(purple);

        Console.WriteLine("choose a color from these : ");
        for (int i = 0; i < colorArray.Length; i += 1)
        {
            Console.WriteLine("{0} = {1}", i, colorArray[i]);
        }



        int[] numArray = new int[6];
        numArray[0] = 10;
        numArray[1] = 100;
        numArray[2] = 20;
        numArray[3] = 200;
        numArray[4] = 30;
        numArray[5] = 300;

        bool start = true;
        while (start)
        {
            Console.WriteLine("choose number from: ");
            int numb = Convert.ToInt32(Console.ReadLine());
        }

        if (numb < colorArray.Length)
        {
            Console.WriteLine("you've chosen '{0}'!", colorArray[numb]);
            start = false;
        }
        else
        {
            Console.WriteLine("nope! try another choice");

        }
    Console.ReadLine();
    }

    
}
