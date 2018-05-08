using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Attributes.Tests
{
    [TestClass]
    public class TestAuthorAttribute
    {
        [TestMethod]
        public void TestMethod1()
        {
            PrintAuthorInfo(typeof(Custom.FirstClass));
            PrintAuthorInfo(typeof(Custom.SecondClass));
            PrintAuthorInfo(typeof(Custom.ThirdClass));
        }

        private void PrintAuthorInfo(System.Type t)
        {
            Console.WriteLine($"Author information for {t}");

            // Using reflection.  
            Attribute[] attrs = Attribute.GetCustomAttributes(t);  // Reflection.  

            foreach (Attribute attr in attrs)
            {
                if (attr is Custom.AuthorAttribute)
                {
                    Custom.AuthorAttribute a = (Custom.AuthorAttribute)attr;
                    Console.WriteLine($"   {a.GetName()}, version {a.version}");
                }
            }
        }
    }
}
