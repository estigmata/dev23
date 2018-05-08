﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.LSP.Resources
{
    public class UserSettings : ILoadResource, IPersistResource
    {
        public void Load()
        {
            // Load user settings
        }

        public void Persist()
        {
            // Save user settings
        }
    }
}
