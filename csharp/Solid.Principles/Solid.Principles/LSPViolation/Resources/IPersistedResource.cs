using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.LSPViolation.Resources
{
    public interface IPersistedResource
    {
        void Load();
        void Persist();
    }
}
