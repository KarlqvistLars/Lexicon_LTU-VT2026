namespace Exercise4.UtilitesClasses
{

    static public class MenuHandler
    {
        static bool running = true;
        static int choice = 0;
        static public Garage? garage { get; private set; }
        public static bool StartGarage(int garageSize, bool populate = false)
        {
            if (populate == false)
            {
                garage = new Garage(garageSize);
                MenuMain.Show();
            }
            else
            {
                garage = new Garage(20);
                GarageHandler.AddStartVehicles();
                MenuMain.Show();
            }
            return true;
        }
        static void ExitGarage()
        {
            Console.WriteLine("Programmet avslutas...");
            // Här kan allt sparas eller städas upp innan programmet avslutas
            running = false;
            System.Environment.Exit(0);
        }

        static Menu MenuMain = new Menu("Huvudmeny", new MenuItem[]
        {
            new MenuItem("1", "Lägg till fordon", () => MenuAddVehicle?.Show()),
            new MenuItem("2", "Ta bort fordon", () => MenuRemoveVehicle?.Show()),
            new MenuItem("3", "Visa fordon", () => MenuShowVehicle?.Show()),
            new MenuItem("0", "Avsluta", ExitGarage)
        });

        public static Menu MenuAddVehicle = new Menu("Lägg till fordon", new MenuItem[]
         {
            new MenuItem("1","Bil", () => GarageHandler.AddCar(garage ?? throw new InvalidOperationException($"{Utilities.vTab}Garage is not initialized."))),
            new MenuItem("2","Buss", () => GarageHandler.AddBus(garage ?? throw new InvalidOperationException($"{Utilities.vTab}Garage is not initialized."))),
            new MenuItem("3","Motorcykel", () => GarageHandler.AddMotorcycle(garage ?? throw new InvalidOperationException($"{Utilities.vTab}Garage is not initialized."))),
            new MenuItem("4","Båt", () => GarageHandler.AddBoat(garage ?? throw new InvalidOperationException($"{Utilities.vTab}Garage is not initialized."))),
            new MenuItem("5","Flygplan", () => GarageHandler.AddAirplane(garage ?? throw new InvalidOperationException($"{Utilities.vTab}Garage is not initialized."))),
            new MenuItem("6","Slumässigt", () => GarageHandler.AddRandomVehicles(garage ?? throw new InvalidOperationException($"{Utilities.vTab}Garage is not initialized."))),
            new MenuItem("0","Tillbaka", () => MenuMain.Show())
         });

        public static Menu MenuRemoveVehicle = new Menu("Ta bort fordon", new MenuItem[]
        {
            new MenuItem("1", "Sök och ta bort fordon", () => GarageHandler.RemoveVehicle(garage ?? throw new InvalidOperationException($"{Utilities.vTab}Garage is not initialized."))),
            new MenuItem("2", "Ta bort fordon på Id.", GarageHandler.RemoveVehicleById),
            new MenuItem("0","Tillbaka", () => MenuMain.Show())
        });

        public static Menu MenuShowVehicle = new Menu("Visa fordon", new MenuItem[]
        {
            new MenuItem("1", "Visa alla",  () => GarageHandler.ShowAllVehicles(garage ?? throw new InvalidOperationException($"{Utilities.vTab}Garage is not initialized."))),
            new MenuItem("2", "Visa fordon", () => GarageHandler.ShowVehicleById(garage ?? throw new InvalidOperationException($"{Utilities.vTab}Garage is not initialized."))),
            new MenuItem("3", "Sök fordon", () => GarageHandler.SearchVehicle(garage ?? throw new InvalidOperationException($"{Utilities.vTab}Garage is not initialized."))),
            new MenuItem("0","Tillbaka", () => MenuMain.Show())
        });
    }
}