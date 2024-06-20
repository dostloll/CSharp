using System;

namespace AbstractClassExample
{
    // Abstract base class Shape
    public abstract class Shape
    {
        // Abstract method (does not have a body)
        public abstract double CalculateArea();

        // Concrete method
        public void DisplayArea()
        {
            Console.WriteLine($"The area is: {CalculateArea()}");
        }
    }

    // Derived class Circle inherits from Shape
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Overriding the abstract method CalculateArea
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Derived class Rectangle inherits from Shape
    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        // Overriding the abstract method CalculateArea
        public override double CalculateArea()
        {
            return Length * Width;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of Circle
            Shape myCircle = new Circle(5);
            Console.WriteLine("Circle:");
            myCircle.DisplayArea();

            // Creating an instance of Rectangle
            Shape myRectangle = new Rectangle(4, 7);
            Console.WriteLine("Rectangle:");
            myRectangle.DisplayArea();
        }
    }
}
