using GeometryLibrary.Implementations;
using NUnit.Framework;

namespace GeometryLibraryTests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void Constructor_ValidSides_CreatesTriangle()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            // Act
            var triangle = new Triangle(sideA, sideB, sideC);

            // Assert
            Assert.IsNotNull(triangle);
            Assert.AreEqual(sideA, triangle.SideA);
            Assert.AreEqual(sideB, triangle.SideB);
            Assert.AreEqual(sideC, triangle.SideC);
        }

        [Test]
        public void Constructor_InvalidSides_ThrowsArgumentException()
        {
            // Arrange
            double sideA = 1;
            double sideB = 2;
            double sideC = 5; // Невозможно построить треугольник с такими сторонами

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Test]
        public void IsRightTriangle_RightTriangle_ReturnsTrue()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.IsTrue(isRightTriangle);
        }

        [Test]
        public void IsRightTriangle_NonRightTriangle_ReturnsFalse()
        {
            // Arrange
            double sideA = 2;
            double sideB = 3;
            double sideC = 4;

            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.IsFalse(isRightTriangle);
        }

        [Test]
        public void IsRightTriangle_EqualSides_ReturnsFalse()
        {
            // Arrange
            var triangle = new Triangle(5, 5, 5);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.IsFalse(isRightTriangle);
        }

        [Test]
        public void GetPerimeter_ValidTriangle_ReturnsCorrectValue()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            double perimeter = triangle.GetPerimeter();

            // Assert
            Assert.AreEqual(sideA + sideB + sideC, perimeter);
        }

        [Test]
        public void GetArea_ValidTriangle_ReturnsCorrectValue()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            double area = triangle.GetArea();

            // Assert
            double semiPerimeter = triangle.GetPerimeter() / 2;
            double expectedArea = System.Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
            Assert.AreEqual(expectedArea, area);
        }

        [Test]
        public void Constructor_NegativeSides_ThrowsArgumentException()
        {
            // Arrange & Act & Assert
            Assert.Throws<AggregateException>(() => new Triangle(-3, 4, 5));
            Assert.Throws<AggregateException>(() => new Triangle(3, -4, 5));
            Assert.Throws<AggregateException>(() => new Triangle(3, 4, -5));
        }
    }
}
