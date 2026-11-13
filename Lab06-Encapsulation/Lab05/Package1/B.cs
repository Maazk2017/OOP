using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05.Package1
{
    internal class B
    {
        public int n1;
        internal int n2;
        private int n3;

        public void Show()
        {
            Console.WriteLine($" {n1}, {n2}, {n3} ");
        }
    }
}
