using System;
namespace Lab09
{
    internal class Aggregation
    {
        //Aggregation is a special form of association representing a weak “has-a” relationship.One
        //object contains another object, but both can exist independentl
    }

    internal class Book
    {
        public string Title;
        public Book(string title)
        {
            Title = title;
        }
    }

    internal class Library
    {
        public string Name;
        public List<Book> Books; // aggregation

        public Library(string name, List<Book> books)
        {
            Name = name;
            Books = books;
        }

        public void ShowBooks()
        {
            Console.WriteLine("Library: " + Name);
            Console.WriteLine("Books available:");
            // Each item being pulled from books is a Book object
            foreach (Book book in Books)
            {
                Console.WriteLine("- " + book.Title);
            }
        }
    }
}
