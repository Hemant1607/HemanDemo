using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyFirstConsoleApp
{
    class FileHandling
    {
        public string WriteFile()
        {
            int value;
            FileStream fs = new FileStream(@"C:\training\Eurotraining\FileHandling\temp.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter ObjWrite = new StreamWriter(fs);
            value = Convert.ToInt32(Console.ReadLine());
            ObjWrite.WriteLine("Course Details");
            ObjWrite.WriteLine("***************************");
            ObjWrite.WriteLine("Number of courses: "+value);
            ObjWrite.WriteLine();

            for (int i = 0; i < value; i++)
            {
                Console.Write("Enter registration number: ");
                int reg = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Course: ");
                string course = Console.ReadLine();
                Console.Write("Enter Course Title: ");
                string coursetitle = Console.ReadLine();
                Console.WriteLine();
                ObjWrite.WriteLine("Registration number :" + reg);
                ObjWrite.WriteLine("Course :" + course);
                ObjWrite.WriteLine("Title :" + coursetitle);
                ObjWrite.WriteLine();
            }
            ObjWrite.Close();
            fs.Close();
            return "Welcome";
        }
        public int ReadFile()
        {
            FileStream fs = new FileStream(@"C:\training\Eurotraining\FileHandling\temp.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine(sr.ReadLine());
            Console.WriteLine(sr.ReadLine());
            Console.WriteLine(sr.ReadLine());
            Console.WriteLine(sr.ReadLine());
            Console.WriteLine(sr.ReadLine());
           
            return 20;
        }
    }
}
