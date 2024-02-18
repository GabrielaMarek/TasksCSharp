using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polimorphysm
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override void ShapeDetails()
        {
            Console.WriteLine($"This is a rectangle with width: {Width} and height: {Height}");
        }
    }
}
