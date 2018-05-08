using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void MyDelegate(object sender, CustomEventArgs e);

    public class Publisher
    {
        public event MyDelegate MyEvent;

        public Publisher(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void DoSomething()
        {
            OnRaiseEvent(new CustomEventArgs(string.Format("Publisher {0} did something", Name)));
        }

        protected virtual void OnRaiseEvent(CustomEventArgs e)
        {
            MyDelegate del = MyEvent;
            if (del != null)
            {
                MyEvent(this, e);
            }
        }
    }
}
