using FireMond.Inner.Office.Core.DML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise4
{
    static public class MenuHandler
    {
        const string line30 = "==============================";
        const string e30 = "                              ";
        static bool running = true;
        static int choice = 0;
        public static bool StartGarage(int garageSize)
        {
            Garage garage = new Garage(garageSize);
            do
            {
                choice = int.TryParse(Console.ReadLine(), out int menuval) ? menuval : 0;
                switch (choice)

                {
                    case 1:
                        Vehicle vehicleToAdd = ShowMenu(1);
                        if (vehicleToAdd != null)
                        {
                            garage.AddVehicle(vehicleToAdd);
                            ShowAddedVehicle(vehicleToAdd);
                            Console.ReadKey();
                            ShowMenu(0);
                        }
                        break;
                    case 2:

                        break;
                    case 3:
                        ShowMenu(3, garage);
                        Console.ReadKey();
                        ShowMenu(0);
                        break;
                    case 4:
                        Console.WriteLine("Tack för att du använde Garage 1.0! Programmet avslutas.");
                        running = false;
                        break;
                    default:
                        break;
                }
            } while (running);
            return true;
        }
        public static Vehicle ShowMenu(int option, Garage garage=null)
        {
            Vehicle vehicle = null;
            Console.Clear();
            switch (option)
            {
                case 0:
                    Console.WriteLine(" * Garage 1.0 *               ");
                    Console.WriteLine("==============================");
                    Console.WriteLine("1. Lägg till fordon");
                    Console.WriteLine("2. Ta bort fordon");
                    Console.WriteLine("3. Visa fordon");
                    Console.WriteLine("4. Avsluta");
                    Console.WriteLine(e30);
                    Console.WriteLine(e30);
                    Console.WriteLine(e30);
                    Console.WriteLine(e30);
                    Console.Write("Gör ert val: ");
                    break;
                case 1:
                    Console.WriteLine(" * Garage 1.0 *               ");
                    Console.WriteLine(line30);
                    Console.WriteLine("   Lägg till fordon           ");
                    Console.WriteLine("1. Bil                        ");
                    Console.WriteLine("2. Buss                       ");
                    Console.WriteLine("3. Motorcykel                 ");
                    Console.WriteLine("4. Båt                        ");
                    Console.WriteLine("5. Flygplan                   ");
                    Console.WriteLine(e30);
                    Console.WriteLine(e30);
                    Console.Write("Gör ert val: ");
                    vehicle = ShowSubMenu2(int.TryParse(Console.ReadLine(), out int menuval) ? menuval : 0);
                    break;
                case 2:
                    Console.WriteLine(" * Garage 1.0 *               ");
                    Console.WriteLine(line30);
                    Console.WriteLine("   Ta bort fordon             ");
                    vehicle = ShowSubMenu2(int.TryParse(Console.ReadLine(), out menuval) ? menuval : 0);
                    break;
                case 3:
                    Console.WriteLine(" * Garage 1.0 *               ");
                    Console.WriteLine(line30);
                    Console.WriteLine("   Visa fordon                ");
                    Console.WriteLine(garage.ToString());
                    Console.WriteLine(e30);
                    Console.WriteLine("Tryck på valfri tangent för att återgå till huvudmenyn...");
                    break;
            }
            return vehicle;
        }
        static public Vehicle ShowSubMenu2(int option)
        {
            Vehicle vehicle = null;
            Console.Clear();
            switch (option)
            {
                case 0:
                    ShowMenu(0);
                    break;
                case 1:
                    Console.WriteLine(" * Garage 1.0 *               ");
                    Console.WriteLine(line30);
                    Console.WriteLine("   Lägg till fordon           ");
                    Console.WriteLine("   ** Bil **                  ");
                    Console.Write("   Registreringsnummer: ");
                    int reg = int.TryParse(Console.ReadLine(), out int num) ? num : 0;
                    Console.Write("   Färg: ");
                    string color = Console.ReadLine();
                    Console.Write("   Vikt: ");
                    int weight = int.TryParse(Console.ReadLine(), out int w) ? w : 0;
                    Console.Write("   Antal dörrar: ");
                    int doors = int.TryParse(Console.ReadLine(), out int d) ? d : 0;
                    vehicle = new Car(reg, color, 4, weight, 4, doors);
                    break;
                case 2:
                    Console.WriteLine(" * Garage 1.0 *               ");
                    Console.WriteLine(line30);
                    Console.WriteLine("   Lägg till fordon           ");
                    Console.WriteLine("   ** Buss **                 ");
                    Console.Write("   Registreringsnummer: ");
                    reg = int.TryParse(Console.ReadLine(), out num) ? num : 0;
                    Console.Write("   Färg: ");
                    color = Console.ReadLine();
                    Console.Write("   Vikt: ");
                    weight = int.TryParse(Console.ReadLine(), out w) ? w : 0;
                    Console.Write("   Antal hjul: ");
                    int seats = int.TryParse(Console.ReadLine(), out d) ? d : 0;
                    vehicle = new Bus(reg, color, 4, weight, 4, seats);
                    break;
                case 3:
                    Console.WriteLine(" * Garage 1.0 *               ");
                    Console.WriteLine(line30);
                    Console.WriteLine("   Lägg till fordon           ");
                    Console.WriteLine("   ** Motorcykel **           ");
                    Console.Write("   Registreringsnummer: ");
                    reg = int.TryParse(Console.ReadLine(), out num) ? num : 0;
                    Console.Write("   Färg: ");
                    color = Console.ReadLine();
                    Console.Write("   Vikt: ");
                    weight = int.TryParse(Console.ReadLine(), out w) ? w : 0;
                    Console.Write("   Antal hjul: ");
                    int cubic = int.TryParse(Console.ReadLine(), out d) ? d : 0;
                    vehicle = new Motorcycle(reg, color, 4, weight, 4, cubic);
                    break;
                case 4:
                    Console.WriteLine(" * Garage 1.0 *               ");
                    Console.WriteLine(line30);
                    Console.WriteLine("   Lägg till fordon           ");
                    Console.WriteLine("   ** Båt **                  ");
                    Console.Write("   Registreringsnummer: ");
                    reg = int.TryParse(Console.ReadLine(), out num) ? num : 0;
                    Console.Write("   Färg: ");
                    color = Console.ReadLine();
                    Console.Write("   Vikt: ");
                    weight = int.TryParse(Console.ReadLine(), out w) ? w : 0;
                    Console.Write("   Deplacement: ");
                    decimal depl = decimal.TryParse(Console.ReadLine(), out decimal dec) ? dec : 0;
                    decimal maxWaterDepth = 1.0m;
                    decimal maxSpeed = 10.0m;
                    decimal boatLength = 10.0m;
                    vehicle = new Boat(reg, color, 4, weight, 4, maxWaterDepth, boatLength, maxSpeed, depl);
                    break;
                case 5:
                    Console.WriteLine(" * Garage 1.0 *               ");
                    Console.WriteLine(line30);
                    Console.WriteLine("   Lägg till fordon           ");
                    Console.WriteLine("   ** Flygplan **             ");
                    Console.Write("   Registreringsnummer: ");
                    reg = int.TryParse(Console.ReadLine(), out num) ? num : 0;
                    Console.Write("   Färg: ");
                    color = Console.ReadLine();
                    Console.Write("   Vikt: ");
                    weight = int.TryParse(Console.ReadLine(), out w) ? w : 0;
                    Console.Write("   Lyftkapacitet: ");
                    int liftCapacity = int.TryParse(Console.ReadLine(), out int lc) ? lc : 0;
                    Console.Write("   Spännvidd: ");
                    decimal wingSpan = decimal.TryParse(Console.ReadLine(), out decimal ws) ? ws : 0;
                    vehicle = new Airplane(reg, color, 4, weight, 4, liftCapacity, wingSpan);
                    break;
            }

            return vehicle;
        }
        public static void ShowAddedVehicle(Vehicle vehicle)
        {
            Console.WriteLine(" * Garage 1.0 *               ");
            Console.WriteLine("==============================");
            Console.WriteLine("Följande fordon har lagts till:");
            Console.WriteLine("==============================");
            Console.WriteLine(vehicle.ToString());
            Console.WriteLine(e30);
            Console.WriteLine("Tryck på valfri tangent för att återgå till huvudmenyn...");

        }
    }
}