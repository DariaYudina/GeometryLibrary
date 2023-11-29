using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Implementations
{
    public class Square : Shape
    {
        public double Side { get; }

        public Square(double side)
        {
            ValidatePositiveValues((nameof(side), side));
            Side = side;
        }

        public override double GetPerimeter() => 4 * Side;

        public override double GetArea() => Math.Pow(Side, 2);
    }
}
