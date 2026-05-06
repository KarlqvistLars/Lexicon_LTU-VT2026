using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace Ovn2_FlowControl
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("sv-SE");
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine(Menu.MenuRubrik);
                Console.WriteLine(Menu.MenuRad1);
                List<string> headMenuOptions = new List<string> { Menu.MenuRad2,Menu.MenuRad8, Menu.MenuRad5, Menu.MenuRad6, Menu.MenuRad7 };
                for (int i = 0; i < headMenuOptions.Count; i++)
                {
                    Console.WriteLine($"{i} = {headMenuOptions[i]}");
                }
                Console.Write(Menu.MenuVal);

                string? input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        running = false;
                        Console.WriteLine(Menu.ProgrammetAvslutas);
                        break;

                    case "1":
                        BioV2.MenuBio();
                        break;

                    case "2":
                        Ord.UpprepaTioGanger();
                        break;

                    case "3":
                        Ord.DetTredjeOrdet();
                        break;

                    case "4":
                        Ord.MenuSprak();
                        break;

                    default:
                        Console.WriteLine(Menu.FelaktigInput);
                        break;
                }

                Console.WriteLine();
            }

        }
        public static void Paus()
        {
            Console.WriteLine($"\n{Menu.TryckForAttFortsatta}");
            Console.ReadKey();
        }
    }
}

