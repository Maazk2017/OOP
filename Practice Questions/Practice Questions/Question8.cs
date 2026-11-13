using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Questions
{
    internal class Question8
    {
    }

    internal abstract class Animal
    {
        public string Name { get; set;  }
        public int age { get; set; }

        public abstract void Speak();

        public void DisplayInfo()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Age: {age}");
        }
    }

    internal class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Meow Meow....");
        }
    }


    internal class Parrot : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Mettho Mettho....");
        }
    }

    //static void Main()
    //{
    //    // Creating Cat object
    //    Animal cat = new Cat();
    //    cat.Name = "Kitty";
    //    cat.Age = 3;

    //    cat.DisplayInfo();
    //    cat.Speak();

    //    Console.WriteLine();

    //    // Creating Parrot object
    //    Animal parrot = new Parrot();
    //    parrot.Name = "Rio";
    //    parrot.Age = 2;

    //    parrot.DisplayInfo();
    //    parrot.Speak();
    //}

    }
