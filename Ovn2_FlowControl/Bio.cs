using System;
using System.Collections.Generic;
using System.Text;

namespace Ovn2_FlowControl
{
    public class Bio
    {
        public static void UngdomEllerPensionar()
        {
            Console.Write("Ange ålder: ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int alder))    // Jämför med int.Parse(input) --> "hej" --> Exception
            {
                Console.WriteLine("Ogiltig ålder.");
                return;
            }

            if (alder < 20)
            {
                Console.WriteLine("Ungdomspris: 80kr");
            }
            else if (alder > 64)
            {
                Console.WriteLine("Pensionärspris: 90kr");
            }
            else
            {
                Console.WriteLine("Standardpris: 120kr");
            }
        }

        public static void PrisForSallskap()
        {
            Console.Write("Hur många personer är ni? ");
            string? antalInput = Console.ReadLine();

            if (!int.TryParse(antalInput, out int antal) || antal <= 0)
            {
                Console.WriteLine("Ogiltigt antal personer.");
                return;
            }

            int total = 0;

            for (int i = 1; i <= antal; i++)
            {
                Console.Write($"Ange ålder för person {i}: ");
                string? alderInput = Console.ReadLine();

                if (!int.TryParse(alderInput, out int alder) || alder < 0)
                {
                    Console.WriteLine("Ogiltig ålder.");
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

            Console.WriteLine($"Antal personer: {antal}");
            Console.WriteLine($"Totalkostnad: {total} kr");
        }
    }
}
