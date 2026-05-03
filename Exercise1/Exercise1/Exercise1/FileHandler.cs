using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Exercise1
{
    public static class FileHandler
    {
        /// <summary>
        /// Metod för att lägga till en person i listan, den kommer att fråga användaren om namn, 
        /// födelseår och timlön för personen och sedan skapa ett nytt Employee-objekt och lägga till det i listan.
        /// </summary>
        /// <param name="list">Listan över anställda till vilken den nya personen kommer att läggas till.</param>
        /// <returns>Returnerar true om personen lades till framgångsrikt, annars false.</returns>
        public static bool AddPerson(List<Employee> list)
        {
            try
            {
                Console.Write("Enter name: ");
                var name = Console.ReadLine();
                Console.Write("Enter birth year: ");
                var born = Console.ReadLine();
                Console.Write("Enter hourly rate: ");
                var hourlyRate = Console.ReadLine();

                Employee person = new Employee(name, born, hourlyRate);

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
        /// Metod för att lista personer i listan, den kommer att iterera genom listan över anställda och skriva ut deras namn, födelseår och timlön till konsolen.
        /// </summary>
        /// <param name="list">Listan över anställda som ska visas.</param>
        public static void ShowPeople(List<Employee> list)
        {
            foreach (var person in list)
            {
                Console.WriteLine($" Name: {person.Name},\n Born: {person.Born},\n Hourly Rate: {person.HourlyRate}\n");
            }

        }
        /// <summary>
        /// Metod för att spara personer till en fil, den kommer att skapa en ny fil om den inte finns och sedan skriva namn, 
        /// födelseår och timlön för varje anställd i listan till filen i ett specifikt format.
        /// </summary>
        /// <param name="list">Listan över anställda som ska sparas.</param>
        /// <param name="filePath">Sökvägen till filen där de anställda ska sparas.</param>
        public static void SavePeople(List<Employee> list, string filePath)
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
        /// Metod för att ladda personer från en fil, den kommer att läsa filen rad för rad och dela upp raden i delar för att extrahera namn, 
        /// födelseår och timlön för varje anställd och sedan skapa ett nytt Employee-objekt och lägga till det i en lista som returneras i slutet.
        /// </summary>
        /// <param name="filePath">Sökvägen till filen från vilken de anställda kommer att laddas.</param>
        /// <returns>En lista över anställda som laddats från filen.</returns>
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
