using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.DIPViolation.Button
{
    public class Button
    {
        private Lamp lamp;
        private bool state;

        public Button(Lamp lamp)
        {
            this.lamp = lamp;
        }

        public void Toogle()
        {
            state = !state;
            var buttonOn = state;

            if (buttonOn)
            {
                this.lamp.TurnOn();
            }
            else
            {
                this.lamp.TurnOff();
            }
        }
    }
}
