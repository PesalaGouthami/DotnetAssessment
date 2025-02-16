using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAss1
{
    internal class Book
    {
        public string BookCode { get; set; }
        public string BookName { get; set; }
        public string PublisherName { get; set; }
        public string AuthorName { get; set; }
        public double price { get; set; }

        public static List<Book> Books()
        {
            return new List<Book>()
            {
                new Book{BookCode ="ASPNA",BookName= "ASP.Net Professional", PublisherName="Wrox",AuthorName= "Bill Evjen,Matt Gibbs",price= 750.00 },
                new Book{BookCode ="ASPNB",BookName= "Beginning ASP.Net", PublisherName="techmedia",AuthorName= "dan wahlin,dave reed",price= 545.00 },
                new Book{BookCode ="LINQA",BookName= "learning linq", PublisherName="apress",AuthorName= "steve eichert",price= 400.00 },
                new Book{BookCode ="CSPN",BookName= "c# developers guide", PublisherName="tata mcgraw",AuthorName= "dan maharry",price= 675.00 },
            };
        }

    }
}
