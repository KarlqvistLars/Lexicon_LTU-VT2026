namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Garage garage = new Garage(10);
            garage.AddVehicle(new Vehicle(1, "Red", 4, 1000, 4));
            garage.AddVehicle(new Car(2, "Blue", 4, 1200, 5, 4));
            garage.AddVehicle(new Motorcycle(3, "Green", 2, 500, 2, 600));
            garage.AddVehicle(new Bus(4, "Yellow", 6, 3000, 10, 40));
            garage.AddVehicle(new Boat(5, "White", 0, 2000, 15, 100, 20, 50, 500));
            garage.AddVehicle(new Airplane(6, "Black", 4, 1500, 3, 200, 30.5m));
            garage.AddVehicle(new Car(7, "Blue", 4, 1200, 5, 4));
            garage.AddVehicle(new Motorcycle(8, "Green", 2, 500, 2, 600));
            garage.AddVehicle(new Bus(9, "Yellow", 6, 3000, 10, 40));
            garage.AddVehicle(new Boat(10, "White", 0, 2000, 15, 100, 20, 50, 500));
            garage.AddVehicle(new Airplane(11, "Black", 4, 1500, 3, 200, 30.5m));
            garage.AddVehicle(new Car(12, "Blue", 4, 1200, 5, 4));
          
            Console.WriteLine(garage.ToString());

            garage.RemoveVehicle(2);
            garage.RemoveVehicle(2);

            Console.ReadLine();
        }
    }
}
