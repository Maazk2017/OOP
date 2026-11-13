namespace Lab09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Dependency
            //Printer p = new Printer();
            //Customer c = new Customer();

            //c.PrintReceipt(p);

            // 2.Association
            //Student s1 = new Student("Ali");
            //Teacher t1 = new Teacher("Dr. Ahmed", s1);
            //t1.Teach();

            // 3.Aggregation
            //Books created independently
            //Book b1 = new Book("Data Structures");
            //Book b2 = new Book("OOP in C#");
            //Book b3 = new Book("Database Systems");
            //List<Book> bookList = new List<Book> { b1, b2, b3 };
            //// Library uses existing books (aggregation)
            //Library lib = new Library("City Library", bookList);
            //lib.ShowBooks();

            // 4.Composition
            //// Creating object of Car
            //Car myCar = new Car();
            //// Calling method
            //myCar.Drive();

            // 5.Generalization
            //Circle c = new Circle();
            //c.Draw();
            //c.CircleArea();
            //Console.WriteLine();


            // Array List
            Shopping shop = new Shopping();
            shop.AddItem("Milk");
            shop.AddItem("Bread");
            shop.AddItem("Eggs");
            shop.ShowItems();

        }
    }
}