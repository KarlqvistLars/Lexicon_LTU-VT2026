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
                choice = int.TryParse(Console.ReadLine(), out int menuval) ? menuval : 10;
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Programmet avslutas...\n\n");
                        running = false;
                        break;
                    case 1:
                        Vehicle vehicleToAdd = ShowMenu(1, garage);
                        if (vehicleToAdd != null)
                        {
                            garage.AddVehicle(vehicleToAdd);
                            ShowAddedVehicle(vehicleToAdd);
                            Console.ReadKey();
                        }
                        ShowMenu(0, garage);
                        break;
                    case 2:
                        //Vehicle vehicleToRemove = 
                            ShowMenu(2, garage);
                        //if (vehicleToRemove != null)
                        //{
                        //    garage.RemoveVehicle(vehicleToRemove.Uuid);
                        //    Console.ReadKey();
                        //}
                        //else
                        //{
                        //    Console.WriteLine("   INGET  FORDON hAR tagist bort");
                        //    Console.ReadKey();
                        //}
                        ShowMenu(0);
                        break;
                    case 3:
                        ShowMenu(3, garage);
                        Console.ReadKey();
                        ShowMenu(0, garage);
                        break;
                    case 10:
                        // Huvudmeny
                        ShowMenu(0, garage);
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
                    Console.WriteLine("0. Avsluta");
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
                    Console.WriteLine("6. Slumässigt");
                    Console.WriteLine("0. Tillbaka                   ");
                    Console.WriteLine(e30);
                    Console.Write("Gör ert val: ");
                    vehicle = ShowSubMenu1(int.TryParse(Console.ReadLine(), out int menuval) ? menuval : 0, garage);
                    break;
                case 2:
                    Console.WriteLine(" * Garage 1.0 *               ");
                    Console.WriteLine(line30);
                    Console.WriteLine("   Ta bort fordon             ");
                    Console.WriteLine("1. Ta bort Reg nr?            ");
                    Console.WriteLine("2. Ta bort  ???               ");
                    Console.WriteLine("0. Tillbaka                   ");
                    Console.WriteLine("                              ");
                    Console.WriteLine("                              ");
                    Console.WriteLine(e30);
                    Console.WriteLine(e30);
                    Console.Write("Gör ert val: ");
                    ShowSubMenu2(int.TryParse(Console.ReadLine(), out menuval) ? menuval : 0, garage);
                    break;
                case 3:
                    Console.WriteLine(" * Garage 1.0 *               ");
                    Console.WriteLine(line30);
                    Console.WriteLine("   Visa fordon                ");
                    Console.WriteLine("1. Visa alla                  ");
                    Console.WriteLine("2. Visa typ?                  ");
                    Console.WriteLine("0. Tillbaka                   ");
                    Console.WriteLine("                              ");
                    Console.WriteLine("                              ");
                    Console.WriteLine(e30);
                    Console.WriteLine(e30);
                    Console.Write("Gör ert val: ");
                    vehicle = ShowSubMenu3(int.TryParse(Console.ReadLine(), out menuval) ? menuval : 0, garage);
                    break;
            }
            return vehicle;
        }
        static public Vehicle ShowSubMenu1(int option, Garage garage)
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
                    vehicle = AddBoat();
                    break;
                case 5:
                    Console.WriteLine(" * Garage 1.0 *               ");
                    Console.WriteLine(line30);
                    Console.WriteLine("   Lägg till fordon           ");
                    Console.WriteLine("   ** Flygplan **             ");
                    vehicle = AddAirplane();
                    break;
                case 6:
                    Console.WriteLine(" * Garage 1.0 *               ");
                    Console.WriteLine(line30);
                    Console.WriteLine("   Lägg n st slumpade fordon  ");
                    Console.Write("   Hur många: ");
                    int count = int.TryParse(Console.ReadLine(), out int n) ? n : 0;
                    AddRandomVehicles(count, garage);
                    break;
            }

            return vehicle;
        }
        private static void AddRandomVehicles(int count, Garage garage)
        {
            for (int i = 0; i < count; i++)
            {
                Random random = new Random();
                int number = random.Next(1, 6);

                switch (number) 
                { 
                    case 1:
                        garage.AddVehicle(new Car(i+100, "Röd", 1200, 4, 4, 4));
                        break;
                    case 2:
                        garage.AddVehicle(new Bus(i + 100, "Blå", 12000, 12, 48, 6));
                        break;
                    case 3:
                        garage.AddVehicle(new Motorcycle(i + 100, "Svart", 140, 2, 900, 2));
                        break;
                    case 4:
                        garage.AddVehicle(new Boat(i + 100, "Vit", 1200, 4, 2m, 24.6m, 1200));
                        break;
                    case 5:
                        garage.AddVehicle(new Airplane(i + 100, "Silver", 15000, 20, 7000, 20, 28));
                        break;
                    default:
                        break;
                } 
            }
            Console.WriteLine("   " + count + " slumpade fordon har lagts till i garaget.");
            Console.WriteLine("Tryck på valfri tangent för att återgå till huvudmenyn...");
            Console.ReadKey();
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
        static public void ShowSubMenu2(int option, Garage garage)
        {
            Console.Clear();
            Console.WriteLine(" * Garage 1.0 *               ");
            Console.WriteLine(line30);
            Console.WriteLine("   Ta bort fordon           ");
            garage.Vehicles.ToList().ForEach(v => { if (v != null) Console.WriteLine(v.ToString()); });
            Console.WriteLine(line30);
            Console.Write("Val regnr att ta bort: "); 
            garage.RemoveVehicle(int.TryParse(Console.ReadLine(), out int menuval) ? menuval : 0);
            Console.ReadKey();
        }
        static public Vehicle ShowSubMenu3(int option, Garage garage)
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
                    Console.WriteLine("   Visa alla fordon           ");
                    Console.WriteLine(line30);
                    garage.Vehicles.ToList().ForEach(v => { if (v != null) Console.WriteLine(v.ToString()); });
                    Console.WriteLine(line30);
                    Console.WriteLine("   Tryck på valfri tangent för att återgå till huvudmenyn...");
                    Console.ReadKey();
                    ShowMenu(0);
                    break;
                case 2:
                    Console.WriteLine(" * Garage 1.0 *               ");
                    Console.WriteLine(line30);
                    Console.WriteLine("   Lägg till fordon           ");
                    Console.WriteLine("   ** Buss **                 ");
                    vehicle = AddBus();
                    break;
                default:
                    break;
            }
            return null;
        }
    }
}