using Lab10.Assignment;
using System.Drawing;

namespace Lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            //Shape[] shapes =
            //{
            //    new Circle("Red", 5),
            //    new Rectangle("Blue", 4, 6),
            //    new Triangle("Green", 3, 8),
            //    new Square("Gray", 4)
            //};

            //foreach (Shape s in shapes)
            //{
            //    s.Draw();
            //    s.DisplayInfo();
            //    Console.WriteLine("---");
            //}


            // Task 2
            //Employee[] employees =
            //{
            //     new FullTimeEmployee(1, "Ali Hassan", "Engineering", 150000),
            //     new PartTimeEmployee(2, "Sara Khan", "Design", 800, 120),
            //     new FullTimeEmployee(3, "Ahmed Raza", "Marketing", 120000)
            //};

            //double total = 0;
            //foreach (Employee emp in employees)
            //{
            //    emp.PrintPayStub();
            //    total += emp.CalculateSalary();

            //    if (emp is IBonusEligible bonusEmp)
            //    {
            //        Console.WriteLine($"Bonus: PKR {bonusEmp.CalculateBonus():N0}");
            //    }
            //}

            //Console.WriteLine($"\n===========================");
            //Console.WriteLine($"TOTAL PAYROLL: PKR {total:N0}");

            // Assignment 10
            Student[] student =
            {
                new RegularStudent("cs1464", "Ali", 50000),
                new ScholarshipStudent("cs6432", "Sara", 50000, 50),
                new HostelStudent("cs4375", "Ahmed", 50000, 20000)
            };

            double totalFees = 0;

            foreach (Student s in student)
            {
                s.PrintDetails();
                totalFees += s.CalculateFee();
            }

            Console.WriteLine("\n==============================");
            Console.WriteLine($"Total Collected Fees: PKR {totalFees:N0}");

        }
    }
}
