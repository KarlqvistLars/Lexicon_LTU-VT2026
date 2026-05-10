using static Exercise4.UtilitesClasses.Utilities;

namespace Exercise4.UtilitesClasses
{
    public class GarageHandler
    {
        /// <summary>
        /// Alla menyer under "Lägg till fordon".
        /// </summary>
        internal static void AddCar(Garage G)
        {
            string Title = "Lägg till Bil...";
            Utilities.ShowHeader(Title);
            Console.Write($"{Utilities.vTab}Registreringsnummer: ");
            string reg = ReadRegnumInput(G, VType.Car);
            Console.Write($"{Utilities.vTab}Färg: ");
            string? color = Console.ReadLine();
            Console.Write($"{Utilities.vTab}Vikt: ");
            int weight = int.TryParse(Console.ReadLine(), out int w) ? w : 0;
            Console.Write($"{Utilities.vTab}Längd: ");
            int length = int.TryParse(Console.ReadLine(), out int l) ? l : 0;
            Console.Write($"{Utilities.vTab}Antal dörrar: ");
            int doors = int.TryParse(Console.ReadLine(), out int d) ? d : 0;
            Vehicle vehicle = new Car(reg.ToString(), color ?? string.Empty, weight, length, 4, doors);
            G.AddVehicle(vehicle);
        }
        internal static void AddBus(Garage G)
        {
            string Title = "Lägg till Buss";
            Utilities.ShowHeader(Title);
            Console.Write($"{Utilities.vTab}Registreringsnummer: ");
            string reg = ReadRegnumInput(G, VType.Bus);
            Console.Write($"{Utilities.vTab}Färg: ");
            string? color = Console.ReadLine();
            Console.Write($"{Utilities.vTab}Vikt: ");
            int weight = int.TryParse(Console.ReadLine(), out int w) ? w : 0;
            Console.Write($"{Utilities.vTab}Längd: ");
            int length = int.TryParse(Console.ReadLine(), out int l) ? l : 0;
            Console.Write($"{Utilities.vTab}Antal säten: ");
            int seats = int.TryParse(Console.ReadLine(), out int s) ? s : 0;
            Vehicle vehicle = new Bus(reg, color ?? string.Empty, weight, length, seats, 6);
            G.AddVehicle(vehicle);
        }
        internal static void AddMotorcycle(Garage G)
        {
            string Title = $" Lägg till MC";
            Utilities.ShowHeader(Title);
            Console.Write($"{Utilities.vTab}Registreringsnummer: ");
            string reg = ReadRegnumInput(G, VType.Motorcycle);
            Console.Write($"{Utilities.vTab}Färg: ");
            string? color = Console.ReadLine();
            Console.Write($"{Utilities.vTab}Vikt: ");
            int weight = int.TryParse(Console.ReadLine(), out int w) ? w : 0;
            Console.Write($"{Utilities.vTab}Längd: ");
            int length = int.TryParse(Console.ReadLine(), out int l) ? l : 0;
            Console.Write($"{Utilities.vTab}Motorstorlek: ");
            int engineSize = int.TryParse(Console.ReadLine(), out int e) ? e : 0;
            Vehicle vehicle = new Motorcycle(reg, color ?? string.Empty, weight, length, engineSize, 2);
            G.AddVehicle(vehicle);
        }
        internal static void AddBoat(Garage G)
        {
            string Title = $"Lägg till Båt";
            Utilities.ShowHeader(Title);
            Console.Write($"{Utilities.vTab}Registreringsnummer: ");
            string reg = ReadRegnumInput(G, VType.Boat);
            Console.Write($"{Utilities.vTab}Färg: ");
            string? color = Console.ReadLine();
            Console.Write($"{Utilities.vTab}Vikt: ");
            int weight = int.TryParse(Console.ReadLine(), out int w) ? w : 0;
            Console.Write($"{Utilities.vTab}Längd: ");
            int length = int.TryParse(Console.ReadLine(), out int l) ? l : 0;
            Console.Write($"{Utilities.vTab}Max vattendjup: ");
            int maxDepth = int.TryParse(Console.ReadLine(), out int d) ? d : 0;
            Console.Write($"{Utilities.vTab}Max hastighet: ");
            int maxSpeed = int.TryParse(Console.ReadLine(), out int s) ? s : 0;
            Console.Write($"{Utilities.vTab}Deplacement: ");
            int deplacement = int.TryParse(Console.ReadLine(), out int depl) ? depl : 0;
            Vehicle vehicle = new Boat(reg, color ?? string.Empty, weight, length, maxDepth, maxSpeed, deplacement);
            G.AddVehicle(vehicle);
        }
        internal static void AddAirplane(Garage G)
        {
            string Title = $"Lägg till FLP";
            Utilities.ShowHeader(Title);
            Console.Write($"{Utilities.vTab}Registreringsnummer: ");
            string reg = ReadRegnumInput(G, VType.Airplane);
            Console.Write($"{Utilities.vTab}Färg: ");
            string? color = Console.ReadLine();
            Console.Write($"{Utilities.vTab}Vikt: ");
            int weight = int.TryParse(Console.ReadLine(), out int w) ? w : 0;
            Console.Write($"{Utilities.vTab}Längd: ");
            int length = int.TryParse(Console.ReadLine(), out int l) ? l : 0;
            Console.Write($"{Utilities.vTab}Vingbredd: ");
            int wSpan = int.TryParse(Console.ReadLine(), out int ws) ? ws : 0;
            Console.Write($"{Utilities.vTab}Lyftkapacitet: ");
            int liftCapacity = int.TryParse(Console.ReadLine(), out int lc) ? lc : 0;
            Console.Write($"{Utilities.vTab}Antal passagerare: ");
            int passengers = int.TryParse(Console.ReadLine(), out int p) ? p : 0;
            Vehicle vehicle = new Airplane(reg, color ?? string.Empty, weight, length, liftCapacity, wSpan, passengers);
            G.AddVehicle(vehicle);
        }
        internal static void AddRandomVehicles(Garage G, int count = 0)
        {
            string Title = "Lägg till slumpade fordon";
            Utilities.ShowHeader(Title);
            bool isAddedOk = false;
            int countNok = 0;
            if (count == 0)
            {
                Console.Write($"{Utilities.vTab}Hur många: ");
                count = int.TryParse(Console.ReadLine(), out int n) ? n : 0;
            }
            for (int i = 0; i < count; i++)
            {
                Random random = new();
                int number = random.Next(1, 6);
                switch (number)
                {
                    case 1:
                        isAddedOk = G.AddVehicle(new Car("ABC " + (i + 100).ToString(), "Röd", 1200, 4, 4, 4));
                        break;
                    case 2:
                        isAddedOk = G.AddVehicle(new Bus("BBC " + (i + 100).ToString(), "Blå", 12000, 12, 48, 6));
                        break;
                    case 3:
                        isAddedOk = G.AddVehicle(new Motorcycle("MCB " + (i + 100).ToString(), "Svart", 140, 2, 900, 2));
                        break;
                    case 4:
                        isAddedOk = G.AddVehicle(new Boat("BA" + (i + 55020).ToString(), "Vit", 1200, 4, 2m, 24.6m, 1200));
                        break;
                    case 5:
                        isAddedOk = G.AddVehicle(new Airplane(GenerateRandom(), "Silver", 15000, 20, 7000, 20, 28));
                        break;
                    default:
                        break;
                }
                if (!isAddedOk)
                {
                    countNok++;
                }
            }
            Console.WriteLine($"{Utilities.vTab}{count - countNok} st slumpade fordon har lagts till i garaget.");
            Console.WriteLine($"{Utilities.vTab}Tryck på valfri tangent för att återgå till huvudmenyn...");
            Console.ReadKey();
        }
        internal static void AddStartVehicles()
        {
            int count = 20;
            AddRandomVehicles(MenuHandler.garage != null ? MenuHandler.garage : throw new InvalidOperationException($"{Utilities.vTab}Garage is not initialized."), count);
        }
        /// <summary>
        /// Alla menyer under "Ta bort fordon".
        /// </summary>
        internal static void RemoveVehicle(Garage G)
        {
            string Title = "Ta bort fordon.";
            Utilities.ShowHeader(Title);
            SearchVehicle(G);
            Console.Write($"{Utilities.vTab}Välj fordons regnr. att ta bort: ");
            string? regNumber = Console.ReadLine()?.ToUpper();
            if (CheckUniqNumber(G, regNumber))
            {
                G.RemoveVehicle(regNumber ?? string.Empty);
                Console.WriteLine($"{Utilities.vTab}Fordonet med registreringsnummer {regNumber} har tagits bort.");
            }
            else
            {
                Console.WriteLine($"{Utilities.vTab}Inget fordon med registreringsnummer {regNumber} hittades i garaget.");
            }
            Console.WriteLine($"{Utilities.vTab}Tryck på valfri tangent för att återgå till huvudmenyn...");
            Console.ReadKey();
        }
        internal static void RemoveVehicleById()
        {
            string Title = $"Ta bort fordon på Regnummer";
            Utilities.ShowHeader(Title);
            Console.ReadKey();
            throw new NotImplementedException("RemoveVehicleById is not implemented yet.");
        }
        /// <summary>
        /// Alla menyer under "Visa fordon".
        /// </summary>
        public static void ShowAllVehicles(Garage G)
        {
            string Title = "Visa alla fordon av";
            Utilities.ShowHeader(Title);
            Console.WriteLine($" Tryck tangen för att fortsätta...");
            Console.ReadKey();
            for (int i = 0; i < G.Vehicles.Length; i++)
            {
                if (G.Vehicles[i]?.Uuid != null)
                {
                    Console.WriteLine(G.Vehicles[i].ToString2());
                }
            }
            Console.WriteLine($"{Utilities.line30}{Utilities.line30}\n{Utilities.vTab}Tryck på valfri tangent för att återgå till huvudmenyn...");
            Console.ReadKey();
        }
        private static bool ShowGarageInventory(Vehicle v)
        {
            bool listExist = false;
            if (v != null)
            {
                if (v.Uuid == null)
                {
                    Console.WriteLine($"{Utilities.vTab}Empty slot.");
                    listExist = false;
                }
                else
                {
                    Console.WriteLine(v.ToString2());
                    listExist = true;
                }
            }
            return listExist;
        }
        public static void ShowVehicleById(Garage garage)
        {
            Utilities.ShowHeader("Visa fordon på regnr");
            Console.Write($"{Utilities.vTab}Ange regnr: ");
            string? regNumber = Console.ReadLine() ?? string.Empty;
            foreach (Vehicle v in garage?.Vehicles ?? new Vehicle[0])
            {
                if (v != null && v.Uuid != null && v.Uuid.Equals(regNumber, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{Utilities.line30} {Utilities.line30}");
                    Console.WriteLine(v.ToString());
                    Console.WriteLine($"{Utilities.line30}{Utilities.line30}");
                    Console.WriteLine($"{Utilities.vTab}Tryck på valfri tangent för att återgå till huvudmenyn...");
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine($"{Utilities.vTab}Inget fordon hittades.");
            Console.WriteLine($"{Utilities.vTab}Tryck på valfri tangent för att återgå till huvudmenyn...");
            Console.ReadKey();
        }
        internal static void SearchVehicle(Garage garage)
        {
            Console.WriteLine("Tryck tanget för att söka fordon...(alla visas)");
            Console.ReadKey();
            Console.WriteLine($"{Utilities.line30}{Utilities.line30}");
            garage?.Vehicles.ToList().ForEach(v => { if (v != null) Console.WriteLine(v.ToString2()); });
            Console.WriteLine($"{Utilities.line30}{Utilities.line30}");
        }
    }
}
