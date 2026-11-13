using System;

namespace Lab10
{

    interface IReportable
    {
        string GenerateReport();
    }

    interface IBonusEligible
    {
        double CalculateBonus();
    }

    abstract class Employee : IReportable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; }

        public Employee(int id, string name, string dept)
        {
            Id = id; Name = name; Department = dept;
        }

        public abstract double CalculateSalary();
        public abstract string GenerateReport();

        public void PrintPayStub()
        {
            Console.WriteLine($"\n=== Pay Stub ===");
            Console.WriteLine($"ID: {Id} | Name: {Name} | Dept: {Department}");
            Console.WriteLine($"Salary: PKR {CalculateSalary():N0}");
            Console.WriteLine(GenerateReport());
        }

    }

    class FullTimeEmployee : Employee, IBonusEligible
    {
        public double MonthlySalary { get; }

        public FullTimeEmployee(int id, string name, string dept, double salary) : base(id, name, dept)
        {
            MonthlySalary = salary;
        }

        public override double CalculateSalary() => MonthlySalary;

        public double CalculateBonus()
        {
            return MonthlySalary * 0.1;
        }

        public override string GenerateReport() => $"Type: Full-Time | Monthly Salary: PKR {MonthlySalary: NO}";
    }

    class PartTimeEmployee : Employee
    {
        public double HourlyRate { get; }
        public int HoursWorked { get; }

        public PartTimeEmployee(int id, string name, string dept, double rate, int hours) : base(id, name, dept)
        {
            HourlyRate = rate; HoursWorked = hours;
        }

        public override double CalculateSalary() => HourlyRate * HoursWorked;

        public override string GenerateReport() => $"Type: Part-Time | {HoursWorked} hrs @ PKR {HourlyRate}/hr";
    }

}
