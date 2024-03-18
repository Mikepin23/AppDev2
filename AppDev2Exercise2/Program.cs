using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AppDev2Exercise2
{
    internal class Program
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            // // For First Part
            //PaymentCard card = new PaymentCard(10);
            //Console.WriteLine(card);

            //card.EatLunch();
            //Console.WriteLine(card);

            //card.DrinkCoffee();
            //Console.WriteLine(card);

            //  // For Second Part
            //PaymentCard card = new PaymentCard(100);
            //Console.WriteLine(card);

            //card.AddMoney(49.99);
            //Console.WriteLine(card);

            //card.AddMoney(10000.0);
            //Console.WriteLine(card);

            //card.AddMoney(-10);
            //Console.WriteLine(card);

            // For Book Part
            List<Book> books = new List<Book>();
            string filePath = "C:/Users/mpins/Desktop/books.csv"; 

            while (true)
            {
                Console.Write("Name: ");
                string title = Console.ReadLine();
                if (string.IsNullOrEmpty(title))
                {
                    break;
                }

                Console.Write("Pages: ");
                int pages = int.Parse(Console.ReadLine());

                Console.Write("Publication year: ");
                int publicationYear = int.Parse(Console.ReadLine());

                books.Add(new Book(title, pages, publicationYear));
            }

            // Write the collected book information to a .csv file
            Book.WriteBooksToFile(books, filePath);

            books.Clear();
            books = Book.ReadBooksFromFile(filePath);

            Console.Write("What information will be printed? ");
            string whatToPrint = Console.ReadLine();

            foreach (var book in books)
            {
                book.Print(whatToPrint);
            }
        }
    }
}
