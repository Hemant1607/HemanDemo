using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace NumLines
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\training\Eurotraining\FileHandling\mytest.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("Here are the contents of mytest.txt:");
            int j = 0;
            while (sr.Peek() > 0)
            {
                Console.WriteLine(sr.ReadLine());
                j++;
            }
            Console.WriteLine("Number of lines in mytest.txt is: " + j);
            Console.Read();
        }
    }
}
