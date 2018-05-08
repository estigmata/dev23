using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.DIP.Encoding
{
    public class MyFileReader : IReader
    {
        private string fileName;

        public MyFileReader(string fileName)
        {
            this.fileName = fileName;
        }

        public string Read()
        {
            var lines = new StringBuilder();
            var reader = new StreamReader(fileName);

            string line;

            while ((line = reader.ReadLine()) != null)
            {
                lines.Append(line);
            }

            reader.Close();
            return lines.ToString();
        }
    }
}
