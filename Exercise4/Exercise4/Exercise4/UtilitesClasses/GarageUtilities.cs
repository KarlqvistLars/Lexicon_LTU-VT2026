namespace Exercise4.UtilitesClasses
{
    public class GarageUtilities
    {
        internal static void AddVehicle()
        {
            Console.Clear();
            Console.WriteLine("Lägg till fordon...");
            Console.ReadKey();
        }
        public static void ShowVehicles()
        {
            Console.Clear();
            MenuHandler.MenuShowVehicle.Show();
            Console.ReadKey();
        }
        internal static void SearchVehicle()
        {
            Console.Clear();
            Console.WriteLine("Sök fordon...");
            Console.ReadKey();
        }
    }
}
