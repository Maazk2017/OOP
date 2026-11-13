using System;

namespace Lab09
{
    internal class Generalization
    {
        //Generalization is an Object-Oriented relationship that represents an “is-a” association between
        //classes.It is achieved through inheritance, where a derived class inherits data members and
        //behaviors from a base class. This relationship promotes reusability, extensibility, and
        //polymorphism, enabling the creation of hierarchical class structures.
    }

    internal class Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Shape");
        }
    }
    internal class Circle : Shape
    {
        public void CircleArea()
        {
            double radius = 5;
            double area = 3.14 * radius * radius;
            Console.WriteLine("Area of Circle: " + area);
        }
    }
}
