using System;

namespace Lab08
{
    internal class Billing
    {
        public double CalculateBill(double price)
        {
            return price;
        }
        public double CalculateBill(double price, int quantity)
        {
            return quantity * price;
        }
        public double CalculateBill(double price, int quantity, double discount)
        {
            double total = price * quantity;
            return total - (total * discount / 100);
        }
    }
}
