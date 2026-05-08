using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise4.UtilitesClasses
{
    static public class GarageManager
    {
        public enum VType
        {
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
                        garage.AddVehicle(new Car("ABC" + (i + 100).ToString(), "Röd", 1200, 4, 4, 4));
                        break;
                    case 2:
                        garage.AddVehicle(new Bus("ABC" + (i + 100).ToString(), "Blå", 12000, 12, 48, 6));
                        break;
                    case 3:
                        garage.AddVehicle(new Motorcycle("ABC" + (i + 100).ToString(), "Svart", 140, 2, 900, 2));
                        break;
                    case 4:
                        garage.AddVehicle(new Boat("ABC" + (i + 100).ToString(), "Vit", 1200, 4, 2m, 24.6m, 1200));
                        break;
                    case 5:
                        garage.AddVehicle(new Airplane(GenerateRandom(), "Silver", 15000, 20, 7000, 20, 28));
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(" " + count + "st slumpade fordon har lagts till i garaget.");
            Console.WriteLine("Tryck på valfri tangent för att återgå till huvudmenyn...");
            Console.ReadKey();
        }
        internal static Vehicle AddCar()
        {
            Console.Write("   Registreringsnummer: ");
            string reg = ReadRegnumInput();
            Console.Write("   Färg: ");
            string? color = Console.ReadLine();
            Console.Write("   Vikt: ");
            int weight = int.TryParse(Console.ReadLine(), out int w) ? w : 0;
            Console.Write("   Längd: ");
            int length = int.TryParse(Console.ReadLine(), out int l) ? l : 0;
            Console.Write("   Antal dörrar: ");
            int doors = int.TryParse(Console.ReadLine(), out int d) ? d : 0;
            Vehicle vehicle = new Car(reg.ToString(), color ?? string.Empty, weight, length, 4, doors);
            return vehicle;
        }
        internal static Vehicle AddBus()
        {
            Console.Write("   Registreringsnummer: ");
            string reg = ReadRegnumInput();
            Console.Write("   Färg: ");
            string? color = Console.ReadLine();
            Console.Write("   Vikt: ");
            int weight = int.TryParse(Console.ReadLine(), out int w) ? w : 0;
            Console.Write("   Längd: ");
            int length = int.TryParse(Console.ReadLine(), out int l) ? l : 0;
            Console.Write("   Antal säten: ");
            int seats = int.TryParse(Console.ReadLine(), out int s) ? s : 0;
            Vehicle vehicle = new Bus(reg, color ?? string.Empty, weight, length, seats, 6);
            return vehicle;
        }
        internal static Vehicle AddMC()
        {
            Console.Write("   Registreringsnummer: ");
            string reg = ReadRegnumInput();
            Console.Write("   Färg: ");
            string? color = Console.ReadLine();
            Console.Write("   Vikt: ");
            int weight = int.TryParse(Console.ReadLine(), out int w) ? w : 0;
            Console.Write("   Längd: ");
            int length = int.TryParse(Console.ReadLine(), out int l) ? l : 0;
            Console.Write("   Motorstorlek: ");
            int engineSize = int.TryParse(Console.ReadLine(), out int e) ? e : 0;
            Vehicle vehicle = new Motorcycle(reg, color ?? string.Empty, weight, length, engineSize, 2);
            return vehicle;
        }
        internal static Vehicle AddBoat()
        {
            Console.Write("   Registreringsnummer: ");
            string reg = ReadRegnumInput();
            Console.Write("   Färg: ");
            string? color = Console.ReadLine();
            Console.Write("   Vikt: ");
            int weight = int.TryParse(Console.ReadLine(), out int w) ? w : 0;
            Console.Write("   Längd: ");
            int length = int.TryParse(Console.ReadLine(), out int l) ? l : 0;
            Console.Write("   Max vattendjup: ");
            int maxDepth = int.TryParse(Console.ReadLine(), out int d) ? d : 0;
            Console.Write("   Max hastighet: ");
            int maxSpeed = int.TryParse(Console.ReadLine(), out int s) ? s : 0;
            Console.Write("   Deplacement: ");
            int deplacement = int.TryParse(Console.ReadLine(), out int depl) ? depl : 0;
            Vehicle vehicle = new Boat(reg, color ?? string.Empty, weight, length, maxDepth, maxSpeed, deplacement);
            return vehicle;
        }
        internal static Vehicle AddAirplane()
        {
            Console.Write("   Registreringsnummer: ");
            string reg = ReadFlpBetekcningInput();
            Console.Write("   Färg: ");
            string? color = Console.ReadLine();
            Console.Write("   Vikt: ");
            int weight = int.TryParse(Console.ReadLine(), out int w) ? w : 0;
            Console.Write("   Längd: ");
            int length = int.TryParse(Console.ReadLine(), out int l) ? l : 0;
            Console.Write("   Vingbredd: ");
            int wSpan = int.TryParse(Console.ReadLine(), out int ws) ? ws : 0;
            Console.Write("   Lyftkapacitet: ");
            int liftCapacity = int.TryParse(Console.ReadLine(), out int lc) ? lc : 0;
            Console.Write("   Antal passagerare: ");
            int passengers = int.TryParse(Console.ReadLine(), out int p) ? p : 0;
            Vehicle vehicle = new Airplane(reg, color ?? string.Empty, weight, length, liftCapacity, wSpan, passengers);
            return vehicle;
        }
        internal static string ReadRegnumInput()
        {
            bool isValid = false;
            string? regNumber;
            do
            {
                regNumber = Console.ReadLine()?.ToUpper();
                isValid = Regex.IsMatch(regNumber ?? string.Empty, @"^[A-Z]{3}[0-9]{3}$");
                if (!isValid)
                {
                    Console.WriteLine("Ogiltigt registreringsnummer. \nFormatet ska vara 3 bokstäver följt av 3 siffror \n(exempel: ABC123). Försök igen:");
                }
            } while (!isValid);

            return regNumber ?? string.Empty;
        }
        private static string ReadFlpBetekcningInput()
        {
            bool isValid = false;
            string? regNumber;
            do
            {
                regNumber = Console.ReadLine()?.ToUpper();
                isValid = Regex.IsMatch(regNumber ?? string.Empty, @"SE-[A-Z]{3}$");
                if (!isValid)
                {
                    Console.WriteLine("Ogiltigt registreringsnummer. \nFormatet ska vara SE- följt av 3 bokstäver \n(exempel: SE-ABC). Försök igen:");
                }
            } while (!isValid);

            return regNumber ?? string.Empty;
        }
        static string GenerateRandom()
        {
            Random random = new Random();

            //string[] colors = { "Röd", "Blå", "Grön", "Svart", "Vit", "Gul", "Silver" };

            string letter = "SE-";
            int number = random.Next(1, 26);
            for (int i = 0; i < 3; i++)
            {
                letter += (((char)random.Next('A', 'Z' + 1)).ToString());
            }
            Console.WriteLine(letter);
            return letter;
        }

        internal static void ListNumberOf(Garage garage, int val)
        {
            VType type = (VType)val;
            int count = 0;
            for (int i = 0; i < garage.Vehicles.Length; i++)
            {
                if(type.ToString() == garage.Vehicles[i].Type)
                {
                    Console.WriteLine(garage.Vehicles[i].Type + " nr: " + garage.Vehicles[i].Uuid);
                    count++;
                }
            }
            Console.WriteLine("Total number of " + type.ToString() + ": " + count);
        }
    }
}
