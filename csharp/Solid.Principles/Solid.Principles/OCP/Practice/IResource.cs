﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.OCP.Practice
{
    public interface IResource
    {
        int FindFree();

        void MarkBusy(int resourceId);

        void MarkFree(int resourceId);
    }
}
