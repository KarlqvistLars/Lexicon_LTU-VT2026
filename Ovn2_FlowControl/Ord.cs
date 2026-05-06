using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace Ovn2_FlowControl
{
    public class Ord
    {
        public static void UpprepaTioGanger()
        {
            Console.Write(Menu.SkrivEnText);
            string? text = Console.ReadLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}. {text} ");
            }

            Console.WriteLine();
            Program.Paus();
        }

        public static void DetTredjeOrdet()
        {
            Console.Write(Menu.Mening3ord);
            string? mening = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(mening))
            {
                Console.WriteLine(Menu.DuMasteSkriva);
                Program.Paus();
                return;
            }

            string[] ord = mening.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (ord.Length < 3)
            {
                Console.WriteLine(Menu.MeningMasteInnehalla3ord);
                Program.Paus();
                return;
            }

            Console.WriteLine($"{Menu.DetTredjeOrdet}{ord[2]}");
            Program.Paus();
        }

        public static void MenuSprak()
        {
            List<string> sprak = new List<string> { Menu.Engelska, Menu.Svenska, Menu.Franska };
            for(int i = 0; i < sprak.Count; i++)
            {
                Console.WriteLine($"{i} = {sprak[i]}");
            }
            Console.WriteLine(Menu.ValgSprak);

            string? input = Console.ReadLine();

            switch (input)
            {
                case "0":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    break;
                case "1":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("sv-SE");
                    break;
                case "2":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
                    break;
                case "3":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
                    break;
                default:
                    break;
            }
         }
    }
}
