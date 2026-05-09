namespace Exercise4.UtilitesClasses
{
    public class GarageUtilities
    {
        /// <summary>
        /// Alla menyer under "Lägg till fordon".
        /// </summary>
        internal static void AddCar(Garage G)
        {
            string Title = "Lägg till Bil...";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" * ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Garage 1.0");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" * ");
            Console.ResetColor();
            Console.WriteLine("================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" {Title}");
            Console.ResetColor();
            Console.WriteLine("================================");
            GarageManager.AddCar(G != null ? G : throw new InvalidOperationException($"{MenuHandler.vTab}Garage is not initialized."));
        }
        internal static void AddBus(Garage G)
        {
            string Title = "Lägg till Buss";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" * ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Garage 1.0");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" * ");
            Console.ResetColor();
            Console.WriteLine("================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" {Title}");
            Console.ResetColor();
            Console.WriteLine("================================");
            GarageManager.AddBus(G != null ? G : throw new InvalidOperationException($"{MenuHandler.vTab}Garage is not initialized."));
        }
        internal static void AddMotorcycle(Garage G)
        {
            string Title = $" Lägg till MC";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" * ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Garage 1.0");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" * ");
            Console.ResetColor();
            Console.WriteLine("================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" {Title}");
            Console.ResetColor();
            Console.WriteLine("================================");
            GarageManager.AddMC(G != null ? G : throw new InvalidOperationException($"{MenuHandler.vTab}Garage is not initialized."));
        }
        internal static void AddBoat(Garage G)
        {
            string Title = $"Lägg till Båt";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" * ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Garage 1.0");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" * ");
            Console.ResetColor();
            Console.WriteLine("================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" {Title}");
            Console.ResetColor();
            Console.WriteLine("================================");
            GarageManager.AddBoat(G != null ? G : throw new InvalidOperationException($"{MenuHandler.vTab}Garage is not initialized."));
        }
        internal static void AddAirplane(Garage G)
        {
            string Title = $"Lägg till FLP";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" * ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Garage 1.0");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" * ");
            Console.ResetColor();
            Console.WriteLine("================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" {Title}");
            Console.ResetColor();
            Console.WriteLine("================================");
            GarageManager.AddAirplane(G != null ? G : throw new InvalidOperationException($"{MenuHandler.vTab}Garage is not initialized."));
        }
        internal static void AddRandomVehicles(Garage G)
        {
            Console.Clear();
            Console.WriteLine(" * Garage 1.0 *");
            Console.WriteLine(MenuHandler.line30);
            Console.WriteLine("Lägg till slumpade fordon");
            Console.WriteLine(MenuHandler.line30);
            Console.Write("Hur många: ");
            int count = int.TryParse(Console.ReadLine(), out int n) ? n : 0;
            GarageManager.AddRandomVehicles(count, G != null ? G : throw new InvalidOperationException($"{MenuHandler.vTab}Garage is not initialized."));
        }
        internal static void AddStartVehicles()
        {
            int count = 20;
            GarageManager.AddRandomVehicles(count, MenuHandler.garage != null ? MenuHandler.garage : throw new InvalidOperationException($"{MenuHandler.vTab}Garage is not initialized."));
        }
        /// <summary>
        /// Alla menyer under "Ta bort fordon".
        /// </summary>
        internal static void RemoveVehicle(Garage G)
        {
            string Title = "Ta bort fordon...";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" * ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Garage 1.0");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" * ");
            Console.ResetColor();
            Console.WriteLine("================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" {Title}");
            Console.ResetColor();
            Console.WriteLine("================================");
            SearchVehicle(G);
            Console.WriteLine($"{MenuHandler.vTab}Välj fordons Id att ta bort: ");
            string id = Console.ReadLine() ?? string.Empty;

            G.RemoveVehicle(id);

            Console.WriteLine($"{MenuHandler.vTab}Tryck på valfri tangent för att återgå till huvudmenyn...");
            Console.ReadKey();
        }
        internal static void RemoveVehicleById()
        {
            Console.Clear();
            Console.WriteLine("Ta bort fordon på Id...");
            Console.ReadKey();
        }
        /// <summary>
        /// Alla menyer under "Visa fordon".
        /// </summary>
        public static void ShowAllVehicles(Garage G)
        {
            string Title = "Visa alla fordon av";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" * ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Garage 1.0");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" * ");
            Console.ResetColor();
            Console.WriteLine("================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" {Title} {G.Capacity} platser.");
            Console.ResetColor();
            Console.WriteLine("================================");
            Console.WriteLine($"{MenuHandler.vTab}Tryck tangen för att fortsätta...");
            Console.ReadKey();
            MenuHandler.garage?.Vehicles.ToList().ForEach(v => { if (v != null) Console.WriteLine(v.ToString2()); });
            Console.WriteLine($"{MenuHandler.line30}{MenuHandler.line30}");
            Console.WriteLine($"{MenuHandler.vTab}Tryck på valfri tangent för att återgå till huvudmenyn...");
            Console.ReadKey();
        }
        public static void ShowVehicleById(Garage garage)
        {
            Console.Clear();
            Console.WriteLine($"{MenuHandler.vTab}Visa fordon på Id...");
            Console.Write($"{MenuHandler.vTab}Ange Id: ");
            string id = Console.ReadLine() ?? string.Empty;
            foreach (var v in garage?.Vehicles ?? new Vehicle[0])
            {
                if (v != null && v.Uuid.Equals(id, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{MenuHandler.line30}{MenuHandler.line30}");
                    Console.WriteLine(v.ToString());
                    Console.WriteLine($"{MenuHandler.line30}{MenuHandler.line30}");
                    Console.WriteLine($"{MenuHandler.vTab}Tryck på valfri tangent för att återgå till huvudmenyn...");
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine($"{MenuHandler.vTab}Inget fordon hittades.");
            Console.WriteLine($"{MenuHandler.vTab}Tryck på valfri tangent för att återgå till huvudmenyn...");
            Console.ReadKey();
        }
        internal static void SearchVehicle(Garage garage)
        {
            Console.Clear();
            Console.WriteLine("Sök fordon...");
            Console.WriteLine(MenuHandler.line30);
            garage?.Vehicles.ToList().ForEach(v => { if (v != null) Console.WriteLine(v.ToString2()); });
            Console.WriteLine(MenuHandler.line30);
            Console.WriteLine($"{MenuHandler.vTab}Tryck på valfri tangent för att återgå till huvudmenyn...");
            Console.ReadKey();
        }
    }
}
