using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.ISP.Worker
{
    public class Factory
    {
        private List<IWorker> workers;

        public Factory(List<IWorker> workers)
        {
            this.workers = workers;
        }

        public void Manage()
        {
            foreach (var worker in workers)
            {
                worker.Work();
            }
        }
    }
}
