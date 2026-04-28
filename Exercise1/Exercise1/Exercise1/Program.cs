using System;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

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
                    Console.WriteLine("Exit");
                    break;
                }
            } while (true);

            Console.ReadLine();
        }


        internal static String GetMenu()
        {
            return "1. Add person\n2. Show people\n3. Exit\n";
        }
    }
}