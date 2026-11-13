using System;

namespace Lab09
{
    internal class Association
    {
        //Association represents a “has-a” relationship in which two independent objects are connected
        //to each other.Both objects can exist independently of one another.No ownership implied.It is
        //commonly represented using fields/properties, object references, or method parameters.
    }

    internal class Student
    {
        public string Name;
        public Student(string name)
        {
            Name = name;
        }
    }

    internal class Teacher
    {
        public string Name;
        private Student student;

        public Teacher(string name, Student student)
        {
            Name = name;
            this.student = student;
        }

        public void Teach()
        {
            Console.WriteLine(Name + " teaches " + student.Name);

        }
    }

}
