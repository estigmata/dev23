using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.ISP.Worker
{
    public class Program
    {
        public void Main()
        {
            var workers = new List<IWorker> { new Human(), new Robot(), new Human() };

            var factory = new Factory(workers);
            factory.Manage();

            var eaters = new List<IEater> { new Human(), new Human() };
            var messHall = new MessHall(eaters);
            messHall.Manage();
        }
    }
}
