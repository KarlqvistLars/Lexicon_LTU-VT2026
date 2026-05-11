using Exercise3.UtilitesClasses;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities.ShowHeader("Välkommen!");
            Console.Write($"{Utilities.vTab}Tryck Enter för standardstorlek 20 platser\n{Utilities.vTab}Eller ange (1-100)st garageplatser: ");
            string? str = Console.ReadLine();
            if (string.IsNullOrEmpty(str))
            {
                if (MenuHandler.StartGarage(20, true))
                {
                    return;
                }
            }
            int size = int.TryParse(str, out int result) ? result : 0;
            if (size <= 0 || size > 100)
            {
                Console.WriteLine("Ogiltigt antal garageplatser. Programmet avslutas.");
                return;
            }
            else if (MenuHandler.StartGarage(size))
            {
                return;
            }
            return;
        }
    }
}
