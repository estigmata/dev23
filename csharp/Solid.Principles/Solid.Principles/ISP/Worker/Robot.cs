using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.ISP.Worker
{
    public class Robot : IWorker
    {
        public string Work()
        {
            return "Robot works";
        }
    }
}
