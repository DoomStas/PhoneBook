using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class PhoneBook
    {
        private Contact[] _contacts;
        private int _count;


        public PhoneBook(int size)
        {
            _contacts = new Contact[size];
            _count = 0;
        }

        

        public string this[string name]
        {
            get
            {
                for (int i = 0; i < _count; i++)
                {
                    if (_contacts[i].Name == name)
                    {
                        return _contacts[i].PhoneNumber;
                    }
                }

                return "Not Found";
            }
            set
            {
                // if the name exists, update the phone number
                for (int i = 0; i < _count; i++)
                {
                    if (_contacts[i].Name == name)
                    {
                        _contacts[i].PhoneNumber = value;
                        return;
                    }
                }

                // if the name does not exist, add a new entry
                if (_count < _contacts.Length)
                {
                    _contacts[_count] = new Contact(name, value);
                    _count++;
                }
                else
                {
                    throw new InvalidOperationException("Phone book is full.");
                }
            }
        }

        public string this[int index]
        {
            get { return $"Name: {_contacts[index].Name}, Phone Number: {_contacts[index].PhoneNumber}"; }
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public string[] ShowAllEntries()
        {
            string[] dictionary = new string[_count];

            for (int i = 0; i < _count; i++)
            {
                dictionary[i] = $"Name: {_contacts[i].Name}, Phone Number: {_contacts[i].PhoneNumber}";
            }

            return dictionary;
        }
    }
}