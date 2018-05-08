using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.SRP.Book
{
    class HtmlPrinter : IPrinter
    {
        public void PrintPage(string content)
        {
            Console.WriteLine("<div style=\"single-page\">" + content + "</div>");
        }
    }
}
