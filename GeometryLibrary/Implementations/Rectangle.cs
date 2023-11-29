using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Implementations
{
    public class Rectangle : Shape
    {
        public float Width { get; set; }
        public float Height { get; set; }

        public Rectangle(float width, float height)
        {
            ValidatePositiveValues((nameof(width), width), (nameof(height), height));
            Width = width;
            Height = height;
        }

        public override double GetPerimeter() => Width * 2 + Height * 2;
        public override double GetArea() => Width * Height;
    }
}
