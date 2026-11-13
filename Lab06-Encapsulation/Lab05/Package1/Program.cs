using System;

// Giving reference
using Lab05.Package2;

namespace Lab05.Package1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // same namespace
            A a = new A();
            B b = new B();

            a.x = 1;
            a.y = 2;
            b.n2 = 3;
            b.n1 = 4;

            a.Z = 3;
            a.SetZ(3);
            Console.WriteLine(a.GetZ());
            a.Show();

            b.Show();

            // seperate namespace
            // can get objects of C without referencing
            C c = new C();
            c.cV2 = 5;
            c.cV1 = 6;
        }

    }
}
