using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab09
{
    internal class arrayList
    {
    }

    internal class Shopping
    {
        private ArrayList items = new ArrayList();

        public void AddItem(string item)
        {
            items.Add(item);
        }

        public void ShowItems()
        {
            Console.WriteLine("Shopping Items:");
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
