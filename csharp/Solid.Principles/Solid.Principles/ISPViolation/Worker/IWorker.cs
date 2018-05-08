using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.ISPViolation.Worker
{
    public interface IWorker
    {
        string Eat();

        string Work();
    }
}
