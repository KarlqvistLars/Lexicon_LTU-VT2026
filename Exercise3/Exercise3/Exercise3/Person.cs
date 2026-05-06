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
        private decimal _salary;

        public Person(string firstName, string lastName, int age)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }

        public Person(string firstName, string lastName, int age, decimal salary)
            : this(firstName, lastName, age)
        {
            _salary = salary;
        }


        internal string FirstName
        {
            get { return _firstName; }
        }

        internal string LastName
        {
            get { return _lastName; }
        }

        internal int Age
        {
            get { return _age; }
        }

        internal decimal Salary
        {
            get { return _salary; }
        }

        //override public string ToString()
        //{
        //    return $"{_firstName} {_lastName} is {_age} years old.";
        //}

        override public string ToString()
        {
            return $"{_firstName} {_lastName} receives {_salary:F2} dollars.";
        }
        
        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age>30)
            {
                _salary += _salary * percentage / 100;
            }
            else
            {
                _salary += _salary * percentage / 200;
            }
        }
    }
}