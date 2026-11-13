using System;

class Car2
{
    private int model;
    private string manufacturer;
    private int fuel;
    private int distance;

    // 1. Default Constructor
    //public Car2()
    //{
    //    model = 5471;
    //    manufacturer = "Toyota";
    //    fuel = 0;
    //    distance = 0;
    //    Console.WriteLine("Default Constructor called");
    //}

    //2. Parameterized Constructor
    //public Car2(int m, string manu, int f, int d)
    //{
    //    model = m;
    //    manufacturer = manu;
    //    fuel = f;
    //    distance = d;
    //    Console.WriteLine("Parameterized Constructor called");
    //}

    // 3. Copy Constructor
    //public Car2(Car2 other)
    //{
    //    model = other.model;
    //    manufacturer = other.manufacturer;
    //    fuel = other.fuel;
    //    distance = other.distance;
    //    Console.WriteLine("Copy Constructor called");
    //}

    // 4. Private Constructor
    //private Car2(string secret)
    //{
    //    Console.WriteLine("Private Constructor called: " + secret);
    //}

    // 5. Static Constructor
    static Car2()
    {
        Console.WriteLine("Static Constructor called");
    }

    public void EngineWork()
    {
        Console.WriteLine("Engine is running");
    }

    public void SetFuelValue(int value)
    {
        fuel = value;
    }

    public int GetModel()
    {
        return model;
    }
}
