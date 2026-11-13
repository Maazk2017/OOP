using System;

namespace LAB04
{
    internal class Program
    {
        static void Main(String[] args)
        {

            Car c = new Car();
            c.EngineWorks();

            Person p = new Person("3245", "Lark", 20, "Male", "Money Launderer");
            p.GetPerson();



            string name;
            string city;
            sbyte age;
            int pin;
            string address;

            Console.WriteLine("Enter your name");
            name = Console.ReadLine();

            Console.WriteLine("Enter your city:");
            city = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            age = sbyte.Parse(Console.ReadLine());

            Console.WriteLine("Enter your pin:");
            pin = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter your address:");
            address = Console.ReadLine();

            Console.WriteLine("Name:" +  name + " city:" + city + " age:" + age + " pin:" + pin + " address:" + address);

        }
    }
}