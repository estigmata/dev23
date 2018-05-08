using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.SRP.Person
{
    class PersonFormatter
    {
        public string Format(Person person, string formatType)
        {
            switch (formatType)
            {
                // We need to use "person" object in the different format types
                case "JSON":
                    return "jsonFormattedString";
                case "FirstAndLastName":
                    return "firstAndLastNameString";
                default:
                    return "defaultFormattedString";
            }
        }
    }
}
