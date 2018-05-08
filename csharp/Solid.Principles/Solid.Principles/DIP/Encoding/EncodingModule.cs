using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.DIP.Encoding
{
    public class EncodingModule
    {
        public void Encode(IReader reader, IWriter writer)
        {
            string text = reader.Read();
            string encodedText = Base64Encode(text);
            writer.Write(encodedText);
        }

        private string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
