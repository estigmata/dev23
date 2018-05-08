using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.DIPViolation.Encoding
{
    public class EncodingModuleClient
    {
        public void Main()
        {
            EncodingModule encodingModule = new EncodingModule();
            encodingModule.EncodeWithFiles();
            encodingModule.EncodeBasedOnNetworkAndDatabase();
        }
    }
}
