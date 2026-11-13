using System;

namespace Lab09.Assignment09
{
    internal class CustomerBank
    {
        //Relationship Type: Association
        /* 
            The bank does not own the customer.

            The customer can:

            change banks,
            use multiple banks.
            
         */
    }

    internal class Customer
    {
        public string Name;

        public Customer(string name)
        {
            Name = name;
        }
    }

    internal class Bank
    {
        public string BankName;

        public Bank(string name)
        {
            BankName = name;
        }

        public void ServerCustomer(Customer c)
        {
            Console.WriteLine($"{BankName} serves {c.Name}");
        }
    }
}
