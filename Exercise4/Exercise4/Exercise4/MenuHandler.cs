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
            ShowMenu(0);
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
                        Console.WriteLine("Programmet avslutas...\n\n");
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
                    vehicle = AddCar();
                    break;
                case 2:
                    Console.WriteLine(" * Garage 1.0 *               ");
                    Console.WriteLine(line30);
                    Console.WriteLine("   Lägg till fordon           ");
                    Console.WriteLine("   ** Buss **                 ");
                    vehicle = AddBus();
                    break;
                case 3:
                    Console.WriteLine(" * Garage 1.0 *               ");
                    Console.WriteLine(line30);
                    Console.WriteLine("   Lägg till fordon           ");
                    Console.WriteLine("   ** Motorcykel **           ");
                    vehicle = AddMC();
                    break;
                case 4:
                    Console.WriteLine(" * Garage 1.0 *               ");
                    Console.WriteLine(line30);
                    Console.WriteLine("   Lägg till fordon           ");
                    Console.WriteLine("   ** Båt **                  ");
                    Console.Write("   Registreringsnummer: ");
                    vehicle = AddBoat();
                    break;
                case 5:
                    Console.WriteLine(" * Garage 1.0 *               ");
                    Console.WriteLine(line30);
                    Console.WriteLine("   Lägg till fordon           ");
                    Console.WriteLine("   ** Flygplan **             ");
                    vehicle = AddAirplane();
                    break;
            }

            return vehicle;
        }
        private static Vehicle AddCar()
        {

            Console.Write("   Registreringsnummer: ");
            int reg = int.TryParse(Console.ReadLine(), out int num) ? num : 0;
            Console.Write("   Färg: ");
            string color = Console.ReadLine();
            Console.Write("   Vikt: ");
            int weight = int.TryParse(Console.ReadLine(), out int w) ? w : 0;
            Console.Write("   Längd: ");
            int length = int.TryParse(Console.ReadLine(), out int l) ? l : 0;
            Console.Write("   Antal dörrar: ");
            int doors = int.TryParse(Console.ReadLine(), out int d) ? d : 0;
            Vehicle vehicle = new Car(reg, color, weight, length, 4, doors);
            return vehicle;
        }
        private static Vehicle AddBus()
        {

            Console.Write("   Registreringsnummer: ");
            int reg = int.TryParse(Console.ReadLine(), out int num) ? num : 0;
            Console.Write("   Färg: ");
            string color = Console.ReadLine();
            Console.Write("   Vikt: ");
            int weight = int.TryParse(Console.ReadLine(), out int w) ? w : 0;
            Console.Write("   Längd: ");
            int length = int.TryParse(Console.ReadLine(), out int l) ? l : 0;
            Console.Write("   Antal säten: ");
            int seats = int.TryParse(Console.ReadLine(), out int s) ? s : 0;
            Vehicle vehicle = new Bus(reg, color, weight, length, seats, 6);
            return vehicle;
        }
        private static Vehicle AddMC()
        {
            Console.Write("   Registreringsnummer: ");
            int reg = int.TryParse(Console.ReadLine(), out int num) ? num : 0;
            Console.Write("   Färg: ");
            string color = Console.ReadLine();
            Console.Write("   Vikt: ");
            int weight = int.TryParse(Console.ReadLine(), out int w) ? w : 0;
            Console.Write("   Längd: ");
            int length = int.TryParse(Console.ReadLine(), out int l) ? l : 0;
            Console.Write("   Motorstorlek: ");
            int engineSize = int.TryParse(Console.ReadLine(), out int e) ? e : 0;
            Vehicle vehicle = new Motorcycle(reg, color, weight, length, engineSize, 2);
            return vehicle;
        }
        private static Vehicle AddBoat()
        {
            Console.Write("   Registreringsnummer: ");
            int reg = int.TryParse(Console.ReadLine(), out int num) ? num : 0;
            Console.Write("   Färg: ");
            string color = Console.ReadLine();
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
            Vehicle vehicle = new Boat(reg, color, weight, length, maxDepth, maxSpeed, deplacement);
            return vehicle;
        }
        private static Vehicle AddAirplane()
        {
            Console.Write("   Registreringsnummer: ");
            int reg = int.TryParse(Console.ReadLine(), out int num) ? num : 0;
            Console.Write("   Färg: ");
            string color = Console.ReadLine();
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
            Vehicle vehicle = new Airplane(reg, color, weight, length, liftCapacity, wSpan, passengers);
            return vehicle;
        }

        public static void ShowAddedVehicle(Vehicle vehicle)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Följande fordon har lagts till");
            Console.WriteLine("==============================");
            Console.WriteLine(vehicle.ToString());
            Console.WriteLine(line30);
            Console.WriteLine("Tryck på valfri tangent för att återgå till huvudmenyn...");

        }
    }
}