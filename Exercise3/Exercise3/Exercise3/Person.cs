using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise3
{
    public class Person
    {
        private string? _firstName;
        private string? _lastName;
        private int _age;
        private decimal _salary;
        private bool _err;

        public Person(string firstName, string lastName, int age)
        {
            ErrFlag = false;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public Person(string firstName, string lastName, int age, decimal salary)
            : this(firstName, lastName, age)
        {
            Salary = salary;
        }

        internal bool ErrFlag
        {
            get { return _err; }
            set { _err = value; }
        }


        internal string? FirstName
        {
            get { return _firstName; }
            set
            {
                if(value == null || value.Length < 3){
                    Console.WriteLine("First name cannot be less than 3 symbols");
                    ErrFlag = true;
                }else{
                    _firstName = value;
                }
            }
        }

        internal string? LastName
        {
            get { return _lastName; }
            set
            {
                if (value == null || value
                    .Length < 3)
                {
                    Console.WriteLine("Last name cannot be less than 3 symbols");
                    ErrFlag = true;
                }
                else
                {
                    _lastName = value;
                }
            }
        }

        internal int Age
        {
            get { return _age; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Age cannot be zero or a negative integer");
                    ErrFlag = true;
                }
                else
                {
                    _age = value;
                }   
            }
        }

        internal decimal Salary
        {
            get { return _salary; }
            set
            {
                if (value < 460)
                {
                    Console.WriteLine("Salary cannot be less than 460 dollars");
                    ErrFlag = true;
                }
                else
                {
                    _salary = value;
                }
            }
        }

        override public string ToString()
        {
            if (this._salary == 0)
            {
                return $"{_firstName} {_lastName} is {_age} years old.";
            } else
            {
                return $"{_firstName} {_lastName} receives {_salary:F2} dollars.";
            }
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