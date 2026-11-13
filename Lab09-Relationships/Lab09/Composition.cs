using System;

namespace Lab09
{
    internal class Composition
    {
        //omposition is a strong form of aggregation representing a strong “part-of” relationship.Child
        //objects cannot exist without the parent object.

    }

    internal class Engine
    {
        public void Start()
        {
            Console.WriteLine("Engine started...");
        }
    }

    internal class Car
    {
        // The Car HAS AN Engine
        private Engine engine;

        public Car()
        {
            // Composition: Car creates its own engine (object created inside car)
            engine = new Engine();
        }

        public void Drive()
        {
            engine.Start();
            Console.WriteLine("Car is moving.");
        }
    }
}
