using System.Security.Cryptography;

namespace LINQAss1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Book Code Value");
            var bookcode=Console.ReadLine();
            var listBooks = Book.Books();
            var result=from book in listBooks
                       where book.BookCode==bookcode.ToUpper()
                       select book;
            foreach (var book in result) {
                Console.WriteLine($"{book.BookCode}\t{book.BookName}\t{book.PublisherName}\t{book.AuthorName}\t{book.price}");
            }
            Console.WriteLine("===============");
            var result2=from book in listBooks
                        where book.price>500 && book.price<700
                        select book;
            foreach (var book in result2)
            {
                Console.WriteLine($"{book.BookCode}\t{book.BookName}\t{book.PublisherName}\t{book.AuthorName}\t{book.price}");
            }
        }
    }
}
