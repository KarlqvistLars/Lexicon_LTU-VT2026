using System;

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
        }

        public static void DetTredjeOrdet()
        {
            Console.Write(Menu.SkrivEnMeningMedMinst3Ord);
            string? mening = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(mening))
            {
                Console.WriteLine(Menu.DuMasteSkriva);
                return;
            }

            string[] ord = mening.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (ord.Length < 3)
            {
                Console.WriteLine(Menu.MeningMasteInnehalla3ord);
                return;
            }

            Console.WriteLine($"{Menu.DetTredjeOrdet}{ord[2]}");
        }
    }
}
