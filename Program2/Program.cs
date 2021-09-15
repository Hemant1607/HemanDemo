using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Console.Write("Enter number of values: ");
            FileHandling objFile = new FileHandling();
            objFile.WriteFile();
            Console.Read();
            //string value2 = objFile.ReadFile().ToString();
            //Console.WriteLine(value1);
            //Console.WriteLine(value2);
            //Console.Read();
            //int value1; int value2; int value3, value4, value5; float value6;
            //Console.Write("Enter value1: ");
            //value1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter value2: ");
            //value2 = Convert.ToInt32(Console.ReadLine());
            //value3 = value1 + value2;
            //value4 = value2 - value1;
            //value5 = value1 * value2;
            //value6 = value2 / value1;
            //Console.WriteLine("Addition: " + value1 * value2);
            //Console.WriteLine("Subtraction: " + value4);
            //Console.WriteLine("Multiplication: " + value5);
            //Console.WriteLine("Division: " + value6);
            //Console.Read();

        }
    }
}
