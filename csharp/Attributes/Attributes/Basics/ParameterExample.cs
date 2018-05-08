using System.Runtime.InteropServices;

namespace Attributes.Basics
{
    public class ParameterExample
    {
        void MethodA([In][Out] ref double x)
        {
        }

        void MethodB([Out][In] ref double x)
        {
        }

        void MethodC([In, Out] ref double x)
        {
        }
    }
}
