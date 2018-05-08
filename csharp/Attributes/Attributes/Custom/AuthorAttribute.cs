using System;

namespace Attributes.Custom
{
    [AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct, AllowMultiple = true)]
    public class AuthorAttribute : Attribute
    {
        private string name;

        public double version;

        public AuthorAttribute(string name)
        {
            this.name = name;
            version = 1.0;
        }

        public string GetName()
        {
            return name;
        }
    }
}
