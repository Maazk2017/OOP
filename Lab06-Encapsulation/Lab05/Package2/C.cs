using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05.Package2
{
    internal class C
    {
        public int cV1;
        internal int cV2;
        private int cV3;

        public void Show()
        {
            Console.WriteLine($" {cV1}, {cV2}, {cV3} ");
        }
    }
}
