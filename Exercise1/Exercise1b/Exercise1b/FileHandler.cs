using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Controls;

namespace Exercise1b
{
    internal static class FileHandler
    {
        /// <summary>
        /// Method to add a person to the list, it will ask the user for the name, birth year and hourly rate of the person and then create a new Employee object and add it to the list.
        /// </summary>
        /// <param name="list">The list of employees to which the new person will be added.</param>
        /// <returns>Returns true if the person was successfully added, otherwise false.</returns>
        internal static bool AddPerson(List<Employee> list,Employee newPerson)
        {
            try
            {
                Employee person = new Employee(newPerson.Name, newPerson.Born.ToString(), newPerson.HourlyRate);
                if (person == null)
                {
                    return false;
                }
                list.Add(person);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Somthing went wrong, try again!\n" + ex);
            }
            return true;
        }
        /// <summary>
        /// Method to list people in the list, it will iterate through the list of employees and print their name, birth year and hourly rate to the console.
        /// </summary>
        /// <param name="list">The list of employees to be displayed.</param>
        /// <param name="employeeListBox">The ListBox control where the employees will be displayed.</param>
        internal static void ShowPeople(List<Employee> list, ListBox employeeListBox)
        {
            foreach (var person in list)
            {
                Console.WriteLine($" Name: {person.Name},\n Born: {person.Born},\n Hourly Rate: {person.HourlyRate}\n");

            }

            employeeListBox.Items.Clear();
            foreach (Employee person in list)
            {
                employeeListBox.Items.Add($"{person.Name}\t{person.Born}\t{person.HourlyRate}");
            }
        }
        /// <summary>
        /// Method to save people to a file, it will create a new file if it doesn't exist and then write the name, birth year and hourly rate of each employee in the list to the file in a specific format.
        /// </summary>
        /// <param name="list">The list of employees to be saved.</param>
        /// <param name="filePath">The file path where the employees will be saved.</param>
        internal static void SavePeople(List<Employee> list, string filePath)
        {
            if(!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
            StringBuilder sb = new StringBuilder();
            foreach (var person in list)
            {
                sb.AppendLine($"Name:{person.Name},Born:{person.Born},HourlyRate:{person.HourlyRate}");
            }
            File.WriteAllText(filePath, sb.ToString());
        }
        /// <summary>
        /// Method to load people from a file, it will read the file line by line and split the line into parts to extract the name, birth year and hourly rate of each employee and then create a new Employee object and add it to a list which is returned at the end.
        /// </summary>
        /// <param name="filePath">The file path from which the employees will be loaded.</param>
        /// <returns>A list of employees loaded from the file.</returns>
        public static List<Employee> LoadPeople( string filePath)
        {
            List<Employee> liststring = new List<Employee>();

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            var lines = File.ReadAllLines(filePath);
            liststring.Clear();

            foreach (var line in lines)
            {
                var parts = line.Split(',');
                var name = parts[0].Split(':')[1];
                var born = parts[1].Split(':')[1];
                var hourlyRate = parts[2].Split(':')[1];
                Employee person = new Employee(name, born, hourlyRate);
                liststring.Add(person);
            }
            
        return liststring;
        }
    }
}
