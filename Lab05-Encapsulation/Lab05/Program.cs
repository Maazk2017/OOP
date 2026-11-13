using System;

namespace Lab05
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Student s = new Student();
            s.Name = "Maaz";
            s.Age = 19;
            s.Cgpa = 3.5;

            Console.WriteLine("Name: {0}", s.Name);
            Console.WriteLine("Age: {0}", s.Age);
            Console.WriteLine("CGPA: {0}", s.Cgpa);
        }
    }

}

