using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes.Basics
{
    public class TargetsExample
    {
        // default: applies to method  
        [SomeAttr]
        int Method1()
        {
            return 0;
        }

        // applies to method  
        [method: SomeAttr]
        int Method2()
        {
            return 0;
        }

        // applies to return value  
        [return: SomeAttr]
        int Method3()
        {
            return 0;
        }
    }

    public class SomeAttrAttribute : Attribute
    {
    }
}
