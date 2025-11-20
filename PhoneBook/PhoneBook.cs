using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class PhoneBook
    {
        private string[] _name;
        private string[] _phoneNumber;
        private int _count;


        public PhoneBook(int size)
        {
            _name = new string[size];
            _phoneNumber = new string[size];
            _count = 0;
        }

        public string this[string name]
        {
            get
            {
                for (int i = 0; i < _count; i++)
                {
                    if (_name[i] == name)
                    {
                        return _phoneNumber[i];
                    }
                }

                return "Not Found";
            }
            set
            {
                // if the name exists, update the phone number
                for (int i = 0; i < _count; i++)
                {
                    if (_name[i] == name)
                    {
                        _phoneNumber[i] = value;
                        return;
                    }
                }

                // if the name does not exist, add a new entry
                if (_count < _name.Length)
                {
                    _name[_count] = name;
                    _phoneNumber[_count] = value;
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
            get { return $"Name: {_name[index]}, Phone Number: {_phoneNumber[index]}"; }
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
                dictionary[i] = $"Name: {_name[i]}, Phone Number: {_phoneNumber[i]}";
            }

            return dictionary;
        }
    }
}