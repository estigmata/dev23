using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.DIPViolation.Encoding
{
    public class EncodingModule
    {
        public void EncodeWithFiles()
        {
            StreamReader reader = null;
            StreamWriter writer = null;

            try
            {
                reader = new StreamReader("DIPViolation\\Encoding\\beforeEncryption.txt");
                writer = new StreamWriter("DIPViolation\\Encoding\\afterEncryption.txt");
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string encodedLine = Base64Encode(line);
                    writer.WriteLine(encodedLine);
                }
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }

                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        public void EncodeBasedOnNetworkAndDatabase()
        {
            StreamReader reader = new StreamReader(WebRequest.Create("http://humanstxt.org/humans.txt").GetResponse().GetResponseStream());
            string line;

            MyDatabase database = new MyDatabase();

            while ((line = reader.ReadLine()) != null)
            {
                string encodedLine = Base64Encode(line);
                database.Write(encodedLine);
            }
        }

        private string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
