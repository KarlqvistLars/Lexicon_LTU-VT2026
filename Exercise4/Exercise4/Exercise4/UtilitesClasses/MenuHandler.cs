namespace Exercise4.UtilitesClasses
{

    static public class MenuHandler
    {
        static public string line30 { get; } = "==============================";
        static string e30 { get; } = "                              ";
        static public string vTab { get; } = "   ";
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
                GarageUtilities.AddStartVehicles();
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
            new MenuItem("1","Bil", () => GarageUtilities.AddCar(garage ?? throw new InvalidOperationException($"{vTab}Garage is not initialized."))),
            new MenuItem("2","Buss", () => GarageUtilities.AddBus(garage ?? throw new InvalidOperationException($"{vTab}Garage is not initialized."))),
            new MenuItem("3","Motorcykel", () => GarageUtilities.AddMotorcycle(garage ?? throw new InvalidOperationException($"{vTab}Garage is not initialized."))),
            new MenuItem("4","Båt", () => GarageUtilities.AddBoat(garage ?? throw new InvalidOperationException($"{vTab}Garage is not initialized."))),
            new MenuItem("5","Flygplan", () => GarageUtilities.AddAirplane(garage ?? throw new InvalidOperationException($"{vTab}Garage is not initialized."))),
            new MenuItem("6","Slumässigt", () => GarageUtilities.AddRandomVehicles(garage ?? throw new InvalidOperationException($"{vTab}Garage is not initialized."))),
            new MenuItem("0","Tillbaka", () => MenuMain.Show())
         });

        public static Menu MenuRemoveVehicle = new Menu("Ta bort fordon", new MenuItem[]
        {
            new MenuItem("1", "Sök och ta bort fordon", () => GarageUtilities.RemoveVehicle(garage ?? throw new InvalidOperationException($"{vTab}Garage is not initialized."))),
            new MenuItem("2", "Ta bort fordon på Id.", GarageUtilities.RemoveVehicleById),
            new MenuItem("0","Tillbaka", () => MenuMain.Show())
        });

        public static Menu MenuShowVehicle = new Menu("Visa fordon", new MenuItem[]
        {
            new MenuItem("1", "Visa alla",  () => GarageUtilities.ShowAllVehicles(garage ?? throw new InvalidOperationException($"{vTab}Garage is not initialized."))),
            new MenuItem("2", "Visa fordon", () => GarageUtilities.ShowVehicleById(garage ?? throw new InvalidOperationException($"{vTab}Garage is not initialized."))),
            new MenuItem("3", "Sök fordon", () => GarageUtilities.SearchVehicle(garage ?? throw new InvalidOperationException($"{vTab}Garage is not initialized."))),
            new MenuItem("0","Tillbaka", () => MenuMain.Show())
        });
    }
}