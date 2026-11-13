using System;

namespace Lab07.Assignment07
{
    class Vehicle
    {
        private string manufacturer;
        private string model;
        private string manufacturingYear;

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string ManufacturingYear
        {
            get { return manufacturingYear; }
            set { manufacturingYear = value; }
        }

        public Vehicle(string manufacturer, string model, string manufacturingYear)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.manufacturingYear = manufacturingYear;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Manufacturer: {manufacturer}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"ManufacturingYear: {manufacturingYear}");
        }
    }

    class Sedan : Vehicle
    {
        private int numberOfDoors;

        public int NumberOfDoors
        {
            get { return numberOfDoors; }
            set { numberOfDoors = value; }
        }

        public Sedan(string manufacturer, string model, string manufacturingYear, int numberOfDoors) : base(manufacturer, model, manufacturingYear)
        {
            this.numberOfDoors = numberOfDoors;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"NumberOfDoors: {numberOfDoors}");
        }
    }

    class CargoTruck : Vehicle
    {
        private int cargoCapacity;

        public int CargoCapacity
        {
            get { return cargoCapacity; }
            set { cargoCapacity = value; }
        }

        public CargoTruck(string manufacturer, string model, string manufacturingYear, int cargoCapacity) : base(manufacturer, model, manufacturingYear)
        {
            this.cargoCapacity = cargoCapacity;
        }        

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"CargoCapacity: {cargoCapacity}");
        }

    }
}
