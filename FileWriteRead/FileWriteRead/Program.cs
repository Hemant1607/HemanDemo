using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWriteRead
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\training\Eurotraining\FileHandling\mytest.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter ObjWrite = new StreamWriter(fs);
            ObjWrite.WriteLine("Hello and Welcome");
            ObjWrite.WriteLine("It is the first content");
            ObjWrite.WriteLine("of the text file mytest.txt");

            ObjWrite.Close();
            fs.Close();

            Console.WriteLine("Here is the contet of the file mytest.txt:");

            FileStream fr = new FileStream(@"C:\training\Eurotraining\FileHandling\mytest.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fr);
            while (sr.Peek() > 0)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();
            fr.Close();
            Console.Read();
        }
    }
}
