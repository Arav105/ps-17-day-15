using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps_17
{
    public class Rect : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rect(double width, double height)
        {
            ShapeType = "Rectangle";
            Width = width;
            Height = height;
        }

        public override double Area => Width * Height;
        public override double Perimeter => 2 * (Width + Height);
    }
}
