using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.ISP.Door
{
    public class TimedDoor : IDoor, ITimeout
    {
        private static readonly int TIME_OUT = 5000;
        private bool locked;
        private bool opened;

        public TimedDoor(MyTimer timer)
        {
            timer.Register(TIME_OUT, this);
        }

        public void Lock()
        {
            locked = true;
        }

        public void Unlock()
        {
            locked = false;
        }

        public void Open()
        {
            if (!locked)
            {
                opened = true;
            }
        }

        public void Close()
        {
            opened = false;
        }

        public void TimeOutCallback()
        {
            locked = true;
            Console.WriteLine("Timed door locked because of timeout.");
        }
    }
}
