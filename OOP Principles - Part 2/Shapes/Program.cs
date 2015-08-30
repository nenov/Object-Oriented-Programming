using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
                new Rectangle(5, 2),
                new Triangle(2.1, 3),
                new Square(5.5)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("{0:F2}", shape.CalculateSurface());
            }
        }
    }
}
