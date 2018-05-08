using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.SRPViolation.Book
{
    class Book
    {
        public string GetTitle()
        {
            return "A Book";
        }

        public string GetAuthor()
        {
            return "John Doe";
        }

        public string GetContent()
        {
            return "The content of the book...";
        }

        public void PrintCurrentPage()
        {
            Console.WriteLine("Current page content");
        }
    }
}
