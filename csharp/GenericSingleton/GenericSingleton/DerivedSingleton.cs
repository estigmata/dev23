using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSingleton
{
    public class DerivedSingleton : SingletonBase<DerivedSingleton>
    {
        private DerivedSingleton() : base()
        {
        }

        public int MyProperty { get; set; }
    }
}
