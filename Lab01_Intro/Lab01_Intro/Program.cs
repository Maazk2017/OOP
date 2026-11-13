using Lab01_Intro;
using System;  // Import the System library to use Console

namespace Lab01_intro // Namespace is used to organize related classes in a project
{
    class Program // Everything in C# is written inside a class
    {
        static void Main()  // All C# programs start execution from Main()
        {
            //Console.WriteLine("What's up");
            //Example1 example1Object = new Example1();
            //example1Object.DisplayMessage();
            //Example2 example2Object = new Example2();
            //example2Object.InputMessage();
            Example3 example3Object = new Example3();
            example3Object.EscapeSequence();
            //Example4 example4Object = new Example4();
            //example4Object.DataTypeFormat();
            Example5 example5Object = new Example5();
            example5Object.Alignment();

            //Question1 q1 = new Question1();
            //q1.GenerateOuptut();

            //Question2 q2 = new Question2();
            //q2.Format();
        }
    }

    //class Example1
    //{
    //    public void DisplayMessage()
    //    {
    //        Console.WriteLine("Welcome to OOP Lab");
    //        Console.WriteLine("Introduction ");
    //        Console.WriteLine("to C#. ");
    //        Console.WriteLine("This is an Object Oriented Programming Language");
    //    }
    //}

    //class Example2
    //{
    //    public void InputMessage()
    //    {
    //        Console.WriteLine("Enter your name");
    //        string name = Console.ReadLine();
    //        Console.WriteLine("Your name is " + name);
    //    }
    //}

    class Example3
    {
        public void EscapeSequence()
        {
            Console.WriteLine("\n-------------- Example3 --------------\n");
            Console.WriteLine("Tab:\t Hello, World!");
            Console.WriteLine("Backspace: ABC\bD");
            Console.WriteLine("New Line: \nHello\nWorld");
            Console.WriteLine("Carriage return: JAVA\rPYTHON");
            Console.WriteLine("Single Quote: It\'s C#!");
            Console.WriteLine("Double Quote: \"C# is awesome!\"");
            Console.WriteLine("Backslash: C:\\User\\Documents");
        }
    }

    //class Example4
    //{
    //    public void DataTypeFormat()
    //    {
    //        int age = 21;
    //        double pi = 3.1415926535;
    //        float temprature = 36.5678f;
    //        decimal salary = 25000.75m;
    //        char grade = 'A';
    //        bool isPassed = true;
    //        Console.WriteLine("Age: {0}", age);
    //        Console.WriteLine("Pi (2 decimal places): {0:F2}", pi);
    //        Console.WriteLine("Temprature (3 decimal places): {0:F3}", temprature);
    //        Console.WriteLine("Grade: {0} ", grade);
    //        Console.WriteLine("Passed: {0} ", isPassed);

    //        Console.WriteLine("\nNumber with commas: {0:N}", 1000000);
    //        Console.WriteLine("Percentage example: {0:P}", 0.85);
    //        Console.WriteLine("{0:C}", 1234.5);
    //    }
    //}

    class Example5
    {
        public void Alignment()
        {
            Console.WriteLine("\n-------------- Example5 --------------\n");
            string name = "Ali";
            int age = 20;
            double marks = 85.5;
            Console.WriteLine("Without Alignment:");
            Console.WriteLine("{0} {1} {2}", name, age, marks);

            Console.WriteLine("\nRight Alignment:");
            Console.WriteLine("{0,10} {1,10} {2,10}", name, age, marks);

            Console.WriteLine("\nLeft Alignment:");
            Console.WriteLine("{0,-10} {1,-10} {2,-10}", name, age, marks);
        }
    }
}