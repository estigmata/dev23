﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.ISP.Worker
{
    public class Human : IWorker, IEater
    {
        public string Eat()
        {
            return "Human eats";
        }

        public string Work()
        {
            return "Human works";
        }
    }
}
