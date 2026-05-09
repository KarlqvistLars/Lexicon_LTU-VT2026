using System.Text.RegularExpressions;

namespace Exercise4.UtilitesClasses
{
    static public class GarageManager
    {
        public enum VType
        {
            None,
            Car = 1,
            Bus = 2,
            Motorcycle = 3,
            Boat = 4,
            Airplane = 5
        }
        internal static void AddRandomVehicles(int count, Garage garage)
        {
            for (int i = 0; i < count; i++)
            {
                Random random = new Random();
                int number = random.Next(1, 6);
                switch (number)
                {
                    case 1:
                        garage.AddVehicle(new Car("ABC " + (i + 100).ToString(), "Röd", 1200, 4, 4, 4));
                        break;
                    case 2:
                        garage.AddVehicle(new Bus("BBC " + (i + 100).ToString(), "Blå", 12000, 12, 48, 6));
                        break;
                    case 3:
                        garage.AddVehicle(new Motorcycle("MCB " + (i + 100).ToString(), "Svart", 140, 2, 900, 2));
                        break;
                    case 4:
                        garage.AddVehicle(new Boat("BA" + (i + 55020).ToString(), "Vit", 1200, 4, 2m, 24.6m, 1200));
                        break;
                    case 5:
                        garage.AddVehicle(new Airplane(GenerateRandom(), "Silver", 15000, 20, 7000, 20, 28));
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"{MenuHandler.vTab}{count} st slumpade fordon har lagts till i garaget.");
            Console.WriteLine($"{MenuHandler.vTab}Tryck på valfri tangent för att återgå till huvudmenyn...");
            Console.ReadKey();
        }
        internal static Vehicle AddCar(Garage garage)
        {
            Console.Write($"{MenuHandler.vTab}Registreringsnummer: ");
            string reg = ReadRegnumInput(garage, VType.Car);
            Console.Write($"{MenuHandler.vTab}Färg: ");
            string? color = Console.ReadLine();
            Console.Write($"{MenuHandler.vTab}Vikt: ");
            int weight = int.TryParse(Console.ReadLine(), out int w) ? w : 0;
            Console.Write($"{MenuHandler.vTab}Längd: ");
            int length = int.TryParse(Console.ReadLine(), out int l) ? l : 0;
            Console.Write($"{MenuHandler.vTab}Antal dörrar: ");
            int doors = int.TryParse(Console.ReadLine(), out int d) ? d : 0;
            Vehicle vehicle = new Car(reg.ToString(), color ?? string.Empty, weight, length, 4, doors);
            garage.AddVehicle(vehicle);
            return vehicle;
        }
        internal static Vehicle AddBus(Garage garage)
        {
            Console.Write($"{MenuHandler.vTab}Registreringsnummer: ");
            string reg = ReadRegnumInput(garage, VType.Bus);
            Console.Write($"{MenuHandler.vTab}Färg: ");
            string? color = Console.ReadLine();
            Console.Write($"{MenuHandler.vTab}Vikt: ");
            int weight = int.TryParse(Console.ReadLine(), out int w) ? w : 0;
            Console.Write($"{MenuHandler.vTab}Längd: ");
            int length = int.TryParse(Console.ReadLine(), out int l) ? l : 0;
            Console.Write($"{MenuHandler.vTab}Antal säten: ");
            int seats = int.TryParse(Console.ReadLine(), out int s) ? s : 0;
            Vehicle vehicle = new Bus(reg, color ?? string.Empty, weight, length, seats, 6);
            return vehicle;
        }
        internal static Vehicle AddMC(Garage garage)
        {
            Console.Write($"{MenuHandler.vTab}Registreringsnummer: ");
            string reg = ReadRegnumInput(garage, VType.Motorcycle);
            Console.Write($"{MenuHandler.vTab}Färg: ");
            string? color = Console.ReadLine();
            Console.Write($"{MenuHandler.vTab}Vikt: ");
            int weight = int.TryParse(Console.ReadLine(), out int w) ? w : 0;
            Console.Write($"{MenuHandler.vTab}Längd: ");
            int length = int.TryParse(Console.ReadLine(), out int l) ? l : 0;
            Console.Write($"{MenuHandler.vTab}Motorstorlek: ");
            int engineSize = int.TryParse(Console.ReadLine(), out int e) ? e : 0;
            Vehicle vehicle = new Motorcycle(reg, color ?? string.Empty, weight, length, engineSize, 2);
            return vehicle;
        }
        internal static Vehicle AddBoat(Garage garage)
        {
            Console.Write($"{MenuHandler.vTab}Registreringsnummer: ");
            string reg = ReadRegnumInput(garage, VType.Boat);
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
            return vehicle;
        }
        internal static Vehicle AddAirplane(Garage garage)
        {
            Console.Write($"{MenuHandler.vTab}Registreringsnummer: ");
            string reg = ReadRegnumInput(garage, VType.Airplane);
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
            return vehicle;
        }
        internal static string ReadRegnumInput(Garage garage, VType type)
        {
            bool isValid = false;
            string? regNumber;
            do
            {
                regNumber = Console.ReadLine()?.ToUpper();
                switch (type)
                {
                    case VType.Car:
                        if (Regex.IsMatch(regNumber ?? string.Empty, @"^[A-Z]{3} [0-9]{3}$"))
                        {
                            isValid = true;
                        }
                        else
                        {
                            Console.WriteLine("Ogiltigt registreringsnummer. \nFormatet för bil ska vara 3 bokstäver följt av 3 siffror (exempel: ABC 123).");
                        }
                        break;
                    case VType.Bus:
                        if (Regex.IsMatch(regNumber ?? string.Empty, @"^[A-Z]{3} [0-9]{3}$"))
                        {
                            isValid = true;
                        }
                        else
                        {
                            Console.WriteLine("Ogiltigt registreringsnummer. \nFormatet för bil ska vara 3 bokstäver följt av 3 siffror (exempel: ABC 123).");
                        }
                        break;
                    case VType.Motorcycle:
                        if (Regex.IsMatch(regNumber ?? string.Empty, @"^[A-Z]{3} [0-9]{3}$"))
                        {
                            isValid = true;
                        }
                        else
                        {
                            Console.WriteLine("Ogiltigt registreringsnummer. \nFormatet för bil ska vara 3 bokstäver följt av 3 siffror (exempel: ABC 123).");
                        }
                        break;
                    case VType.Boat:
                        if (Regex.IsMatch(regNumber ?? string.Empty, @"^[A-Z]{2}[0-9]{5}$"))
                        {
                            isValid = true;
                        }
                        else
                        {
                            Console.WriteLine("Ogiltigt registreringsnummer. \nFormatet för båt ska vara 2 bokstäver följt av 5 siffror (exempel: AB12345).");
                        }
                        break;
                    case VType.Airplane:
                        if (Regex.IsMatch(regNumber ?? string.Empty, @"SE-[A-Z]{3}$"))
                        {
                            isValid = true;
                        }
                        else
                        {
                            Console.WriteLine("Formatet för flygplan ska vara SE- följt av 3 bokstäver (exempel: SE-ABC).");
                        }
                        break;
                    default:
                        break;
                }
                if (CheckUniqNumber(garage, regNumber))
                {
                    Console.WriteLine("Det finns redan ett fordon med detta registreringsnummer.\n Försök igen:");
                    isValid = false;
                }
            } while (!isValid);

            return regNumber ?? string.Empty;
        }
        internal static string GenerateRandom()
        {
            Random random = new Random();

            //string[] colors = { "Röd", "Blå", "Grön", "Svart", "Vit", "Gul", "Silver" };

            string letter = "SE-";
            int number = random.Next(1, 26);
            for (int i = 0; i < 3; i++)
            {
                letter += (((char)random.Next('A', 'Z' + 1)).ToString());
            }
            return letter;
        }
        internal static void ListNumberOf(Garage garage, int val)
        {
            VType type = (VType)val;
            int count = 0;
            for (int i = 0; i < garage.Vehicles.Length; i++)
            {
                if (garage.Vehicles[i] != null)
                {
                    if (type.ToString() == garage.Vehicles[i].Type)
                    {
                        Console.WriteLine(garage.Vehicles[i].Type + " nr: " + garage.Vehicles[i].Uuid);
                        count++;
                    }
                }
            }
            Console.WriteLine("Total number of " + type.ToString() + ": " + count);
        }
        internal static bool CheckUniqNumber(Garage garage, string? regNumber)
        {
            bool output = false;
            for (int i = 0; i < garage.Vehicles.Length; i++)
            {
                if (garage.Vehicles[i]?.Uuid?.ToString() == regNumber?.ToString()) // ?.ToString() added to avoid possible null reference exception
                {
                    output = true;
                }
            }
            return output;
        }
        internal static void RemoveVehicle(Garage garage)
        {

            Console.Write($"{MenuHandler.vTab}Ange registreringsnummer på fordonet du vill ta bort: ");
            string? regNumber = Console.ReadLine()?.ToUpper();
            if (CheckUniqNumber(garage, regNumber))
            {
                garage.RemoveVehicle(regNumber ?? string.Empty);
                Console.WriteLine($"{MenuHandler.vTab}Fordonet med registreringsnummer {regNumber} har tagits bort.");
            }
            else
            {
                Console.WriteLine($"{MenuHandler.vTab}Inget fordon med registreringsnummer {regNumber} hittades i garaget.");
            }
        }
        internal static void RemoveVehicleById(Garage garage)
        {
            Console.Write($"{MenuHandler.vTab}Ange Id på fordonet du vill ta bort: ");
            string? idInput = Console.ReadLine();
            if (int.TryParse(idInput, out int id))
            {
                if (id >= 0 && id < garage.Vehicles.Length)
                {
                    if (garage.Vehicles[id] != null)
                    {
                        string? regNumber = garage.Vehicles[id]?.Uuid;
                        garage.RemoveVehicle(regNumber ?? string.Empty);
                        Console.WriteLine($"{MenuHandler.vTab}Fordonet med Id {id} har tagits bort.");
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

        internal static void ShowAllVehicles(Garage garage)
        {
            Console.Clear();
            Console.WriteLine(" * Garage 1.0 *");
            Console.WriteLine(MenuHandler.line30);
            Console.WriteLine("Alla fordon i garaget:");
            Console.WriteLine(MenuHandler.line30);
            for (int i = 0; i < garage.Vehicles.Length; i++)
            {
                if (garage.Vehicles[i] != null)
                {
                    Console.WriteLine(garage.Vehicles[i].ToString2());
                }
            }
            Console.WriteLine($"{MenuHandler.vTab}Tryck på valfri tangent för att återgå till huvudmenyn...");
            Console.ReadKey();
        }

        internal static void ShowVehicleById(Garage garage)
        {
            Console.Write($"{MenuHandler.vTab}Ange Id på fordonet du vill visa: ");
            string? idInput = Console.ReadLine();
            if (int.TryParse(idInput, out int id))
            {
                if (id >= 0 && id < garage.Vehicles.Length)
                {
                    if (garage.Vehicles[id] != null)
                    {
                        Console.WriteLine(garage.Vehicles[id].ToString2());
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
        }
    }
}
