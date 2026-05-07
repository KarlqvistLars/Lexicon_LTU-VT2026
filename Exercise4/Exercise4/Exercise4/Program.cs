namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add( new Vehicle(1, "Red", 4, 1000, 4));
            vehicles.Add( new Car(2, "Blue", 4, 1200, 5, 4));
            vehicles.Add( new Motorcycle(3, "Green", 2, 500, 2, 600));
            vehicles.Add( new Bus(4, "Yellow", 6, 3000, 10, 40));
            vehicles.Add( new Boat(5, "White", 0, 2000, 15, 100, 20, 50, 500));
            vehicles.Add( new Airplane(6, "Black", 4, 1500, 4, 200, 30.5m));

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.ToString());
            }
        }
    }
}
