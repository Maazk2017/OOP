using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Components
{
    internal class Cart
    {
        private List<CartItem> items = new List<CartItem>();

        public void AddItem(Product p, int q) 
        {
            foreach (CartItem i in items) 
            {
                if (i.product.ProductId == p.ProductId)
                {
                    i.quantity += q;
                    return;
                } 
            }

            items.Add(new CartItem(p, q));
        }

     
        public void RemoveItem(string productId)
        {
            bool removeFlag = false;
            foreach (CartItem i in items)
            {
                if (i.product.ProductId == productId)
                {
                    items.Remove(i);
                    removeFlag = true;
                    break;
                }
                
            }

            if (removeFlag == false)
            {
                Console.WriteLine("Item not found!");
            }
        }



        public void UpdateQuantity(string productId, int quantity)
        {
            bool updateFlag = false;
            foreach (CartItem i in items)
            {
                if (i.product.ProductId == productId)
                {
                    if (quantity <= 0)
                    {
                        items.Remove(i);
                    }
                    else
                    {
                        i.quantity = quantity;
                        updateFlag = true;
                        break;
                    }
                }
            } 

            if (updateFlag == false)
            {
                Console.WriteLine("Item not found");
            }
     
        }

        public double GetTotal()
        {
            double total = 0;
            foreach (CartItem item in items)
            {
                total += item.TotalPrice();
            }
            return total;
        }



        public void RemoveItem(CartItem c)
        {
            if (items.Contains(c))
            {
                items.Remove(c);
            } else
            {
                Console.WriteLine("Cart Item does not exists");
            }
            
        }

        public void UpdateQuantity(CartItem c)
        {
            Console.WriteLine("Enter the update quantity: ");
            int updateQuantity = Convert.ToInt32(Console.ReadLine());
            c.quantity = updateQuantity;
        }

    }

    internal class CartItem
    {
        public Product product { get; set; }
        public int quantity { get; set; }

        public CartItem(Product p, int q)
        {
            this.product = p;
            this.quantity = q;
        }

        public double TotalPrice()
        {
            return quantity * product.Price;
        }
    }
}
