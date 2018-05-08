using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Subscriber
    {
        public Subscriber(string name, Publisher publisher)
        {
            Name = name;
            publisher.MyEvent += Publisher_MyEvent;
        }

        private void Publisher_MyEvent(object sender, CustomEventArgs e)
        {
            Console.WriteLine("Subscriber {0} received event [{1}] ", Name, e.Message);
        }

        public string Name { get; set; }
    }
}
