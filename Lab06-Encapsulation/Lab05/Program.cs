using System;
// Alias
using us = Lab05.University;
using ucs = Lab05.University.CS;
using Lab05.Task1;

namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // //Lab05.University.Students s = new Lab05.University.Students();
            //us.Students s1 = new us.Students();
            //s1.Show();
            //ucs.Students s2 = new ucs.Students();
            //s2.Show();

            // Methods
            //MyMethod();
            StaticMethod();
            // cant use non static method without making object
            Program p = new Program();
            p.NonStaticMethod();
            MyMethod("Maaz");
            PrintMax(6, 4);
            Method3();
            Console.WriteLine(Method4(3));
            Method5(child3: "Ali", child1: "Bilal", child2: "Taha");

            // Task 1
            Console.WriteLine();
            BankAccount ba = new BankAccount();
            ba.Balance = 2000;
            Console.WriteLine(ba.Balance);

            // Task 2
            Console.WriteLine();
            Console.WriteLine(Square(2));
            Console.WriteLine(p.Cube(3));

            // Assignment Question 1
            Lab05.Assignment_6.Questions a = new Lab05.Assignment_6.Questions();
            Console.WriteLine();
            Console.WriteLine(a.Area(2));
            Console.WriteLine(a.Area(2, 4));

            Console.WriteLine();
            a.Balance = 12000.3;
            a.Pin = "pass123";
            a.WithDraw(100, "pass123");
            a.Deposit(200);


        }

        // create a method
        static void MyMethod()
        {
            Console.WriteLine("MyMethod Executed");
        }

        // Static method
        static void StaticMethod()
        {
            Console.WriteLine("Static Method");
        }

        // non static method
        void NonStaticMethod()
        {
            Console.WriteLine("NonStatic Method");
        }

        // Parameters and Arguments
        static void MyMethod(string fname)
        {
            Console.WriteLine($"Your name is {fname}");
        }

        static void PrintMax(float num1, float num2)
        {
            float max = num1;
            if (num1 < num2)
            {
                max = num2;
            }
            Console.WriteLine($"Maximum number is {max}");
        }

        // Default parameter
        static void Method3(string country = "Pakistan")
        {
            Console.WriteLine(country);
        }

        // Return value
        static int Method4(int x)
        {
            return x;
        }

        // Named Arguments
        static void Method5(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }

        // Task 2
        static int Square(int num)
        {
            return num * num;
        }

        int Cube(int num)
        {
            return num * num * num;
        }



    }
}
