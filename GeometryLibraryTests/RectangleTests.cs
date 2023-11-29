using GeometryLibrary.Implementations;
using NUnit.Framework;
using System;

namespace GeometryLibraryTests
{
    [TestFixture]
    public class RectangleTests
    {
        private Rectangle _rectangle;

        [SetUp]
        public void SetUp()
        {
            _rectangle = new Rectangle(5, 10);
        }

        [Test]
        public void GetPerimeter_Valid()
        {
            // Act
            double perimeter = _rectangle.GetPerimeter();

            // Assert
            Assert.AreEqual(5 * 2 + 10 * 2, perimeter);
        }

        [Test]
        public void GetArea_Valid()
        {
            // Act
            double area = _rectangle.GetArea();

            // Assert
            Assert.AreEqual(5 * 10, area);
        }

        [Test]
        public void Constructor_NegativeWidth_ThrowsArgumentException()
        {
            // Act & Assert
            Assert.Throws<AggregateException>(() => new Rectangle(-5, 10), "width");
        }

        [Test]
        public void Constructor_NegativeHeight_ThrowsArgumentException()
        {
            // Act & Assert
            Assert.Throws<AggregateException>(() => new Rectangle(5, -10), "height");
        }

        [Test]
        public void Constructor_ZeroWidth_ThrowsArgumentException()
        {
            // Act & Assert
            Assert.Throws<AggregateException>(() => new Rectangle(0, 10), "width");
        }

        [Test]
        public void Constructor_ZeroHeight_ThrowsArgumentException()
        {
            // Act & Assert
            Assert.Throws<AggregateException>(() => new Rectangle(5, 0), "height");
        }
    }
}