using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDev2Exercise2
{
    public class Book
    {
        public string Title { get; }
        public int Pages { get; }
        public int PublicationYear { get; }

        public Book(string title, int pages, int publicationYear)
        {
            Title = title;
            Pages = pages;
            PublicationYear = publicationYear;
        }

        public void Print(string whatToPrint)
        {
            if (whatToPrint == "everything")
            {
                Console.WriteLine($"{Title}, {Pages} pages, {PublicationYear}");
            }
            else if (whatToPrint == "title")
            {
                Console.WriteLine(Title);
            }
        }

        public static void WriteBooksToFile(List<Book> books, string filePath)
        {
            using (var writer = new StreamWriter(filePath, false))
            {
                foreach (var book in books)
                {
                    writer.WriteLine($"{book.Title},{book.Pages},{book.PublicationYear}");
                }
            }
        }

        public static List<Book> ReadBooksFromFile(string filePath)
        {
            var books = new List<Book>();
            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        books.Add(new Book(parts[0], int.Parse(parts[1]), int.Parse(parts[2])));
                    }
                }
            }
            return books;
        }
    }
}