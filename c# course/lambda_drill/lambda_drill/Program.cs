using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            Employees info = new Employees();
            info.FirstName = new List<string>() { "joe", "sam", "joe", "stef", "molly", "madeline", "jimmy", "wendy", "francis", "leanne" };
            info.LastName = new List<string>() { "smith", "leblanc", "bellerose", "moses", "christ", "isiah", "padmasambavah", "franky", "bloom", "hendricks" };
            info.ID = new List<int>() { 001, 002, 003, 004, 005, 006, 007, 008, 009, 010 };

            //3.
            List<string> firstName = info.FirstName.Where(firstName == FirstName.Joe).ToList();

            foreach (Employees first in firstName)
            {
                Console.WriteLine(first);
                Console.ReadLine();
            }

            //4. 
            List<int> EmpId = info.ID.Where(ID > 5);






        }
    }
}
