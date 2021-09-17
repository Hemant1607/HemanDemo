using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticList
{
    class Program
    {
        static void Main(string[] args)
        {
            List < int > IntNumbers= new List<int>() { 
            10,21,43,42,56,75,45,89,78,90,24,35};
            EvenSum(IntNumbers);
            Console.Read();
        }
        static void EvenSum(List<int> l)
        {
            foreach (int i in l)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
