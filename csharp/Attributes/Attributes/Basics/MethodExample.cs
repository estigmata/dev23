using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Attributes.Basics
{
    public class MethodExample
    {
        [DllImport("user32.dll")]
        extern static void SampleMethod();

        [Conditional("DEBUG"), Conditional("TEST1")]
        void TraceMethod()
        {
        }
    }
}
