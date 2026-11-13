using Lab08.Assignment08;

namespace Lab08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Billing b = new Billing();
            //Console.WriteLine("Single Product Bill: " + b.CalculateBill(100));
            //Console.WriteLine("Multiple Products Bill: " + b.CalculateBill(50, 3));
            //Console.WriteLine("Discounted Bill: " + b.CalculateBill(200, 2, 10));

            //Shape s1 = new Shape();
            //Shape s2 = new Circle();
            //Shape s3 = new Rectangle();

            //s1.Draw();
            //s2.Draw();
            //s3.Draw();


            //Calculator c = new Calculator();
            //Console.WriteLine("One double parameter" + " " + c.CalculateArea(4.0));
            //Console.WriteLine("Two double parameter" + " " + c.CalculateArea(2.0, 6.0));
            //Console.WriteLine("One int parameter" + " " + c.CalculateArea(2));


            List<BankAccount> accounts = new List<BankAccount>();

            accounts.Add(new BankAccount("4S23", 2000));
            accounts.Add(new SavingAccount("SA101", 5000));
            accounts.Add(new CurrentAccount("CA202", 5000));

            foreach (BankAccount acc in accounts)
            {
                Console.WriteLine($"Interest: {acc.CalculateInterest()}");
            }

        }
    }
}
