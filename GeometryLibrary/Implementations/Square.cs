using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Implementations
{
    internal class Square : Shape
    {
        private readonly double _side;

        public Square(double side)
        {
            ValidatePositiveValues((nameof(side), side));
            _side = side;
        }

        public override double GetPerimeter() => 4 * _side;

        public override double GetArea() => Math.Pow(_side, 2);
    }
}
