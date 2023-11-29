using GeometryLibrary.Implementations;
using NUnit.Framework;
using System;

namespace GeometryLibraryTests
{
    [TestFixture]
    public class SquareTests
    {
        private Square _square;

        [SetUp]
        public void SetUp()
        {
            _square = new Square(5);
        }

        [Test]
        public void GetPerimeter_Valid()
        {
            // Act
            double perimeter = _square.GetPerimeter();

            // Assert
            Assert.AreEqual(4 * 5, perimeter);
        }

        [Test]
        public void GetArea_Valid()
        {
            // Act
            double area = _square.GetArea();

            // Assert
            Assert.AreEqual(Math.Pow(5, 2), area);
        }

        [Test]
        public void Constructor_NegativeSide_ThrowsArgumentException()
        {
            // Act & Assert
            Assert.Throws<AggregateException>(() => new Square(-5), "side");
        }

        [Test]
        public void Constructor_ZeroSide_ThrowsArgumentException()
        {
            // Act & Assert
            Assert.Throws<AggregateException>(() => new Square(0), "side");
        }
    }
}