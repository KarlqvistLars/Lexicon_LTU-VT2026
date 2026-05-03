using System;
using System.Collections.Generic;
using System.IO;

namespace Exercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Detta är startpunkten för konsolapplikationen. Den initierar listan över anställda,
            /// laddar befintliga anställda från en fil om den finns, och tillhandahåller en meny
            /// för användaren att lägga till, visa, spara eller avsluta programmet.
            /// </summary>
            List<Employee> list = new List<Employee>();
            // Bestäm installationsvägen för filen "dbfile.txt" baserat på var programmet körs
            string installationPath = Environment.GetCommandLineArgs()[0].Replace("Exercise1.dll", "")+"dbfile.txt";
            // Om filen finns och inte är tom, ladda anställda från filen
            if (File.Exists(installationPath)&& new FileInfo(installationPath).Length > 0) {
                list = FileHandler.LoadPeople(installationPath);
            }
            // Huvudmeny loop
            do
            {
                Console.WriteLine(GetMenu());
                var input = Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine("Add person");
                    FileHandler.AddPerson(list);
                }
                else if (input == "2")
                {
                    Console.WriteLine("Show people");
                    FileHandler.ShowPeople(list);
                }
                else if (input == "3")
                {
                    Console.WriteLine("Save people");
                    FileHandler.SavePeople(list, installationPath);
                }
                else if (input == "4")
                {
                    Console.WriteLine("Exit");
                    FileHandler.SavePeople(list, installationPath);
                    break;
                }
            } while (true);

            Console.ReadLine();
        }
        /// <summary>
        /// The GetMenu method returns a string that represents the menu options for the user. 
        /// It includes options to add a person, show people, save people, and exit the program.
        /// </summary>
        /// <returns></returns>
        public static String GetMenu()
        {
            return "1. Add person\n2. Show people\n3. Save people\n4. Exit\n";
        }
    }
}