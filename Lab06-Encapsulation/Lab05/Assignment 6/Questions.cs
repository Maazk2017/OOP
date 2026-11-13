using System;

namespace Lab05.Assignment_6
{
    internal class Questions
    {
        private double _balance;
        private string _pin;

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public string Pin
        {
            get { return _pin; }
            set { _pin = value; }
        }

        public int Area(int side)
        {
            return side*side;
        }

        public int Area(int length, int breadth)
        {
            return length*breadth;
        }

        public void WithDraw(double amount, string enteredPin)
        {
            if (enteredPin != _pin)
            {
                Console.WriteLine("Invalid PIN.");
            } else
            {
                if (amount > 0 && amount <= _balance)
                {
                    _balance -= amount;
                    Console.WriteLine($"Withdrawal successful. New balance: {_balance}");
                } else
                {
                    Console.WriteLine("Not enough balance");
                }
            }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"Deposit successful. New balance: {_balance}");
            }
        }

    }
}
