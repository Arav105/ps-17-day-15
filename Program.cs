using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(6);
            circle.PrintInfo();

            Rect rectangle = new Rect(5, 8);
            rectangle.PrintInfo();

            Tri triangle = new Tri(3, 3, 3);
            triangle.PrintInfo();

            Console.ReadKey();
        }
    }
    
}
