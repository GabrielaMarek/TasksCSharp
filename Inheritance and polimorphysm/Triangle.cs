using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polimorphysm
{
    class Triangle : Shape
    {
        public double Base {  get; set; }
        public double Height { get; set; }

        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }

        public override void ShapeDetails()
        {
            Console.WriteLine($"This is a triangle with base: {Base} and height: {Height}");
        }
    }
}
