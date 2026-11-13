using System;

class Employee
{
    private string name;
    private double salary;

    //public Employee()
    //{
    //    name = "Ali";
    //    salary = 120000;
    //    Console.WriteLine("Default Constructor");
    //}

    //public Employee(string n, int s)
    //{
    //    name = n;
    //    salary = s;
    //    Console.WriteLine("Parameterized Constructor");
    //}

    //public Employee(Employee other)
    //{
    //    name = other.name;
    //    salary = other.salary;
    //    Console.WriteLine("Copy Constructor");
    //}

    private Employee(string msg)
    {
        Console.WriteLine("Private Constructor:" + msg);
    }

    public Employee()
    {
        Console.WriteLine("Static Constructor");
    }
}
