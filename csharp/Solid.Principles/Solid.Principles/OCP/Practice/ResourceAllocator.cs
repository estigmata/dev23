using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.OCP.Practice
{
    public class ResourceAllocator
    {
        public int Allocate(IResource resource)
        {
            int resourceId = resource.FindFree();
            resource.MarkBusy(resourceId);
            return resourceId;
        }

        public void Free(IResource resource, int resourceId)
        {
            resource.MarkFree(resourceId);
        }
    }
}
