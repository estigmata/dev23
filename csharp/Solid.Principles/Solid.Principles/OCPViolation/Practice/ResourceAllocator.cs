using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.OCPViolation.Practice
{
    class ResourceAllocator
    {
        private static readonly int INVALID_RESOURCE_ID = -1;

        public int Allocate(ResourceType resourceType)
        {
            int resourceId;

            switch (resourceType)
            {
                case ResourceType.TIME_SLOT:
                    resourceId = findFreeTimeSlot();
                    markTimeSlotBusy(resourceId);
                    break;
                case ResourceType.SPACE_SLOT:
                    resourceId = findFreeSpaceSlot();
                    markSpaceSlotBusy(resourceId);
                    break;
                default:
                    Console.WriteLine("ERROR: Attempted to allocate invalid resource");
                    resourceId = INVALID_RESOURCE_ID;
                    break;
            }
            return resourceId;
        }

        public void Free(ResourceType resourceType, int resourceId)
        {
            switch (resourceType)
            {
                case ResourceType.TIME_SLOT:
                    markTimeSlotFree(resourceId);
                    break;
                case ResourceType.SPACE_SLOT:
                    markSpaceSlotFree(resourceId);
                    break;
                default:
                    Console.WriteLine("ERROR: attempted to free invalid resource");
                    break;
            }
        }

        private void markSpaceSlotFree(int resourceId)
        {
        }

        private void markTimeSlotFree(int resourceId)
        {
        }

        private void markSpaceSlotBusy(int resourceId)
        {
        }

        private int findFreeSpaceSlot()
        {
            return 0;
        }

        private void markTimeSlotBusy(int resourceId)
        {
        }

        private int findFreeTimeSlot()
        {
            return 0;
        }
    }
}
