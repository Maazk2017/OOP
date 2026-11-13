using System;

namespace Lab08
{
    internal class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }

    internal class Circle() : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }

    internal class Rectangle() : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }
}
