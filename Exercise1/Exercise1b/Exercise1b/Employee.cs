using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1b
{
    internal class Employee
    {
        /// <summary>
        /// The Employee class represents an employee with a name, birth year and hourly rate. 
        /// It has a constructor that takes in the name, birth year and hourly rate as parameters and assigns them to the corresponding properties. 
        /// The birth year is parsed from a string to an integer, and if there is an error during parsing, 
        /// it will catch the exception and print an error message to the console.
        /// </summary>
        public int Born { get; set; }
        public string Name { get; set; }
        public string HourlyRate { get; set; }

        public Employee(string name, string born, string hourlyRate)
        {
            try
            {
                Born = int.Parse(born);
                Name = name;
                HourlyRate = hourlyRate;
            }
            catch (Exception)
            {
                Console.WriteLine("Somthing went wrong, try again!\n");
            }
        }
    }
}
