using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise3
{
    public class Person
    {
        string firstName;
        string lastName;
        int age;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        override public string ToString()
        {
            return $"{firstName} {lastName} ({age})";
        }
    }
}