using Exercise4.UtilitesClasses;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities.ShowHeader("Välkommen!");
            Console.Write($"Tryck Enter\nFör standardstorlek 20 platser\nEller ange (1-100)st garageplatser: ");
            string str = Console.ReadLine();
            if (string.IsNullOrEmpty(str))
            {
                str = "20";
            }
            int size = int.TryParse(str, out int result) ? result : 0;
            if (size <= 0 || size > 100)
            {
                Console.WriteLine("Ogiltigt antal garageplatser. Programmet avslutas.");
                return;
            }
            else if (size == 20)
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
