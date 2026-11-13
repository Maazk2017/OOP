using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Questions
{
    // Question 7
    internal class Library
    {
        // composition
        public List<Book> books { get; set; }

        public Library ()
        {
            books = new List<Book>();
        }
    }

    internal class Book
    {
        // Association
        public string Title { get; set; }

        public Book(string title)
        {
            Title = title;
        }
    }

    internal class Member
    {
        public string Name { get; set; }
        public List<Book> BorrowedBooks { get; set; } = new List<Book>();

        public void BorrowBook(Book book)
        {
            BorrowedBooks.Add(book);
        }

        public void PayFine(int overdueDays)
        {
            FineCalculator calculator = new FineCalculator(); // temporary object
            double fine = calculator.Fee(overdueDays);

            Console.WriteLine($"Fine to pay: {fine}");
        }
    }

    internal class FineCalculator
    {
        // dependency
        public double Fee(int overdue)
        {
            return overdue * 2;
        }
    }
}
