using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.DIP.Encoding
{
    public class EncodingModuleClient
    {
        public void Main()
        {
            var encodingModule = new EncodingModule();

            IReader reader = new MyFileReader("DIP\\Encoding\\beforeEncryption.txt");
            IWriter writer = new MyFileWriter("DIP\\Encoding\\afterEncryption.txt");
            encodingModule.Encode(reader, writer);

            reader = new MyNetworkReader("http://humanstxt.org/humans.txt");
            writer = new MyDatabaseWriter();
            encodingModule.Encode(reader, writer);
        }
    }
}
