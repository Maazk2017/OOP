using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MidTermPracticeQuestions
{
    internal class Shape2
    {
        private string color;
        private bool filled;
        protected double pi = 3.141592653589793;

        public void getColor()
        {
            Console.WriteLine($"Color {color}");
        }

        public virtual double getArea()
        {
            return 0;
        }
    }

    internal class Circle : Shape2
    {
        private double radius;
        public double circumference;

        public override double getArea()
        {
            return pi * radius * radius;
        }

        public double getCircumference()
        {
            circumference = 2 *pi * radius;
            return circumference;
        }

        public void Display()
        {
            base.getColor();
            Console.WriteLine($"Radius: {radius}");
            Console.WriteLine($"Area: {getArea()}");
            Console.WriteLine($"Circumference: {getCircumference()}");
        }
    }
}
