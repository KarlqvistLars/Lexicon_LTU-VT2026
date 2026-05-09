using static Exercise4.UtilitesClasses.GarageManager;

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
            GarageManager.ShowHeader(Title);
            Console.Write($"{MenuHandler.vTab}Registreringsnummer: ");
            string reg = ReadRegnumInput(G, VType.Car);
            Console.Write($"{MenuHandler.vTab}Färg: ");
            string? color = Console.ReadLine();
            Console.Write($"{MenuHandler.vTab}Vikt: ");
            int weight = int.TryParse(Console.ReadLine(), out int w) ? w : 0;
            Console.Write($"{MenuHandler.vTab}Längd: ");
            int length = int.TryParse(Console.ReadLine(), out int l) ? l : 0;
            Console.Write($"{MenuHandler.vTab}Antal dörrar: ");
            int doors = int.TryParse(Console.ReadLine(), out int d) ? d : 0;
            Vehicle vehicle = new Car(reg.ToString(), color ?? string.Empty, weight, length, 4, doors);
            G.AddVehicle(vehicle);
        }
        internal static void AddBus(Garage G)
        {
            string Title = "Lägg till Buss";
            GarageManager.ShowHeader(Title);
            Console.Write($"{MenuHandler.vTab}Registreringsnummer: ");
            string reg = ReadRegnumInput(G, VType.Bus);
            Console.Write($"{MenuHandler.vTab}Färg: ");
            string? color = Console.ReadLine();
            Console.Write($"{MenuHandler.vTab}Vikt: ");
            int weight = int.TryParse(Console.ReadLine(), out int w) ? w : 0;
            Console.Write($"{MenuHandler.vTab}Längd: ");
            int length = int.TryParse(Console.ReadLine(), out int l) ? l : 0;
            Console.Write($"{MenuHandler.vTab}Antal säten: ");
            int seats = int.TryParse(Console.ReadLine(), out int s) ? s : 0;
            Vehicle vehicle = new Bus(reg, color ?? string.Empty, weight, length, seats, 6);
            G.AddVehicle(vehicle);
        }
        internal static void AddMotorcycle(Garage G)
        {
            string Title = $" Lägg till MC";
            GarageManager.ShowHeader(Title);
            Console.Write($"{MenuHandler.vTab}Registreringsnummer: ");
            string reg = ReadRegnumInput(G, VType.Motorcycle);
            Console.Write($"{MenuHandler.vTab}Färg: ");
            string? color = Console.ReadLine();
            Console.Write($"{MenuHandler.vTab}Vikt: ");
            int weight = int.TryParse(Console.ReadLine(), out int w) ? w : 0;
            Console.Write($"{MenuHandler.vTab}Längd: ");
            int length = int.TryParse(Console.ReadLine(), out int l) ? l : 0;
            Console.Write($"{MenuHandler.vTab}Motorstorlek: ");
            int engineSize = int.TryParse(Console.ReadLine(), out int e) ? e : 0;
            Vehicle vehicle = new Motorcycle(reg, color ?? string.Empty, weight, length, engineSize, 2);
            G.AddVehicle(vehicle);
        }
        internal static void AddBoat(Garage G)
        {
            string Title = $"Lägg till Båt";
            GarageManager.ShowHeader(Title);
            Console.Write($"{MenuHandler.vTab}Registreringsnummer: ");
            string reg = ReadRegnumInput(G, VType.Boat);
            Console.Write($"{MenuHandler.vTab}Färg: ");
            string? color = Console.ReadLine();
            Console.Write($"{MenuHandler.vTab}Vikt: ");
            int weight = int.TryParse(Console.ReadLine(), out int w) ? w : 0;
            Console.Write($"{MenuHandler.vTab}Längd: ");
            int length = int.TryParse(Console.ReadLine(), out int l) ? l : 0;
            Console.Write($"{MenuHandler.vTab}Max vattendjup: ");
            int maxDepth = int.TryParse(Console.ReadLine(), out int d) ? d : 0;
            Console.Write($"{MenuHandler.vTab}Max hastighet: ");
            int maxSpeed = int.TryParse(Console.ReadLine(), out int s) ? s : 0;
            Console.Write($"{MenuHandler.vTab}Deplacement: ");
            int deplacement = int.TryParse(Console.ReadLine(), out int depl) ? depl : 0;
            Vehicle vehicle = new Boat(reg, color ?? string.Empty, weight, length, maxDepth, maxSpeed, deplacement);
            G.AddVehicle(vehicle);
        }
        internal static void AddAirplane(Garage G)
        {
            string Title = $"Lägg till FLP";
            GarageManager.ShowHeader(Title);
            Console.Write($"{MenuHandler.vTab}Registreringsnummer: ");
            string reg = ReadRegnumInput(G, VType.Airplane);
            Console.Write($"{MenuHandler.vTab}Färg: ");
            string? color = Console.ReadLine();
            Console.Write($"{MenuHandler.vTab}Vikt: ");
            int weight = int.TryParse(Console.ReadLine(), out int w) ? w : 0;
            Console.Write($"{MenuHandler.vTab}Längd: ");
            int length = int.TryParse(Console.ReadLine(), out int l) ? l : 0;
            Console.Write($"{MenuHandler.vTab}Vingbredd: ");
            int wSpan = int.TryParse(Console.ReadLine(), out int ws) ? ws : 0;
            Console.Write($"{MenuHandler.vTab}Lyftkapacitet: ");
            int liftCapacity = int.TryParse(Console.ReadLine(), out int lc) ? lc : 0;
            Console.Write($"{MenuHandler.vTab}Antal passagerare: ");
            int passengers = int.TryParse(Console.ReadLine(), out int p) ? p : 0;
            Vehicle vehicle = new Airplane(reg, color ?? string.Empty, weight, length, liftCapacity, wSpan, passengers);
            G.AddVehicle(vehicle);
        }
        internal static void AddRandomVehicles(Garage G, int count = 0)
        {
            string Title = "Lägg till slumpade fordon";
            GarageManager.ShowHeader(Title);
            if (count == 0)
            {
                Console.Write("Hur många: ");
                count = int.TryParse(Console.ReadLine(), out int n) ? n : 0;
            }
            for (int i = 0; i < count; i++)
            {
                Random random = new Random();
                int number = random.Next(1, 6);
                switch (number)
                {
                    case 1:
                        G.AddVehicle(new Car("ABC " + (i + 100).ToString(), "Röd", 1200, 4, 4, 4));
                        break;
                    case 2:
                        G.AddVehicle(new Bus("BBC " + (i + 100).ToString(), "Blå", 12000, 12, 48, 6));
                        break;
                    case 3:
                        G.AddVehicle(new Motorcycle("MCB " + (i + 100).ToString(), "Svart", 140, 2, 900, 2));
                        break;
                    case 4:
                        G.AddVehicle(new Boat("BA" + (i + 55020).ToString(), "Vit", 1200, 4, 2m, 24.6m, 1200));
                        break;
                    case 5:
                        G.AddVehicle(new Airplane(GenerateRandom(), "Silver", 15000, 20, 7000, 20, 28));
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"{MenuHandler.vTab}{count} st slumpade fordon har lagts till i garaget.");
            Console.WriteLine($"{MenuHandler.vTab}Tryck på valfri tangent för att återgå till huvudmenyn...");
            Console.ReadKey();
        }
        internal static void AddStartVehicles()
        {
            int count = 20;
            AddRandomVehicles(MenuHandler.garage != null ? MenuHandler.garage : throw new InvalidOperationException($"{MenuHandler.vTab}Garage is not initialized."), count);
        }
        /// <summary>
        /// Alla menyer under "Ta bort fordon".
        /// </summary>
        internal static void RemoveVehicle(Garage G)
        {
            string Title = "Ta bort fordon.";
            GarageManager.ShowHeader(Title);
            SearchVehicle(G);
            Console.WriteLine($"{MenuHandler.vTab}Välj fordons regnr. att ta bort: ");
            string? regNumber = Console.ReadLine()?.ToUpper();
            if (CheckUniqNumber(G, regNumber))
            {
                G.RemoveVehicle(regNumber ?? string.Empty);
                Console.WriteLine($"{MenuHandler.vTab}Fordonet med registreringsnummer {regNumber} har tagits bort.");
            }
            else
            {
                Console.WriteLine($"{MenuHandler.vTab}Inget fordon med registreringsnummer {regNumber} hittades i garaget.");
            }
            Console.WriteLine($"{MenuHandler.vTab}Tryck på valfri tangent för att återgå till huvudmenyn...");
            Console.ReadKey();
        }
        internal static void RemoveVehicleById()
        {
            string Title = $"Ta bort fordon på Regnummer";
            GarageManager.ShowHeader(Title);
            Console.ReadKey();
            throw new NotImplementedException("RemoveVehicleById is not implemented yet.");
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


            Console.Clear();
            Console.WriteLine(" * Garage 1.0 *");
            Console.WriteLine(MenuHandler.line30);
            Console.WriteLine("Alla fordon i garaget:");
            Console.WriteLine(MenuHandler.line30);
            for (int i = 0; i < G.Vehicles.Length; i++)
            {
                if (G.Vehicles[i] != null)
                {
                    Console.WriteLine(G.Vehicles[i].ToString2());
                }
            }
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
            ///==============================
            ///

            Console.Write($"{MenuHandler.vTab}Ange Id på fordonet du vill visa: ");
            string? idInput = Console.ReadLine();
            if (int.TryParse(idInput, out int id_))
            {
                if (id_ >= 0 && id_ < garage.Vehicles.Length)
                {
                    if (garage.Vehicles[id_] != null)
                    {
                        Console.WriteLine(garage.Vehicles[id_].ToString2());
                    }
                    else
                    {
                        Console.WriteLine($"{MenuHandler.vTab}Inget fordon med Id {id} hittades i garaget.");
                    }
                }
                else
                {
                    Console.WriteLine($"{MenuHandler.vTab}Ogiltigt Id. Vänligen ange ett nummer mellan 0 och {garage.Vehicles.Length - 1}.");
                }
            }
            else
            {
                Console.WriteLine($"{MenuHandler.vTab}Ogiltig inmatning. Vänligen ange ett giltigt nummer.");
            }

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
