using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles.SRPViolation.Person
{
    class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Format(string formatType)
        {
            switch (formatType)
            {
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
