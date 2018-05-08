using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.ISPViolation.Worker
{
    public class Program
    {
        public void Main()
        {
            var workers = new List<IWorker> { new Human(), new Robot(), new Human() };

            var factory = new Factory(workers);
            factory.Manage();

            var messHall = new MessHall(workers);
            messHall.Manage();
        }
    }
}
