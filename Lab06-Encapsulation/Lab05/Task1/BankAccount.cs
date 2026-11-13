using System;

namespace Lab05.Task1
{
    internal class BankAccount
    {
        private double _balance;

        public double Balance
        {
            get { return _balance; }
            set { if (value >= 0)
                {
                    _balance = value;
                } else
                {
                    Console.WriteLine("Balance can't be negative");
                }

            }
        }

        public void SetBalance( double amount)
        {
            if (amount >= 0)
            {
                _balance = amount;
            } else
            {
                Console.WriteLine("Balance can't be negative");
            }
            
        }

        public double GetBalance()
        {
            return _balance;
        }
    }
}
