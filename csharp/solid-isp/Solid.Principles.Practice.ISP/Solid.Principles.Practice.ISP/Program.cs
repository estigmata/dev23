using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.Practice.ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            var sensor = new Sensor();
            var sensingDoor = new SensingDoor(sensor);

            var myTimer = new MyTimer();
            var timedDoor = new TimedDoor(myTimer);

            Console.ReadLine();
        }
    }
}
