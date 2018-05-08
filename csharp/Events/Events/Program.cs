using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var publisher = new Publisher("Pub1");

            var subscriber1 = new Subscriber("Subs1", publisher);
            var subscriber2 = new Subscriber("Subs2", publisher);

            publisher.DoSomething();
        }
    }
}
