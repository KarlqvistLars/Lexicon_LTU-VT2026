using System;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// The main entry point of the program. It initializes the list of employees,
            /// loads existing employees from a file if available, and provides a menu
            /// for the user to add, show, save, or exit the program.
            /// </summary>
            List<Employee> list = new List<Employee>();
            string installationPath = Environment.GetCommandLineArgs()[0].Replace("Exercise1.dll", "")+"dbfile.txt";

            if(File.Exists(installationPath)&& new FileInfo(installationPath).Length > 0) {
                list = FileHandler.LoadPeople(installationPath);
            }
            
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
        internal static String GetMenu()
        {
            return "1. Add person\n2. Show people\n3. Save people\n4. Exit\n";
        }
    }
}