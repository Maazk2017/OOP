using System;

namespace MidTermPracticeQuestions
{
    internal class Animal1
    {
        private string name;
        private int age;
        protected string sound;

        public string getName ()
        {
             return name;
        }

        public virtual void makeSound()
        {
            Console.WriteLine("Sound");
        }
    }

    internal class Dog : Animal1 
    {
        private string breed;
        public bool fetch;

        public void bark()
        {
            Console.WriteLine("Bark");
        }

        public override void makeSound()
        {
            Console.WriteLine("Sound");
        }

        public void display()
        {
            Console.WriteLine($"Breed: {breed}");
            Console.WriteLine($"Fetch: {fetch}");
        }
    }
}
