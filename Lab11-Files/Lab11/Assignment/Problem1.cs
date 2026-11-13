using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11.Assignment
{
    internal class Problem1
    {
        public void InputNumbers()
        {
            try
            {
                Console.WriteLine("Enter the first number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 / num2;

            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Error: Please enter valid numeric values.");
            }
        }
    }
}
