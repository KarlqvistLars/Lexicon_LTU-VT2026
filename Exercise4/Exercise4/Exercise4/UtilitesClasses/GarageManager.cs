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
