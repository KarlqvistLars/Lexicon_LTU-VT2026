using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace Ovn2_FlowControl
{
    public class Bio
    {
        public static void UngdomEllerPensionar()
        {
            Console.Write(Menu.AngeAlder);
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int alder))    // Jämför med int.Parse(input) --> "hej" --> Exception
            {
                Console.WriteLine(Menu.OgiltigAlder);
                Program.Paus();
                return;
            }

            if (alder < 20)
            {
                Console.WriteLine(Menu.Ungdomspris);
            }
            else if (alder > 64)
            {
                Console.WriteLine(Menu.Pensionarspris);
            }
            else
            {
                Console.WriteLine(Menu.Standardpris);
            }
            Program.Paus();
        }

        public static void PrisForSallskap()
        {
            Console.Write(Menu.HurManga);
            string? antalInput = Console.ReadLine();

            if (!int.TryParse(antalInput, out int antal) || antal <= 0)
            {
                Console.WriteLine(Menu.OgiltigtAntalPersoner);
                Program.Paus();
                return;
            }

            int total = 0;

            for (int i = 1; i <= antal; i++)
            {
                Console.Write($"{Menu.AngeAlderForPerson} {i}: ");
                string? alderInput = Console.ReadLine();

                if (!int.TryParse(alderInput, out int alder) || alder < 0)
                {
                    Console.WriteLine(Menu.OgiltigAlder);
                    return;
                }

                if (alder < 5 || alder > 100)
                {
                    Console.WriteLine($"Person {i}: {Menu.Gratis}");
                }
                else if (alder < 20)
                {
                    total += 80;
                }
                else if (alder > 64)
                {
                    total += 90;
                }
                else
                {
                    total += 120;
                }
            }

            Console.WriteLine($"{Menu.AntalPersoner}{antal}");
            Console.WriteLine($"{Menu.Totalkostnad}{total} kr");
            Program.Paus();
        }

        public static void MenuBio() 
        {
            bool runningBio = true;

            while (runningBio)
            {
                Console.Clear();
                Console.WriteLine(Menu.MenuBio);
                Console.WriteLine(Menu.MenuRad1);
                List<string> menuOptions = new List<string> { Menu.MenuRad2, Menu.MenuRad3, Menu.MenuRad4 };
                for (int i = 0; i < menuOptions.Count; i++)
                {
                    Console.WriteLine($"{i} = {menuOptions[i]}");
                }
                Console.Write(Menu.MenuVal);
                string? input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        return;
                    case "1":
                        UngdomEllerPensionar();
                        break;
                    case "2":
                        PrisForSallskap();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
