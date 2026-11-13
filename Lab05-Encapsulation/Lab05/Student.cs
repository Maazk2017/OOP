using System;


namespace Lab05
{

    class Student
    {
        private string name;
        private int age;
        private double cgpa;

        public string Name 
        {
            get { return name;}
            set { name = value;}
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public double Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }

    }
}
