using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.LSP.Shapes
{
    public class Square
    {
        public int Side { get; set; }

        public int GetArea()
        {
            return Side * Side;
        }
    }
}
