using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DeleteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file to be deleted");
            string routefolder = @"C:\training\Eurotraining\FileHandling";
            string filename = Console.ReadLine();
            string file = Path.Combine(routefolder, filename);
            Console.WriteLine(file);
            if (File.Exists(file))
            {
                File.Delete(file);
                Console.WriteLine("File deleted successfully");
                FileStream fs = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write);
                fs.Close();
            }
            else
            {
                Console.WriteLine("File does not exist");
                FileStream fs = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write);
                fs.Close();
            }
            Console.Read();
            
        }
    }
}
