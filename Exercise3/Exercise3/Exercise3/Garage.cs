using Exercise3.UtilitesClasses;
using System.Text;

namespace Exercise3
{
    public class Garage
    {
        private static int _capacity;
        private readonly Vehicle[] _vehicles;
        public Garage(int capacity)
        {
            _capacity = capacity;
            _vehicles = new Vehicle[_capacity];
        }
        public Vehicle[] Vehicles
        {
            get => _vehicles;
        }
        static public int Capacity
        {
            get => _capacity;
        }
        public bool AddVehicle(Vehicle vehicle)
        {
            for (int i = 0; i < _capacity; i++)
            {
                if (_vehicles[i] == null || _vehicles[i].Uuid == "")
                {
                    _vehicles[i] = vehicle;
                    return true;
                }
            }
            Console.WriteLine($"{Utilities.vTab}Garage is full, cannot add {vehicle.Type} with UUID: {vehicle.Uuid}");
            return false;
        }
        public void RemoveVehicle(string uuid)
        {
            for (int i = 0; i < _capacity; i++)
            {
                if (_vehicles[i] != null && _vehicles[i].Uuid == uuid)
                {
                    _vehicles[i] = null;
                    return;
                }
            }
            Console.WriteLine("Vehicle with UUID: " + uuid + " not found");
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Garage [Capacity={_capacity}]");
            sb.AppendLine(Utilities.line30);
            if (_vehicles.Length > 0 && _vehicles.Any(v => v != null))
            {
                foreach (var vehicle in _vehicles)
                {
                    if (vehicle != null)
                    {
                        sb.AppendLine(vehicle.ToString());
                    }
                }
            }
            else
            {
                sb.AppendLine("Garaget är tomt.");
            }
            return sb.ToString();
        }
    }
}