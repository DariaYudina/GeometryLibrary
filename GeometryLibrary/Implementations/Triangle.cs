using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Implementations
{
    public class Triangle : Shape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            ValidatePositiveValues((nameof(sideA), sideA), (nameof(sideB), sideB), (nameof(sideC), sideC));

            if (!IsTriangleValid(sideA, sideB, sideC))
                throw new ArgumentException("The triangle with the given sides does not exist");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public bool IsRightTriangle()
        {
            double[] sides = { SideA, SideB, SideC };
            Array.Sort(sides);

            // Проверка на то, является ли треугольник прямоугольным
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }

        public override double GetPerimeter() => SideA + SideB + SideC;

        public override double GetArea()
        {
            double semiPerimeter = GetPerimeter() / 2;
            // Формула Герона для вычисления площади треугольника
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }

        private static bool IsTriangleValid(double sideA, double sideB, double sideC)
        {
            // Проверка неравенства треугольника
            return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
        }
    }
}
