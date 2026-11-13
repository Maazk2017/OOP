using System;

namespace MidTermPracticeQuestions
{
    internal class Employee8
    {
        protected string name;
        protected int id;
        protected double basicSalary;

        public void GetData()
        {
            Console.Write("Enter ID: ");
            id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Basic Salary: ");
            basicSalary = double.Parse(Console.ReadLine());
        }

        public virtual double CalculateSalary()
        {
            return basicSalary;
        }

        public virtual void Display()
        {
            Console.WriteLine($"ID: {id}, Name: {name}, Basic Salary: {basicSalary}");
        }

    }

    class Teacher : Employee8
    {
        private double allowance;

        public void GetTeacherData()
        {
            GetData();
            Console.Write("Enter Allowance: ");
            allowance = double.Parse(Console.ReadLine());
        }

        public override double CalculateSalary()
        {
            return basicSalary + allowance;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Allowance: {allowance}");
            Console.WriteLine($"Total Salary: {CalculateSalary()}");
        }
    }

    class AdminStaff : Employee8
    {
        private double bonus;

        public void GetAdminData()
        {
            GetData();
            Console.Write("Enter Bonus: ");
            bonus = double.Parse(Console.ReadLine());
        }

        public override double CalculateSalary()
        {
            return basicSalary + bonus;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Bonus: {bonus}");
            Console.WriteLine($"Total Salary: {CalculateSalary()}");
        }
    }



}
