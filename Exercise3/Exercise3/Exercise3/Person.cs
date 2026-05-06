using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise3
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;

        public Person(string firstName, string lastName, int age)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._age = age;
        }

        public string FirstName
        {
            get { return _firstName; }
        }

        public string LastName
        {
            get { return _lastName; }
        }

        public int Age
        {
            get { return _age; }
        }

        override public string ToString()
        {
            return $"{_firstName} {_lastName} is {_age} years old.";
        }
    }
}