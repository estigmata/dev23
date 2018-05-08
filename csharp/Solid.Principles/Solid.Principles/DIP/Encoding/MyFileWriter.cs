using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.DIP.Encoding
{
    public class MyFileWriter : IWriter
    {
        private string fileName;

        public MyFileWriter(string fileName)
        {
            this.fileName = fileName;
        }

        public void Write(string encodedText)
        {
            StreamWriter writer = new StreamWriter(fileName);
            writer.Write(encodedText);
            writer.Close();
        }
    }
}
