using System;

namespace MidTermPracticeQuestions
{
    internal class BankAccount6
    {
        private double balance;
        private string accountNumber;
        protected double interestRate;

        public BankAccount6(double balance, String accountNumber, double interestRate)
        {
            this.balance = balance;
            this.accountNumber = accountNumber;
            this.interestRate = interestRate;
        }

        public virtual double calculateInterest()
        {
            return balance * interestRate;
        }

        protected double getBalance()
        {
            return balance;
        }

        protected void setBalance(double balance)
        {
            this.balance = balance;
        }

    }

    internal class savingAccount : BankAccount6
    {

        public savingAccount(double balance, string accountNumber, double interestRate) : base(balance, accountNumber, interestRate)
        {

        }

        public  override double calculateInterest()
        {
            return  getBalance() * interestRate * 1.1;
        }

        public void applyMonthlyInterest()
        {
            double interest = getBalance() * interestRate / 12;
            setBalance(getBalance() + interest);
        }
    } 
}
