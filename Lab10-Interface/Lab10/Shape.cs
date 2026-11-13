using System;

namespace Lab10
{
    abstract class Shape
    {
        public string color { get; set;  }

        public Shape(string color)
        {
            this.color = color;
        }

        // abstract methods — MUST be implemented by subclasses
        public abstract double CalculateArea();
        public abstract void Draw();

        public void DisplayInfo()
        {
            // GetType() returns the actual runtime type of the object
            Console.WriteLine($"Shape: {GetType().Name}, Color: {color}");
            Console.WriteLine($"Area: {CalculateArea():F2}"); // 2 decimal places
        }

    }

    class Circle : Shape
    {
        public double radius { get; set; }

        public Circle(string color, double radius) : base(color)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {color} circle with radius {radius}");
        }
    }

    class Rectangle : Shape
    {
        public double width { get; set; }
        public double height { get; set; }

        public Rectangle(string color, double width, double height) : base(color)
        {
            this.width = width;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return  width * height;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {color} rectangle ({width} x {height})");
        }
    }

    class Triangle : Shape
    {
        public double Base { get; set; }
        public double height { get; set; }
        public Triangle(string color, double b, double h) : base(color)
        {
            Base = b;
            height = h;
        }
        public override double CalculateArea()
        {
            return 0.5 * Base * height;
        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing a {color} triangle base = {Base} and height = {height}");
        }
    }

    class Square : Shape
    {
        public double side { get; set; }

        public Square(string color, double side) : base(color)
        {
            this.side = side;
        }

        public override double CalculateArea()
        {
            return side * side;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {color} square side = {side}");
        }
    }
}
