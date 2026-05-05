using System;

namespace Ovn2_FlowControl
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine(Menu.MenuRubrik);
                Console.WriteLine(Menu.MenuRad1);
                Console.WriteLine(Menu.MenuRad2);
                Console.WriteLine(Menu.MenuRad3);
                Console.WriteLine(Menu.MenuRad4);
                Console.WriteLine(Menu.MenuRad5);
                Console.WriteLine(Menu.MenuRad6);
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

                    default:
                        Console.WriteLine(Menu.FelaktigInput);
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}

