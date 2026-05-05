using System;

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
                    Console.WriteLine($"Person {i}: Gratis");
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
            Console.WriteLine($"\n{Menu.TryckForAttFortsatta}");
            Console.ReadKey();
        }
    }
}
