using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SpecificLineRead
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\training\Eurotraining\FileHandling\mytest.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter ObjWrite = new StreamWriter(fs);
            Console.Write("Enter number of lines to be written in file: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter line" + (i + 1) + ":");
                string s = Console.ReadLine();
                ObjWrite.WriteLine(s);
            }
            ObjWrite.Close();
            fs.Close();

            Console.Write("Enter line number to be read: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            FileStream fr = new FileStream(@"C:\training\Eurotraining\FileHandling\mytest.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fr);
            int j = 1;
            while (sr.Peek() > 0)
            {
                string line = sr.ReadLine();
                if (num1 == j)
                {
                    Console.WriteLine("Contents of line" + num1 + " in mytest.txt is:");
                    Console.WriteLine(line);
                }
                j++;
            }
            Console.Read();
        }
    }
}
