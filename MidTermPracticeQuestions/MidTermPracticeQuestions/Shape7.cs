using System;

namespace MidTermPracticeQuestions
{
    internal class Shape7
    {
        public virtual double Area()
        {
            return 0;
        }

        public virtual double Perimeter()
        {
            return 0;
        }

    }

    internal class Rectangle : Shape7
    {

        protected double width;
        protected double height;


        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double Area()
        {
            return width * height;
        }

        public override double Perimeter()
        {
            return 2 * (width + height);
        }

    }

    internal class Square : Rectangle
    {
        public Square(double s) : base (s, s)
        {

        }

        public override double Area()
        {
            return width * width; 
        }

        public override double Perimeter()
        {
            return 4 * width; 
        }

    }
}
