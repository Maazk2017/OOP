using System;


namespace LAB04
{
    class Car
    {
        private int model;
        private string manufacturer;
        private int fuel;
        private int distance;

        public Car()
        {
            Console.WriteLine("Car Created");
        }

        public void EngineWorks()
        {
            Console.WriteLine("Engine works.");
        }

    }
}
