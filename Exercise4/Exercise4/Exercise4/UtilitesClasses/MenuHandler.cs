namespace Exercise4.UtilitesClasses
{
    static public class MenuHandler
    {
        public static Garage? garage { get; set; }
        public static bool Running { get; set; } = true;
        public static bool StartGarage(int garageSize, bool populate = false)
        {
            if (populate == false)
            {
                garage = new Garage(garageSize);
                MenuMain();
            }
            else
            {
                garage = new Garage(20); // Standardstorlek
                GarageHandler.AddStartVehicles(15); // Lägg till 15 slumpmässiga fordon
                MenuMain();
            }
            return true;
        }
        public static void ExitGarage()
        {
            // Här kan allt sparas eller städas upp innan programmet avslutas
            string closing = "Programmet avslutas...";
            Console.Write(Utilities.vTab);
            foreach (var item in closing) { Console.Write(item); Thread.Sleep(50); }
            Running = false;
        }
        public static void MenuMain()
        {

            while (Running)
            {
                Utilities.ShowHeader("Huvudmeny");
                Console.WriteLine("1. Lägg till fordon");
                Console.WriteLine("2. Ta bort fordon");
                Console.WriteLine("3. Visa fordon");
                Console.WriteLine("0. Avsluta");
                TomRaderMenu(4);
                Console.Write($"{Utilities.vTab}Välj: ");
                string? input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        MenuAddVehicle();
                        break;

                    case "2":
                        MenuRemoveVehicle();
                        break;

                    case "3":
                        MenuShowVehicle();
                        break;

                    case "0":
                        MenuHandler.ExitGarage();
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val");
                        Console.ReadKey();
                        break;
                }
            }
        }
        static void MenuAddVehicle()
        {
            bool running = true;

            while (running)
            {
                Utilities.ShowHeader("Lägg till fordon");
                Console.WriteLine("1. Bil");
                Console.WriteLine("2. Buss");
                Console.WriteLine("3. Motorcykel");
                Console.WriteLine("4. Båt");
                Console.WriteLine("5. Flygplan");
                Console.WriteLine("6. Slumässigt");
                Console.WriteLine("0. Tillbaka");
                TomRaderMenu(1);
                Console.Write($"{Utilities.vTab}Välj: ");
                string? input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        GarageHandler.AddCar(garage);
                        break;
                    case "2":
                        GarageHandler.AddBus(garage);
                        break;
                    case "3":
                        GarageHandler.AddMotorcycle(garage);
                        break;
                    case "4":
                        GarageHandler.AddBoat(garage);
                        break;
                    case "5":
                        GarageHandler.AddAirplane(garage);
                        break;
                    case "6":
                        GarageHandler.AddRandomVehicles(garage);
                        break;
                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val");
                        Console.ReadKey();
                        break;
                }
            }
        }
        static void MenuRemoveVehicle()
        {
            bool running = true;

            while (running)
            {
                Utilities.ShowHeader("Ta bort fordon");
                Console.WriteLine("1. Sök och ta bort fordon");
                Console.WriteLine("2. Ta bort fordon på regnummer");
                Console.WriteLine("0. Tillbaka");
                TomRaderMenu(5);
                Console.Write($"{Utilities.vTab}Välj: ");
                string? input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        GarageHandler.RemoveVehicle(garage);
                        break;
                    case "2":
                        GarageHandler.RemoveVehicleById(garage);
                        break;
                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val");
                        Console.ReadKey();
                        break;
                }
            }
        }
        static void MenuShowVehicle()
        {
            bool running = true;

            while (running)
            {
                Utilities.ShowHeader("Visa fordon");
                Console.WriteLine("1. Visa alla");
                Console.WriteLine("2. Visa fordon");
                Console.WriteLine("3. Sök fordon");
                Console.WriteLine("0. Tillbaka");
                TomRaderMenu(4);
                Console.Write($"{Utilities.vTab}Välj: ");
                string? input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        GarageHandler.ShowAllVehicles(garage);
                        break;
                    case "2":
                        GarageHandler.ShowVehicleById(garage);
                        break;
                    case "3":
                        GarageHandler.SearchVehicle(garage);
                        break;
                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val");
                        Console.ReadKey();
                        break;
                }
            }
        }
        static void TomRaderMenu(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine();
            }
        }
    }
}