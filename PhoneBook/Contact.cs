using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PhoneBook
{
    public struct Contact
    {
        public string Name;
        public string PhoneNumber;

    public Contact(string name, string phoneNumber)
    {
        Name = name;
        PhoneNumber = phoneNumber;
    }
    public override string ToString()
    {
        return $"Name: {Name}, Phone Number: {PhoneNumber}";
    }
}
}
