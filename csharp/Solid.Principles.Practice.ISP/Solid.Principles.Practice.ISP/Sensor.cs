using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.Practice.ISP
{
    public class Sensor
    {
        public void Register(IDoorProximity door)
        {
            while (true)
            {
                if (IsPersonClose())
                {
                    door.ProximityCallback();
                    break;
                }
            }
        }

        private bool IsPersonClose()
        {
            var isClose = new Random().Next(0, 2) != 0;
            return isClose;
        }
    }
}
