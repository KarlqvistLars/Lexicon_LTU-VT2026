using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Windows.Controls;

namespace Exercise1b.Core
{
    public static class FileHandler
    {
        /// <summary>
        /// Method to add a person to the list, it will ask the user for the name, birth year and hourly rate of the person and then create a new Employee object and add it to the list.
        /// </summary>
        /// <param name="list">The list of employees to which the new person will be added.</param>
        /// <returns>Returns true if the person was successfully added, otherwise false.</returns>
        public static bool AddPerson(ObservableCollection<Employee> employees, TextBox TextBoxNamn, TextBox TextBoxFData, TextBox TextBoxHourlyRate)
        {
            try
            {
                Employee newPerson = new Employee(TextBoxNamn.Text, TextBoxFData.Text, TextBoxHourlyRate.Text);
                if (TextBoxNamn.Text != "" && TextBoxFData.Text != "" && TextBoxHourlyRate.Text != "")
                {
                    if (newPerson == null)
                    {
                        return false;
                    }
                    employees.Add(newPerson);
                    TextBoxNamn.Text = "";
                    TextBoxFData.Text = "";
                    TextBoxHourlyRate.Text = "";
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Somthing went wrong, try again!\n" + ex);
                return false;
            }
            return true;
        }

        public static void RemovePerson(ObservableCollection<Employee> employees, ListView employeeListBox, TextBox TextBoxNamn, TextBox TextBoxFData, TextBox TextBoxHourlyRate)
        {
            if (employeeListBox.SelectedItem != null)
            {
                var selectedEmployee = employeeListBox.SelectedItem as Employee;
                employees.Remove(selectedEmployee);
                TextBoxNamn.Text = "";
                TextBoxFData.Text ="";
                TextBoxHourlyRate.Text = "";
            }
        }
        /// <summary>
        /// Method to save people to a file, it will create a new file if it doesn't exist and then write the name, birth year and hourly rate of each employee in the list to the file in a specific format.
        /// </summary>
        /// <param name="list">The list of employees to be saved.</param>
        /// <param name="filePath">The file path where the employees will be saved.</param>
        public static void SavePeople(ObservableCollection<Employee> list, string filePath)
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
        public static ObservableCollection<Employee> LoadPeople(string filePath)
        {
            ObservableCollection<Employee> employees = new();
            if (!File.Exists(filePath)) { return employees; }
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) { continue; }
                var parts = line.Split(',');
                if (parts.Length < 3) { continue; }
                var name = parts[0].Split(':')[1].Trim();
                var born = parts[1].Split(':')[1].Trim();
                var hourlyRate = parts[2].Split(':')[1].Trim();
                Employee person = new Employee(name, born, hourlyRate);
                employees.Add(person);
            }
            return employees;
        }

        public static void SelectPerson(ListView employeeListBox, TextBox TextBoxNamn, TextBox TextBoxFData, TextBox TextBoxHourlyRate)
        {
            if (employeeListBox.SelectedItem != null)
            {
                var selectedEmployee = employeeListBox.SelectedItem as Employee;
                TextBoxNamn.Text = selectedEmployee?.Name;
                TextBoxFData.Text = selectedEmployee?.Born.ToString();
                TextBoxHourlyRate.Text = selectedEmployee?.HourlyRate.ToString();
            }
        }
    }
}
