using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.DIP.Encoding
{
    public class MyNetworkReader : IReader
    {
        private string url;

        public MyNetworkReader(string url)
        {
            this.url = url;
        }

        public string Read()
        {
            StreamReader reader = new StreamReader(WebRequest.Create(url).GetResponse().GetResponseStream());
            string line;

            StringBuilder inputString = new StringBuilder();

            while ((line = reader.ReadLine()) != null)
            {
                inputString.Append(line);
            }

            reader.Close();
            return inputString.ToString();
        }
    }
}
