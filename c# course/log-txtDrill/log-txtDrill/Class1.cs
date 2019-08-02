using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log_txtDrill
{
    public sclass Class1
    {
        string randomClass = string.Format(class2.randomClass.First());
        Console.WriteLine(randomClass);
        using (StreamWriter File = new StreamWriter(@"C:\\Users\\Owner\\c-sharp\\c# course\\log1.txt", true))
        {
            File.WriteLine(randomClass);
        }
    }
}
