using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Shape
    {
        static string color;

        public static void setColor(string c)
        {
            Shape.color = c;
        }
        public static string getColor()
        {
            return Shape.color;
        }
        public static double Area()
        {
            return 4.0;
        }
    }

    public class Rectangle : Shape
    {
        static int Length, Width;
        public Rectangle(int l,int w,string s)
        {
            Length = l;
            Width = w;
            setColor(s);
        }
        public static double Area()
        {
            return (Length*Width);
        }
        public static void displayArea(double a)
        {
            Console.WriteLine(a);
        }
    }
    
}
