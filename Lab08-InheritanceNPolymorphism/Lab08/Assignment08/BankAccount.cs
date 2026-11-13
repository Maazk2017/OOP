using System;
namespace Lab08.Assignment08
{
    internal class BankAccount
    {

        protected double balance;
        protected int accNo;

        public BankAccount(string accNo, double bal)
        {
            accNo = accNo;
            balance = bal;
        }

        public virtual double CalculateInterest()
        {
            return 0;
        }
    }

    internal class SavingAccount : BankAccount
    {
        public SavingAccount(string accNo, double bal): base(accNo, bal)
        {

        }
        public override double CalculateInterest()
        {
            return balance * 0.08;
        }
    }

    internal class CurrentAccount : BankAccount
    {
        public CurrentAccount(string accNo, double bal): base(accNo, bal)
        {

        }
        public override double CalculateInterest()
        {
            double interest = base.CalculateInterest();
            return interest + (balance * 0.03);
        }
    }
}
