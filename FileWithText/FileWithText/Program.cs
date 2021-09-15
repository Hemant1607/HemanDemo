using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileWithText
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
            Console.WriteLine("A file created with content name mytest.txt");
            Console.Read();
        }
    }
}
