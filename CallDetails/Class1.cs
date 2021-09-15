using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CallDetails
{
    class Class1
    {
        public int ReadFile()
        {
            FileStream fs = new FileStream(@"C:\training\Eurotraining\FileHandling\temp2.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string[] j;
            while (sr.Peek()> 0)
            {
                
                for (int i = 0; i < 4; i++)
                {
                    string line = sr.ReadLine();
                    j = line.Split(':');
                    if (i == 2)
                    {
                        string[] k = j[1].Split(' ');
                        Console.Write(k[0]);
                        Console.Write("\t");
                        continue;
                    }      
                    Console.Write(j[1]);
                    Console.Write("\t");
                    
                }
                
                Console.WriteLine();
                string line1 = sr.ReadLine();
            }
        
            return 20;
        }
    }
}
