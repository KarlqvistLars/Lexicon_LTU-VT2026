using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Windows.Controls;

namespace Exercise1b.Core
{
    /// <summary>
    /// En klass som hanterar filoperationer för att spara och ladda anställda, samt att lägga till och ta bort anställda från en lista. 
    /// Den innehåller metoder för att lägga till en person, ta bort en person, spara personer till en fil och ladda personer från en fil. 
    /// Den har också en metod för att visa informationen om den valda personen i textfälten.
    /// </summary>
    public static class FileHandler
    {
        /// <summary>
        /// Metod för att lägga till en person, den tar in en lista av anställda och tre textfält som innehåller namn, födelseår och timlön.
        /// </summary>
        /// <param name="employees"></param>Lista på anställda som den nya personen kommer att läggas till i.
        /// <param name="TextBoxNamn"></param>Textfält som innehåller namnet på personen.
        /// <param name="TextBoxFData"></param>Textfält som innehåller födelseåret på personen.
        /// <param name="TextBoxHourlyRate"></param>Textfält som innehåller timlönen på personen.
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
        /// <summary>
        /// Metod för att ta bort en person, den tar in en lista av anställda, 
        /// en ListView som visar listan av anställda och tre textfält som innehåller namn, födelseår och timlön.
        /// </summary>
        /// <param name="employees"></param>Lista på anställda som den valda personen kommer att tas bort från.
        /// <param name="employeeListBox"></param>ListView som visar listan av anställda.
        /// <param name="TextBoxNamn"></param>Textfält som innehåller namnet på personen.
        /// <param name="TextBoxFData"></param>Textfält som innehåller födelseåret på personen.
        /// <param name="TextBoxHourlyRate"></param>Textfält som innehåller timlönen på personen.
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
        /// Metod för att spara personer till en fil, den tar in en lista av anställda och en filväg där anställda kommer att sparas.
        /// </summary>
        /// <param name="list">Lista på anställda som ska sparas.</param>
        /// <param name="filePath">Filväg där anställda kommer att sparas.</param>
        /// <returns>Inget värde returneras.</returns>
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
        /// Metod för att läsa in personer från en fil, den läser filen rad för rad och delar upp raden i delar för att extrahera namn, 
        /// födelseår och timlön för varje anställd och sedan skapa ett nytt Employee-objekt och lägga till det i en lista som returneras i slutet.
        /// </summary>
        /// <param name="filePath">Filväg från vilken anställda kommer att läsas.</param>
        /// <returns>En lista med anställda som lästs från filen.</returns>
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
        /// <summary>
        /// Befolkar textfälten med informationen om den valda personen i ListView, 
        /// den tar in en ListView som visar listan av anställda och tre textfält som innehåller namn, födelseår och timlön.
        /// </summary>
        /// <param name="employeeListBox">ListView som visar listan av anställda.</param>
        /// <param name="TextBoxNamn">TextBox som visar namnet på den valda personen.</param>
        /// <param name="TextBoxFData">TextBox som visar födelseåret på den valda personen.</param>
        /// <param name="TextBoxHourlyRate">TextBox som visar timlönen på den valda personen.</param>
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
