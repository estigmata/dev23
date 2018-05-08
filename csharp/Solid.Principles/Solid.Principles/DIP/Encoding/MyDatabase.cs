using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.DIP.Encoding
{
    public class MyDatabase
    {
        private static Dictionary<int, string> data = new Dictionary<int, string>();
        private static int count = 0;

        public int Write(string inputString)
        {
            data.Add(++count, inputString);
            return count;
        }
    }
}
