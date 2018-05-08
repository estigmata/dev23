using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Solid.Principles.ISP.Door
{
    public class MyTimer
    {
        public void Register(long timeOut, ITimeout door)
        {
            var delayTimer = new Timer(timeOut);
            delayTimer.Enabled = true;
            delayTimer.Elapsed += (sender, e) => MyElapsedMethod(sender, e, door);
            delayTimer.Start();
        }

        private void MyElapsedMethod(object sender, System.Timers.ElapsedEventArgs e, ITimeout door)
        {
            var delayTimer = (Timer)sender;
            delayTimer.Stop();
            door.TimeOutCallback();
        }
    }
}
