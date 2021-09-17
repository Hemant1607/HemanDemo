using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphism
{
    interface Shape
    {
        Double area();
        Double volume();
    }
    class Cube : Shape
    {
        int x = 10;
        public Double area()
        {
            return (6 * x * x);
        }
        public Double volume()
        {
            return (x * x * x);
        }
    }
    class Circle : Shape
    {
        int radius = 10;
        public Double area()
        {
            return (Math.PI*radius*radius);
        }
        public Double volume()
        {
            return 0;
        }
    }
}
