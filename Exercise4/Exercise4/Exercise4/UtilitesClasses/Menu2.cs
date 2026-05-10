namespace Exercise4.UtilitesClasses
{
    public class Menu2
    {
        static private Garage _garage = new Garage(Garage.Capacity);

        public Menu2()
        {
            _garage = MenuHandler.garage;
        }

        public void MenuMain2()
        {
            bool running = true;

            while (running)
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
                        MenuAddVehicle2();
                        break;

                    case "2":
                        MenuRemoveVehicle2();
                        break;

                    case "3":
                        MenuShowVehicle2();
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

        static void MenuAddVehicle2()
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
                        GarageHandler.AddCar(_garage);
                        break;
                    case "2":
                        GarageHandler.AddBus(_garage);
                        break;
                    case "3":
                        GarageHandler.AddMotorcycle(_garage);
                        break;
                    case "4":
                        GarageHandler.AddBoat(_garage);
                        break;
                    case "5":
                        GarageHandler.AddAirplane(_garage);
                        break;
                    case "6":
                        GarageHandler.AddRandomVehicles(_garage);
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

        static void MenuRemoveVehicle2()
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
                        GarageHandler.RemoveVehicle(_garage);
                        break;
                    case "2":
                        GarageHandler.RemoveVehicleById(_garage);
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

        static void MenuShowVehicle2()
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
                        GarageHandler.ShowAllVehicles(_garage);
                        break;
                    case "2":
                        GarageHandler.ShowVehicleById(_garage);
                        break;
                    case "3":
                        GarageHandler.SearchVehicle(_garage);
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
