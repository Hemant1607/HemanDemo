using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] s= { new Cube(), new Circle() };
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i].area());
                Console.WriteLine(s[i].volume());
            }

            Console.Read();
        }
    }
}
