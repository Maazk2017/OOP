using System;


namespace Lab09
{
    internal class Dependency
    {
        //Dependency is a “uses-a” relationship in which one class temporarily relies on another class to
        //perform a specific task.Any changes in the used class may affect the dependent class. This
        //relationship is commonly implemented through method parameters, local variables, or method
        //calls.
    }

    internal class Printer
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }
    }

    internal class Customer
    {
        public void PrintReceipt(Printer p)
        {
            p.Print();
        }
    }
}
