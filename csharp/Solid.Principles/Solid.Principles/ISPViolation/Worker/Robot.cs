using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.ISPViolation.Worker
{
    public class Robot : IWorker
    {
        public string Eat()
        {
            throw new Exception("Robot can't eat");
        }

        public string Work()
        {
            return "Robot works";
        }
    }
}
