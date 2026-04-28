using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Employee
    {
        // name, age, city
        public int Born { get; set; }
        public string Name { get; set; }
        public string HourlyRate { get; set; }

        public Employee(string name, string born, string? hourlyRate)
        {
            Born = int.Parse(born);
            Name = name;
            HourlyRate = hourlyRate;
        }
    }
}
