using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            var encodingClient = new DIPViolation.Encoding.EncodingModuleClient();
            encodingClient.Main();

            var encodingClient2 = new DIP.Encoding.EncodingModuleClient();
            encodingClient2.Main();

            Console.ReadKey();
        }
    }
}
