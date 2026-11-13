using System;

namespace MidTermPracticeQuestions
{
    internal class Person5
    {
        private string name;
        private int age;
        protected string nationality;

        public Person5(string name, int age, string nationality)
        {
            this.name = name;
            this.age = age;
            this.nationality = nationality;
        }

        public void DisplayBasicInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

    }

    internal class Student : Person5
    {
        private string rollNo;
        private double gpa;

        public Student(string name, int age, string nationality, string rollNo, double gpa)
            : base(name, age, nationality)
        {
            this.rollNo = rollNo;
            this.gpa = gpa;
        }

        public void DisplayStudentProfile()
        {
            // Call method from base class
            base.DisplayBasicInfo();

            // Use the protected 'nationality' directly
            Console.WriteLine($"Nationality: {nationality}");

            // Student-specific data
            Console.WriteLine($"Roll No: {rollNo}");
            Console.WriteLine($"GPA: {gpa}");
        }
    }
}
