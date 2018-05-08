using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.ISP.Door
{
    public interface IDoor
    {
        void Lock();

        void Unlock();

        void Open();

        void Close();
    }
}
