using System;

namespace Lab07.Task
{
    class Person
    {
        private string email;
        private string pass;

        public string Email
        {
            get {  return email; } 
            set { email = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public Person(string email, string pass)
        {
            Console.WriteLine("Person Parameterized Constructor");
            this.email = email;
            this.pass = pass;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("=========== Displaying Info ===========");
            Console.WriteLine("Email = " + email);
            Console.WriteLine("Password = " + pass);
        }
    }

    class Faculty : Person
    {
        public Faculty(string email, string pass) : base(email, pass)
        {
            Console.WriteLine("Calling Faculty Constructor");
        }

        public void AddExam()
        {
            Console.WriteLine("=== Faculty: Add Exam ===");
        }

        public void AddGrade()
        {
            Console.WriteLine("=== Faculty: Assign Grade ===");
        }

        public override void ShowInfo()
        {
            Console.WriteLine("=== Faculty Info ===");
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Password: " + Pass);
        }
    }

    class Student : Person
    {
        public Student(string email, string pass) : base(email, pass)
        {
            Console.WriteLine("Calling Student Constructor");
        }

        public void AttemptExam()
        {
            Console.WriteLine("=== Student: Attempting Exam ===");
        }
        public void ViewGrade()
        {
            Console.WriteLine("=== Student: Viewing Grade ===");
        }

        public override void ShowInfo()
        {
            Console.WriteLine("=== Student Info ===");
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Password: " + Pass);
        }
    }
}
