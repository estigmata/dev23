using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.ISP.Worker
{
    public class MessHall
    {
        private List<IEater> eaters;

        public MessHall(List<IEater> eaters)
        {
            this.eaters = eaters;
        }

        public void Manage()
        {
            foreach (var eater in eaters)
            {
                eater.Eat();
            }
        }
    }
}
