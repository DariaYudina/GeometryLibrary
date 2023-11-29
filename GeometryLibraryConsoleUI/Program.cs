using GeometryLibrary.Implementations;
using GeometryLibrary.Interfaces;

namespace GeometryLibraryConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Rectangle rectangle = new Rectangle(20, 20);
                Circle circle = new Circle(200);
                Triangle triangle = new Triangle(3, 4, 5);
                PrintShape(rectangle);
                PrintShape(circle);
                PrintShape(triangle);
            }
            catch (AggregateException ex)
            {
                foreach (var innerEx in ex.InnerExceptions)
                {
                    if (innerEx is ArgumentException argEx)
                    {
                        Console.WriteLine($"Validation error: {argEx.Message}");
                    }
                    else
                    {
                        Console.WriteLine($"An unexpected error occurred: {innerEx.Message}");
                    }
                }
            }
        }

        static void PrintShape(IShape shape)
        {
            Console.WriteLine(shape.GetType().Name + ":");
            
            Console.WriteLine($"Perimeter: {shape.GetPerimeter()}  Area: {shape.GetArea()}");
            if (shape is Triangle)
            {
                var isRight = ((Triangle)shape).IsRightTriangle();
                Console.WriteLine($"Triangle is right triangle: {isRight}");
            }
        }
    }
}
