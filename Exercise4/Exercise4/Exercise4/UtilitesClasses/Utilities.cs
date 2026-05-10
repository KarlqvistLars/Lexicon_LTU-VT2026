using System.Text.RegularExpressions;

namespace Exercise4.UtilitesClasses
{
    static public class Utilities
    {
        static public string line30 { get; } = "==============================";
        static string e30 { get; } = "                              ";
        static public string vTab { get; } = "   ";
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
        internal static void ShowHeader(string title)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{vTab}* ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Garage 1.0");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" * ");
            Console.ResetColor();
            Console.WriteLine($"{line30}{line30}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{vTab}{title}");
            Console.ResetColor();
            Console.WriteLine($"{line30}{line30}");
        }
    }
}
