using System;

namespace LAB04
{
    class Person
    {
        private string id;
        private string name;
        private int age;
        private string gender;
        private string occupation;

        public Person(string id, string name, int age, string gender, string occupation)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.occupation = occupation;
        }

        public void GetPerson()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Occupation: " + occupation);
        }
    }
}
