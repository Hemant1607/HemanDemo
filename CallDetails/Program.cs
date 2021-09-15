using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source" + "\t\t" + "Destination" + "\t" + "Date" + "\t\t" + "Call Status");
            Class1 objFile = new Class1();
            objFile.ReadFile();
            Console.Read();
        }
    }
}
