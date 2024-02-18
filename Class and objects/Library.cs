using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_objects
{
    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(Book book) { 
            books.Remove(book);
        }

        public Book SearchByTitle(string title)
        {
            return books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }

        public void DisplayAvailableBooks()
        {
            Console.WriteLine("The available books: ");
            foreach (var book in books)
            {
                if (book.Availability)
                {
                    Console.WriteLine(book);
                }
            }
        }

        public void DisplayAllBooks()
        {
            Console.WriteLine("All books: ");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
