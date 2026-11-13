using System;
using System.Collections.Generic;
using System.Text;

namespace MidTermPracticeQuestions
{
    internal class Vehicle4
    {
        protected string fuelType;
        protected int speed;

        public Vehicle4(string fuelType, int speed)
        {
            this.fuelType = fuelType;
            this.speed = speed;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Fuel Type: {fuelType}, Speed: {speed} km/h");
        }

    }

    internal class Car : Vehicle4
    {

        public Car(string fuelType, int speed, int doors, string brand)
            : base(fuelType, speed)
        {
            this.doors = doors;
            this.brand = brand;
        }

        public int doors;
        public string brand;
        public override void Display()
        {
            Console.WriteLine($"Brand: {brand}, Doors: {doors}");
            base.Display();
        }
    }

    internal class ElectricCar : Car
    {
        public double batteryCapacity; 
        public int chargeLevel;

        public ElectricCar(int speed, int doors, string brand, double batteryCapacity, int chargeLevel)
            : base("Electric", speed, doors, brand)
        {
            this.batteryCapacity = batteryCapacity;
            this.chargeLevel = chargeLevel;
        }
        public override void Display()
        {
            // Demonstrating direct access to protected member from 2 levels up
            Console.WriteLine($"--- {brand} Electric Vehicle Status ---");
            Console.WriteLine($"Power Source: {fuelType}");
            Console.WriteLine($"Battery: {chargeLevel}% of {batteryCapacity}kWh");
            Console.WriteLine($"Current Speed: {speed} km/h");
        }
    }


}
