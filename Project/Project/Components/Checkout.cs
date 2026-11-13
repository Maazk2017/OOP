using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Components
{
    internal class Order
    {
        private string OrderId { get; }
        private Cart cart;
        private string shippingAddress;
        private double tax { get; set; }
        private double shippingFee { get; set; }
        private double discount;

        public Order(Cart cart, string shippingAddress)
        {
            this.OrderId = Guid.NewGuid().ToString().Substring(0, 8);
            this.cart = cart;
            this.shippingAddress = shippingAddress;
            tax = 0;
            shippingFee = 0;
            discount = 0;
        }

        public double CalculateTotal()
        {
            if (cart.GetTotal() <= 0)
            {
                Console.WriteLine("Checkout failed: Your cart is empty!");
                return 0;
            } else
            {
                return (cart.GetTotal() + tax + shippingFee) - GetDiscount();
            }
        }

        public double GetDiscount()
        {
            double totalPrice = cart.GetTotal();

            if (totalPrice >= 20000)
            {
                discount = totalPrice * 0.3;
            }
            else if (totalPrice >= 10000)
            {
                discount = totalPrice * 0.2;
            }
            else
            {
                discount = 0;
            }

            return discount;
        }

        public void DisplayReceipt()
        {
            Console.WriteLine("\n=================================================");
            Console.WriteLine($"                RECEIPT (Order #{OrderId})       ");
            Console.WriteLine("=================================================");
            //Console.WriteLine($"Customer: {CustomerName}");
            Console.WriteLine($"Shipping To: {shippingAddress}");
            //Console.WriteLine($"Payment Status: {(IsPaid ? "PAID" : "PENDING")}");
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"TOTAL AMOUNT: {CalculateTotal():C}");
            Console.WriteLine("=================================================\n");
        }
    }
}
