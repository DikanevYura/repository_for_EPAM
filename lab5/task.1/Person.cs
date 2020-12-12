using System;
using System.Collections.Generic;
using System.Text;

namespace task._1
{
    struct Person
    {
        private string _firstname, _lastname;
        private byte _age;

        public Person(string firstname, string lastname, byte age)
        {
            _firstname = firstname;
            _lastname = lastname;
            _age = age;
        }

        public string IsOlderThan(byte n)
        {
            if (_age > n)
            {
                return $"{_firstname} {_lastname} is older than {n}.";
            }
            if (_age < n)
            {
                return $"{_firstname} {_lastname} is younger than {n}.";
            }
            return $"{_firstname} {_lastname} is exactly {n} years old.";
        }
    }
}