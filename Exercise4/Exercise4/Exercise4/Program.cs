using Exercise4.UtilitesClasses;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" * Garage 1.0 *  Välkommen!  ");
            Console.WriteLine(MenuHandler.line30);
            Console.Write($"Tryck Enter\nFör standardstorlek 20 platser\nEller ange antal garageplatser: ");
            int size = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
            if (size < 0)
            {
                Console.WriteLine("Ogiltigt antal garageplatser. Programmet avslutas.");
                return;
            }
            else if (size == 0)
            {
                if (MenuHandler.StartGarage(20, true))
                {
                    return;
                }
            }
            if (MenuHandler.StartGarage(size))
            {
                return;
            }
        }
    }
}
