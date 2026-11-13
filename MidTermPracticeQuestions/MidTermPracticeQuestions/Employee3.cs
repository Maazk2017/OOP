using System;

namespace MidTermPracticeQuestions
{
    internal class Employee3
    {
        private int empID;
        private double salary;
        public string department;

        public Employee3(int id, double salary, string dept)
        {
            this.empID = id;
            this.salary = salary;
            this.department = dept;
        }

        public virtual void getDetails()
        {
            Console.WriteLine($"ID: {empID}");
            Console.WriteLine($"Department: {department}");
        }

        public double getSalary()
        {
            return salary;
        }

    }

    internal class Manager : Employee3
    {
        private int teamSize;
        public double bonus;

        public Manager(int id, double salary, string dept, int teamSize, double bonus)
            : base(id, salary, dept)
        {
            this.teamSize = teamSize;
            this.bonus = bonus;
        }

        public override void getDetails()
        {
            base.getDetails();
            Console.WriteLine($"Team Size: {teamSize}");
            Console.WriteLine($"Bonus: {bonus}");
        }

        public void assignTask()
        {
            Console.WriteLine("Task has been assigned to the team.");
        }

        public void promote()
        {
            Console.WriteLine("Employee has been promoted.");
        }
    }
}
