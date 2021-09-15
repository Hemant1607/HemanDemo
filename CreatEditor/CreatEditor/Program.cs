using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CreatEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists(@"C:\training\Eurotraining\FileHandling\mytest.txt"))
            {
                FileStream fr = new FileStream(@"C:\training\Eurotraining\FileHandling\mytest.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fr);
                while (sr.Peek() > 0)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
            else
            {
                FileStream fs = new FileStream(@"C:\training\Eurotraining\FileHandling\mytest.txt", FileMode.OpenOrCreate, FileAccess.Write);
                Console.WriteLine("A file created with name mytest.txt");
            }
            Console.Read();
        }
    }
}
