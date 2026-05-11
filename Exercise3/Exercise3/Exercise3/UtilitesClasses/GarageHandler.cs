using static Exercise3.UtilitesClasses.Utilities;

namespace Exercise3.UtilitesClasses
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
            int countNok = 0;
            if (count == 0)
            {
                Console.Write($"{Utilities.vTab}Hur många: ");
                count = int.TryParse(Console.ReadLine(), out int n) ? n : 0;
            }
            for (int i = 0; i < count; i++)
            {
                Random random = new();
                int number = random.Next(1, 7);
                bool isAddedOk = false;
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
                    case 6:
                        isAddedOk = G.AddVehicle(new Motorcycle("MCC " + (i + 100).ToString(), "Rosa", 180, 2, 900, 3));
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
            Console.ReadLine();
        }
        internal static void AddStartVehicles(int count)
        {
            AddRandomVehicles(MenuHandler.garage != null ? MenuHandler.garage : throw new InvalidOperationException($"{Utilities.vTab}Garage is not initialized."), count);
        }
        /// <summary>
        /// Alla menyer under "Ta bort fordon".
        /// </summary>
        internal static void RemoveVehicle(Garage G)
        {
            string Title = "Ta bort fordon.";
            Utilities.ShowHeader(Title);
            if (SearchVehicle(G)) { RemoveVehicleById(G); }
        }
        internal static void RemoveVehicleByRegnummer(Garage G)
        {
            string Title = $"Ta bort fordon på Regnummer";
            Utilities.ShowHeader(Title);
            RemoveVehicleById(G);
        }
        internal static void RemoveVehicleById(Garage G)
        {
            Console.Write($"{Utilities.vTab}Välj fordons regnr. att ta bort: ");
            string? regNumber = Console.ReadLine()?.ToUpper();
            if (CheckUniqNumber(G, regNumber))
            {
                G.RemoveVehicle(regNumber ?? string.Empty);
                Console.WriteLine($"{Utilities.vTab}Fordonet med registreringsnummer {regNumber} har tagits bort.");
            }
            //else
            //{
            //    Console.WriteLine($"{Utilities.vTab}Inget fordon med registreringsnummer {regNumber} hittades i garaget.");
            //}
            Console.WriteLine($"{Utilities.vTab}Tryck på valfri tangent för att återgå till huvudmenyn...");
            Console.ReadKey();
        }
        /// <summary>
        /// Alla menyer under "Visa fordon".
        /// </summary>
        internal static void ShowAllVehicles(Garage G)
        {
            bool fordonVisade = false;
            string Title = "Visa alla fordon av";
            Utilities.ShowHeader(Title);
            Console.WriteLine($"{Utilities.vTab}Tryck tangen för att fortsätta...");
            Console.ReadKey();
            int count = 0;
            for (int i = 0; i < G.Vehicles.Length; i++)
            {
                count++;
                string text = $"{count} {Utilities.line30}";
                text = text.Length > 30 ? text[..30] : text;
                if (G.Vehicles[i]?.Uuid != null)
                {
                    Console.WriteLine($"{text}{Utilities.line30}");
                    Console.WriteLine($"{G.Vehicles[i].ToString2()}");
                    fordonVisade = true;
                }
                else
                {
                    count--;
                }
            }
            if (!fordonVisade)
            {
                Console.WriteLine($"{Utilities.vTab}Inga fordon hittades.\n{Utilities.vTab}Garaget är tomt.");
            }
            Console.WriteLine($"{Utilities.line30}{Utilities.line30}\n{Utilities.vTab}Tryck på valfri tangent för att återgå till huvudmenyn...");
            Console.ReadKey();
        }
        internal static void ShowVehicleById(Garage garage)
        {
            Utilities.ShowHeader("Visa fordon på regnr");
            Console.Write($"{Utilities.vTab}Ange regnr: ");
            string? regNumber = Console.ReadLine() ?? string.Empty;
            foreach (Vehicle v in garage?.Vehicles ?? new Vehicle[0])
            {
                if (v != null && v.Uuid != null && v.Uuid.Equals(regNumber, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{Utilities.line30}{Utilities.line30}");
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
        internal static bool SearchVehicleAndShow(Garage garage)
        {
            bool fordonVisade = false;
            string[] fordon = { "fordon", "bilar", "bussar", "motorcyklar", "båtar", "flygplan" };
            string Title = "Sök fordon";
            Utilities.ShowHeader(Title);
            Console.WriteLine("Sök parametrar:\n" +
                "Välj en siffra, skriv en sökterm eller\ntryck Enter för att hoppa över:");
            Console.Write("Du vill söka en:\n1. Bil\n2. Buss\n3. Motorcykel\n4. Båt\n5. Flygplan?\nAnge val: ");
            int vehichleType = int.TryParse(Console.ReadLine(), out int res) ? res : 0;
            Console.Write($"\nDu söker {fordon[vehichleType]} med registrerings nummer (Enter för att hoppa över): ");
            string regNumber;
            if (vehichleType == 1 || vehichleType == 2 || vehichleType == 3 || vehichleType == 4 || vehichleType == 5)
            {
                regNumber = ReadRegnumInput(garage, (VType)vehichleType);
            }
            else
            {
                regNumber = "";
            }
            Console.Write("\nsom har färgen (Enter för att hoppa över): ");
            string? color = Console.ReadLine() ?? string.Empty;
            Console.Write("\noch väger (Enter för att hoppa över): ");
            string? weight = Console.ReadLine() ?? string.Empty;
            Console.Write("\nmed längden (Enter för att hoppa över): ");
            string? length = Console.ReadLine() ?? string.Empty;
            fordonVisade = ShowGarageSearch(garage, (VType)vehichleType, regNumber, color, weight, length);
            Console.WriteLine($"\n{Utilities.vTab}Tryck på Enter för att fortsätta...");
            Console.ReadLine();
            return fordonVisade;
        }
        internal static bool SearchVehicle(Garage garage)
        {
            bool fordonVisade = false;
            string[] fordon = { "fordon", "bilar", "bussar", "motorcyklar", "båtar", "flygplan" };
            string Title = "Sök fordon";
            Utilities.ShowHeader(Title);
            Console.WriteLine("Sök parametrar:\n" +
                "Välj en siffra, skriv en sökterm eller\ntryck Enter för att hoppa över:");
            Console.Write("Du vill söka en:\n1. Bil\n2. Buss\n3. Motorcykel\n4. Båt\n5. Flygplan?\nAnge val: ");
            int vehichleType = int.TryParse(Console.ReadLine(), out int res) ? res : 0;
            Console.Write($"\nDu söker {fordon[vehichleType]} med registrerings nummer (Enter för att hoppa över): ");
            string regNumber = Console.ReadLine() ?? string.Empty;
            if (vehichleType == 1 || vehichleType == 2 || vehichleType == 3 || vehichleType == 4 || vehichleType == 5)
            {
                if (!string.IsNullOrEmpty(regNumber)) { regNumber = ReadRegnumInput(garage, (VType)vehichleType); }
            }
            else
            {
                regNumber = "";
            }
            Console.Write("\nsom har färgen (Enter för att hoppa över): ");
            string? color = Console.ReadLine() ?? string.Empty;
            Console.Write("\noch väger (Enter för att hoppa över): ");
            string? weight = Console.ReadLine() ?? string.Empty;
            Console.Write("\nmed längden (Enter för att hoppa över): ");
            string? length = Console.ReadLine() ?? string.Empty;
            fordonVisade = ShowGarageSearch(garage, (VType)vehichleType, regNumber, color, weight, length);
            return fordonVisade;
        }
        private static bool ShowGarageSearch(Garage G, VType vT, string regNumber, string color, string weight, string length)
        {
            int counter = 0;
            bool listExist = false;
            string[] fordon = { "fordon", "bilar", "bussar", "motorcyklar", "båtar", "flygplan" };
            foreach (Vehicle v in G.Vehicles)
            {
                if (v != null &&
                    (vT == VType.None || v.Type.Equals(vT.ToString(), StringComparison.OrdinalIgnoreCase)) &&
                    (string.IsNullOrEmpty(regNumber) || v.Uuid.Equals(regNumber, StringComparison.OrdinalIgnoreCase)) &&
                    (string.IsNullOrEmpty(color) || v.Color.Equals(color, StringComparison.OrdinalIgnoreCase)) &&
                    (string.IsNullOrEmpty(weight) || v.Weight.ToString().Equals(weight, StringComparison.OrdinalIgnoreCase)) &&
                    (string.IsNullOrEmpty(length) || v.Length.ToString().Equals(length, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine($"{Utilities.line30}{Utilities.line30}");
                    Console.WriteLine(v.ToString2());
                    listExist = true;
                    counter++;
                }
            }
            Console.WriteLine($"{Utilities.line30}{Utilities.line30}");
            Console.WriteLine($"{Utilities.vTab}Det fanns {counter} {fordon[(int)vT]} som matchade sökkriterierna.");
            Console.WriteLine($"{Utilities.vTab}Regnummer: {(string.IsNullOrEmpty(regNumber) ? "Alla" : regNumber)}, Färg: {(string.IsNullOrEmpty(color) ? "Alla" : color)}, Vikt: {(string.IsNullOrEmpty(weight) ? "Alla" : weight)}, Längd: {(string.IsNullOrEmpty(length) ? "Alla" : length)}");
            if (!listExist)
            {
                Console.WriteLine($"{Utilities.vTab}Det fanns inga {fordon[(int)vT]} som matchade sökkriterierna.");
                Console.WriteLine($"{Utilities.vTab}Regnummer: {(string.IsNullOrEmpty(regNumber) ? "Alla" : regNumber)}, Färg: {(string.IsNullOrEmpty(color) ? "Alla" : color)}, Vikt: {(string.IsNullOrEmpty(weight) ? "Alla" : weight)}, Längd: {(string.IsNullOrEmpty(length) ? "Alla" : length)}");
            }
            return listExist;
        }
    }
}
