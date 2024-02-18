using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_objects
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public bool Availability { get; set; }


        public Book(string title, string author, string genre, bool availability)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Availability = availability;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, Genre: {Genre}, Available: {(Availability ? "Yes" : "No")}";
        }
    }
}
