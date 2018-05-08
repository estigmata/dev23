using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.DIP.Encoding
{
    public class MyDatabaseWriter : IWriter
    {
        public void Write(string input)
        {
            MyDatabase database = new MyDatabase();
            database.Write(input);
        }
    }
}
