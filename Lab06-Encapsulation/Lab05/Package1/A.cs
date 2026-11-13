using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05.Package1
{
    internal class A
    {
        public int x;
        internal int y;
        private int z;

        // Private field with property
        public int Z
        {
            get { return z; }
            set { z = value; } 
        }

        // Private field with setter getter
        public void SetZ(int i)
        {
            z = i;
        }

        public int GetZ()
        {
            return z;
        }

        public void Show()
        {
            Console.WriteLine($" {x}, {y}, {z} ");
        }
    }
}
