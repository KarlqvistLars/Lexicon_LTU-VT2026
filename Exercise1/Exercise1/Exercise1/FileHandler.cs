using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal static class FileHandler
    {
        internal static bool AddPerson(List<Employee> list)
        {
            Console.WriteLine("Enter name:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter birth year:");
            var born = Console.ReadLine();
            Console.WriteLine("Enter hourly rate:");
            var hourlyRate = Console.ReadLine();

            Employee person = new Employee(name, born, hourlyRate);

            if (person == null)
            {
                return false;
            }
            list.Add(person);
            return true;
        }

        internal static void ShowPeople(List<Employee> list)
        {
            foreach (var person in list)
            {
                Console.WriteLine($"Name: {person.Name}, Born: {person.Born}, Hourly Rate: {person.HourlyRate}");
            }

        }

    }
}
