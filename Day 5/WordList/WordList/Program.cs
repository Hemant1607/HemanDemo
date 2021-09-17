using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> WordList = new List<string>() { 
            "Hello","Hi","How","Congratulations","Super","Time","Where"};
            Console.WriteLine("Enter the length of word you want to find:");
            int n = Convert.ToInt32(Console.ReadLine());
            WordLength(WordList,n);
            Console.Read();
        }
        static void WordLength(List<string> words,int i)
        {
            int temp = 0;
            foreach(string s in words)
            {
                if (s.Length == i)
                {
                    Console.WriteLine(s);
                    temp = 1;
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("No word of this length is present in list");
            }
        }
    }
}
