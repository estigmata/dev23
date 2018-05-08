using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.DIP.Button
{
    public class Button
    {
        private IEquipment equipment;
        private bool state;

        public Button(IEquipment equipment)
        {
            this.equipment = equipment;
        }

        public void Toogle()
        {
            state = !state;
            var buttonOn = state;

            if (buttonOn)
            {
                equipment.TurnOn();
            }
            else
            {
                equipment.TurnOff();
            }
        }
    }
}
