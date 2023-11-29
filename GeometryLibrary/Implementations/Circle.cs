using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Implementations
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double GetPerimeter() => Radius * 2 * Math.PI;
        public override double GetArea() => Math.PI * Radius * Radius;
        public Circle(double radius)
        {
            ValidatePositiveValues((nameof(radius), radius));
            Radius = radius;
        }
    }
}
