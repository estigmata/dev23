using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.OCP.Practice
{
    public class SpaceResource : IResource
    {
        public int FindFree()
        {
            return 0;
        }

        public void MarkBusy(int resourceId)
        {
        }

        public void MarkFree(int resourceId)
        {
        }
    }
}
