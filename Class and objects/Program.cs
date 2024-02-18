using Class_and_objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddBook(new Book("The Hunger Games", "Suzanne Collins", "Scenice Fiction", true));
            library.AddBook(new Book("The Lord of the Rings", "J. R. R. Tolkien", "Fantasy", false));
            library.AddBook(new Book("Ranger's Apprentice", "John Flanagan", "Fantasy", true));
            library.AddBook(new Book("The Little Prince", "Antoine de Saint-Exupéry","Novella", false ));

            library.DisplayAvailableBooks();
            Console.ReadKey();

            Console.WriteLine("Enter the title you want to search for: ");
            string searchTitle = Console.ReadLine();

            Console.WriteLine("\nSearching by title - result: ");
            Book searchResult = library.SearchByTitle(searchTitle);
            if (searchResult != null)
            {
                Console.WriteLine($"The book {searchResult.Title} was found");
            }
            else
            {
                Console.WriteLine("Book not found");
            }
            Console.ReadKey();

        }
    }
}
           