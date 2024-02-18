using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polimorphysm
{
    public class Shape
    {
        public virtual double CalculateArea()
        {
            return 0;
        }
        public virtual void ShapeDetails()
        {
            Console.WriteLine("This is a shape");
        }
    }
}
