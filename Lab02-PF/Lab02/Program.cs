using System;

namespace Lab02
{
    class Program
    {
        static void Main()
        {
            Example2 e2 = new Example2();
            e2.Operators();
            Example4 e4 = new Example4();
            e4.Compare();
            Example5 e5 = new Example5();
            e5.checkVowel();
            Task t = new Task();
            t.trapeziod();
        }
    }

    class Example2
    {
        public void Operators()
        {
            int attendance = 94;
            double grade = 88.5;
            bool hasPaidFees = true;

            bool canGraduate = (attendance > 90) &&
                                (grade >= 50 || hasPaidFees) &&
                                !(grade < 40);
            Console.WriteLine("Can Graduate: " + canGraduate);
            // Increment operator
            Console.WriteLine("Attendance before increment: " + attendance);
            Console.WriteLine("Attendance++ result " + attendance++);
            Console.WriteLine("Attendance after increment " + attendance);
            // Arithemetic precedence
            Console.WriteLine("\nOperator Precedence Example:");
            int result1 = 5 + 3 * 2;
            int result2 = (5 + 3) * 2;
            Console.WriteLine("5 + 3 * 2 = " + result1);
            Console.WriteLine("(5+3) * 2 = " + result2);
            // Logical NOT operator
            Console.WriteLine("\nLogical NOT Operator");
            Console.WriteLine("Has Paid Fees: " + hasPaidFees);
            Console.WriteLine("After ! operator: " + !hasPaidFees);
            // Ternary Operator
            Console.WriteLine("\nTernary Operator");
            string result = (grade >= 50) ? "Pass" : "Fail";
            Console.WriteLine("Result: " + result);
            // Null-Coalesing Operator
            Console.WriteLine("\nNull-Coalescing Operator");
            int? a = 5;
            Console.WriteLine("Value of a: " + ((a ?? -1)));
            // Cascade Assignment
            Console.WriteLine("\nCascade Assignment:");
            int x, y, z;
            x = y = z = 10;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);
        }
    }

    class Example4
    {
        public void Compare()
        {
            int i = 10, j = 20;
            if (i != j)
            {
                if (i < j)
                {
                    Console.WriteLine("i is less than j");
                } else if (i > j)
                {
                    Console.WriteLine("i is greater than j");
                }
            } else
            {
                Console.WriteLine("i is equal to j");
            }
        }
    }

    class Example5
    {
        public void checkVowel()
        {
            char ch;
            Console.WriteLine("Enter an alphabet");
            ch = Convert.ToChar(Console.ReadLine());

            switch (Char.ToLower(ch))
            {
                case 'a':
                    Console.WriteLine("Vowel");
                    break;
                case 'e':
                    Console.WriteLine("Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Vowel");
                    break;
                case 'o':
                    Console.WriteLine("Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Not a vowel");
                    break;

            }
        }
    }

    class Task
    {
        public void trapeziod()
        {
            Console.WriteLine("Enter side a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter side b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height h: ");
            int h = Convert.ToInt32(Console.ReadLine());
            int area = ((a + b) / 2) * h;
            Console.WriteLine("Area is: " + area);

        }
    }
}