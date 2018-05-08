using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.LSP.Resources
{
    public class ApplicationSettings : ILoadResource, IPersistResource
    {
        public void Load()
        {
            // Load app settings
        }

        public void Persist()
        {
            // Save app settings
        }
    }
}
