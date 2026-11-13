using System;

namespace Lab08.Assignment08
{
    internal class Calculator
    {
        public double CalculateArea(double radius)
        {
            return 3.142 * radius;
        }

        public double CalculateArea(double length, double width)
        {
            return length * width;
        }

        public double CalculateArea(int side)
        {
            return side * side;
        }
    }
}
