using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Questions
{
    internal class Question2
    {
        public void ErrorHandling()
        {
            try
            {
                double num1;
                double num2;
                double result;
                Console.WriteLine("Enter first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                try
                {
                    result = num1 / num2;
                } catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"cannot divide by zero");
                }
            } catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
