﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.ISP.Door
{
    public class SensingDoor : IDoor, IProximity
    {
        private bool locked;
        private bool opened;

        public SensingDoor(Sensor sensor)
        {
            sensor.Register(this);
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

        public void ProximityCallback()
        {
            opened = true;
            Console.WriteLine("Sensing door opened because of person proximity.");
        }
    }
}
