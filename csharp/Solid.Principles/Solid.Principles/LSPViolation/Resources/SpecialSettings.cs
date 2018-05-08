using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.LSPViolation.Resources
{
    public class SpecialSettings : IPersistedResource
    {
        public void Load()
        {
            // Load special settings
        }

        public void Persist()
        {
            // We do not need this method
            throw new NotImplementedException();
        }
    }
}
