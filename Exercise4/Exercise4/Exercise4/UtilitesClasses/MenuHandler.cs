using System.Text.RegularExpressions;

namespace Exercise4.UtilitesClasses
{

    static public class MenuHandler
    {
        const string line30 = "==============================";
        const string e30 = "                              ";
        const string vTab = "   ";
        static bool running = true;
        static int choice = 0;
        public static bool StartGarage(int garageSize)
        {
            Garage garage = new Garage(garageSize);
            ShowMenu(0, garage);
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
                        if (vehicleToAdd != null && vehicleToAdd.Uuid != null)
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
                        ShowMenu(0, garage);
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
        public static Vehicle ShowMenu(int option, Garage garage)
        {
            Vehicle vehicle = new Vehicle();
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
                    Console.WriteLine("1. Visa alla.                  ");
                    Console.WriteLine("2. Visa alla av typ?          ");
                    Console.WriteLine("0. Tillbaka                   ");
                    Console.WriteLine("                              ");
                    Console.WriteLine("                              ");
                    Console.WriteLine(e30);
                    Console.WriteLine(e30);
                    Console.Write("Gör ert val: ");
                    ShowSubMenu3(int.TryParse(Console.ReadLine(), out menuval) ? menuval : 0, garage);
                    break;
            }
            return vehicle;
        }
        static public Vehicle ShowSubMenu1(int option, Garage garage)
        {
            Vehicle vehicle = new();
            Console.Clear();
            switch (option)
            {
                case 0:
                    ShowMenu(0, garage);
                    break;
                case 1:
                    Console.WriteLine(" * Garage 1.0 *               ");
                    Console.WriteLine(line30);
                    Console.WriteLine(vTab + "Lägg till fordon           ");
                    Console.WriteLine(vTab + "** Bil **                  ");
                    vehicle = GarageManager.AddCar();
                    break;
                case 2:
                    Console.WriteLine(" * Garage 1.0 *               ");
                    Console.WriteLine(line30);
                    Console.WriteLine(vTab + "Lägg till fordon           ");
                    Console.WriteLine(vTab + "** Buss **                 ");
                    vehicle = GarageManager.AddBus();
                    break;
                case 3:
                    Console.WriteLine(" * Garage 1.0 *               ");
                    Console.WriteLine(line30);
                    Console.WriteLine(vTab + "Lägg till fordon           ");
                    Console.WriteLine(vTab + "** Motorcykel **           ");
                    vehicle = GarageManager.AddMC();
                    break;
                case 4:
                    Console.WriteLine(" * Garage 1.0 *               ");
                    Console.WriteLine(line30);
                    Console.WriteLine(vTab + "Lägg till fordon           ");
                    Console.WriteLine(vTab + "** Båt **                  ");
                    vehicle = GarageManager.AddBoat();
                    break;
                case 5:
                    Console.WriteLine(" * Garage 1.0 *               ");
                    Console.WriteLine(line30);
                    Console.WriteLine(vTab + "Lägg till fordon           ");
                    Console.WriteLine(vTab + "** Flygplan **             ");
                    vehicle = GarageManager.AddAirplane();
                    break;
                case 6:
                    Console.WriteLine(" * Garage 1.0 *               ");
                    Console.WriteLine(line30);
                    Console.WriteLine(vTab + "Lägg n st slumpade fordon  ");
                    Console.Write(vTab + "Hur många: ");
                    int count = int.TryParse(Console.ReadLine(), out int n) ? n : 0;
                    GarageManager.AddRandomVehicles(count, garage);
                    break;
            }
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
            Console.WriteLine(vTab + "Ta bort fordon           ");
            garage.Vehicles.ToList().ForEach(v => { if (v != null) Console.WriteLine(v.ToString()); });
            Console.WriteLine(line30);
            Console.Write(vTab + "Val regnr att ta bort: ");
            garage.RemoveVehicle(GarageManager.ReadRegnumInput());
            Console.ReadKey();
        }
        static public void ShowSubMenu3(int option, Garage garage)
        {
            Vehicle vehicle = new Vehicle();
            Console.Clear();
            switch (option)
            {
                case 0:
                    ShowMenu(0, garage);
                    break;
                case 1:
                    Console.WriteLine(" * Garage 1.0 *               ");
                    Console.WriteLine(line30);
                    Console.WriteLine(vTab + "Visa alla fordon           ");
                    Console.WriteLine(line30);
                    garage.Vehicles.ToList().ForEach(v => { if (v != null) Console.WriteLine(v.ToString()); });
                    Console.WriteLine(line30);
                    Console.WriteLine(vTab + "Tryck på valfri tangent för att återgå till huvudmenyn...");
                    Console.ReadKey();
                    ShowMenu(0, garage);
                    break;
                case 2:
                    Console.WriteLine(" * Garage 1.0 *               ");
                    Console.WriteLine(line30);
                    Console.WriteLine("1. Bil                        ");
                    Console.WriteLine("2. Buss                       ");
                    Console.WriteLine("3. Motorcykel                 ");
                    Console.WriteLine("4. Båt                        ");
                    Console.WriteLine("5. Flygplan                   ");
                    Console.WriteLine("0. Tillbaka                   ");
                    Console.WriteLine(e30);
                    Console.WriteLine(e30);
                    Console.Write("Gör ert val: ");
                    GarageManager.ListNumberOf(garage, int.TryParse(Console.ReadLine(), out int menuval) ? menuval : 0);
                    break;
                default:
                    break;
            }
        }
    }
}