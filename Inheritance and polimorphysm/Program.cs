using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polimorphysm
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
                new Rectangle { Width = 10, Height = 7 },
                new Circle { Radius = 2 },
                new Triangle { Base = 3, Height = 4 },
            };

            foreach (Shape shape in shapes)
            {
                shape.ShapeDetails();
                Console.WriteLine($"Area: {shape.CalculateArea()}");
                Console.ReadKey();
            }
        }
    }
}
