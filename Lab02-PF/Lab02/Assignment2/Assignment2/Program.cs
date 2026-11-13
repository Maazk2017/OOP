using System;

namespace Assingment2
{
    class Program
    {
        static void Main()
        {
            Problem1 p1 = new Problem1();
            p1.scholarship();
            Problem2 p2 = new Problem2();
            p2.calculator();
            Problem3 p3 = new Problem3();
            p3.bonusScore();
        }
    }

    class Problem1
    {
        public void scholarship()
        {
            Console.WriteLine("\n--- Problem 1 ---\n");
            Console.WriteLine("Enter attendance: ");
            double attendance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter marks: ");
            double marks = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter fee status (1 = Paid, 0 = Not Paid): ");
            int feeInput = Convert.ToInt32(Console.ReadLine());
            
            if (feeInput != 0 && feeInput != 1)
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            bool feePaid = (feeInput == 1);

            if (attendance > 85 && marks >= 40 && (marks >= 70 || feePaid))
            {
                Console.WriteLine("Student is eligible for the scholarship");
            } else
            {
                Console.WriteLine("Student is not eligible for scholarship");
            }

     
        }
    }

    class Problem2
    {
        public void calculator()
        {
            Console.WriteLine("\n--- Problem 2 ---\n");
            Console.WriteLine("Enter the first number: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operator ( +/ -/ */ / )");
            char ch = Convert.ToChar(Console.ReadLine());

            switch(ch) {
                case '+':
                    Console.WriteLine("Result = " + (n1 + n2));
                    break;

                case '-':
                    Console.WriteLine("Result = " + (n1 - n2));
                    break;

                case '*':
                    Console.WriteLine("Result = " + (n1 * n2));
                    break;

                case '/':
                    if (n2 != 0)
                    {
                        Console.WriteLine("Result = " + (n1 / n2));
                    } else
                    {
                        Console.WriteLine("Error: Division by zero!");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Operator!");
                    break;
            }
        }


    }

    class Problem3
    {
        public void bonusScore()
        {
            Console.WriteLine("\n--- Problem 3 ---\n");
            Console.WriteLine("Enter your score b/w 1 and 9");
            int score = Convert.ToInt32(Console.ReadLine());
            if (score >= 1 && score <= 3)
            {
                Console.WriteLine("Your final score is " + score * 10);
            } else if (score >= 4 && score <= 6)
            {
                Console.WriteLine("Your final score is " + score * 100);
            } else if (score >= 7 && score <= 9)
            {
                Console.WriteLine("Your final score is " + score * 1000);
            } else {
                Console.WriteLine("Invalid score");
            }
        }
    }


}