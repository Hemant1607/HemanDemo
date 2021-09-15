using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CreateFile
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\training\Eurotraining\FileHandling\mytest.txt", FileMode.OpenOrCreate, FileAccess.Write);
            Console.WriteLine("A file created with name mytest.txt");
            Console.Read();
            fs.Close();
        }
    }
}
