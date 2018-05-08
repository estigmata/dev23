using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.DIP.Button
{
    public class Lamp : IEquipment
    {
        public void TurnOn()
        {
            Console.WriteLine("Lamp turned on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Lamp turned on");
        }

        public int Color { get; set; }
    }
}
