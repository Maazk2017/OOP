using System;

namespace MidTermPracticeQuestions
{
    internal class Publication9
    {
        public string Title;
        public double BasePrice;

        public virtual double CalculatePrice()
        {
            return BasePrice;
        }

        public virtual void Display()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Base Price: " + BasePrice);
        }
    }

    class Book : Publication9
    {
        public double Tax;

        public override double CalculatePrice()
        {
            return BasePrice + Tax;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Tax: " + Tax);
            Console.WriteLine("Final Book Price: " + CalculatePrice());
        }
    }

    class Magazine : Publication9
    {
        public int Months;

        public override double CalculatePrice()
        {
            return BasePrice * Months;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Months: " + Months);
            Console.WriteLine("Final Magazine Price: " + CalculatePrice());
        }
    }
}
