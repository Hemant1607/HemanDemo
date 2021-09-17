using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape.setColor("Red");
            string s=Shape.getColor();
            Console.WriteLine(s);
            Double a=Shape.Area();
            Console.WriteLine(a);
            Rectangle r = new Rectangle(4, 5, "Blue");
            Double area=Rectangle.Area();
            string s1 = Rectangle.getColor();
            Console.WriteLine(s1);
            Rectangle.displayArea(area);
            Console.Read();
        }
    }
}
