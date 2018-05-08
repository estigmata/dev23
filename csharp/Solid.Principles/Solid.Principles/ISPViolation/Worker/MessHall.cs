using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.ISPViolation.Worker
{
    public class MessHall
    {
        private List<IWorker> workers;

        public MessHall(List<IWorker> workers)
        {
            this.workers = workers;
        }

        public void Manage()
        {
            foreach (var worker in workers)
            {
                worker.Eat();
            }
        }
    }
}
