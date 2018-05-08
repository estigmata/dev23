using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.LSPViolation.Resources
{
    public class UserSettings : IPersistedResource
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
