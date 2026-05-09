using Exercise4.UtilitesClasses;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" * Garage 1.0 *  Välkommen!  ");
            Console.WriteLine(MenuHandler.line30);
            Console.Write("Ange antal platser i Garage: ");
            int size = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
            if (size <= 0)
            {
                Console.WriteLine("Ogiltigt antal garageplatser. Programmet avslutas.");
                return;
            }
            if (MenuHandler.StartGarage(size))
            {
                return;
            }
        }
    }
}
