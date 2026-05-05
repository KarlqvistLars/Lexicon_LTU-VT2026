using System;
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
                Console.WriteLine(Menu.MenuRad2);
                Console.WriteLine(Menu.MenuRad3);
                Console.WriteLine(Menu.MenuRad4);
                Console.WriteLine(Menu.MenuRad5);
                Console.WriteLine(Menu.MenuRad6);
                Console.WriteLine(Menu.MenuRad7);
                Console.Write(Menu.MenuVal);

                string? input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        running = false;
                        Console.WriteLine(Menu.ProgrammetAvslutas);
                        break;

                    case "1":
                        Bio.UngdomEllerPensionar();
                        break;

                    case "2":
                        Bio.PrisForSallskap();
                        break;

                    case "3":
                        Ord.UpprepaTioGanger();
                        break;

                    case "4":
                        Ord.DetTredjeOrdet();
                        break;

                    case "5":
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

