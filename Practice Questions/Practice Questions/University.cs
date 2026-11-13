using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Questions
{
    // Question 6
    public interface IEvaluatable
    {
        void GetGrade();
    }
    public abstract class Person
    {
        public string Name { get; set; }
        public int age {  get; set; }
    }
    internal class University
    {
        
    }

    internal class Student : Person, IEvaluatable
    {
        public void GetGrade()
        {
            Console.WriteLine("Grade");
        }
    }

    internal class Teacher : Person
    {
        public string subject {  get; set; }

        public void Teach()
        {
            Console.WriteLine("Teaching");
        }

    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Create Student
    //        Student student = new Student
    //        {
    //            Name = "Ali",
    //            Age = 20
    //        };

    //        // Create Teacher
    //        Teacher teacher = new Teacher
    //        {
    //            Name = "Ahmed",
    //            Age = 40,
    //            Subject = "Computer Science"
    //        };

    //        // Display Student Information
    //        Console.WriteLine("Student Information");
    //        Console.WriteLine($"Name: {student.Name}");
    //        Console.WriteLine($"Age: {student.Age}");
    //        student.GetGrade();

    //        Console.WriteLine();

    //        // Display Teacher Information
    //        Console.WriteLine("Teacher Information");
    //        Console.WriteLine($"Name: {teacher.Name}");
    //        Console.WriteLine($"Age: {teacher.Age}");
    //        Console.WriteLine($"Subject: {teacher.Subject}");
    //        teacher.Teach();
    //    }
    //}

}
