using Exercise4.UtilitesClasses;

namespace Exercise4
{
    public class Bus : Vehicle
    {
        private int _numberOfSeats;
        private int _wheels;

        public Bus(string uuid, string color, int weight, int length, int numberOfSeats, int wheels)
            : base(uuid, color, weight, length, "Bus")
        {
            this._numberOfSeats = numberOfSeats;
            this._wheels = wheels;
        }

        public int Wheels
        {
            get => _wheels;
            set => _wheels = value;
        }

        public int NumberOfSeats
        {
            get => _numberOfSeats;
            set => _numberOfSeats = value;
        }

        public override string ToString()
        {
            return $"{Utilities.vTab}Buss nr: {Uuid}\n{Utilities.vTab}Färg: {Color}\n{Utilities.vTab}Vikt: {Weight} Kg\n{Utilities.vTab}Längd: {Length} m\n{Utilities.vTab}Antal sittplatser: {NumberOfSeats} st\n{Utilities.vTab}Hjul: {Wheels} st";
        }
        string thisType = "Buss";
        public override string ToString2()
        {
            return $"{Utilities.vTab}\u001b[4m{thisType} nr: {Uuid}\u001b[0m\n{Utilities.vTab}Färg: {Color}\tVikt: {Weight} Kg\tLängd: {Length} m\n{Utilities.vTab}\u001b[4mSpecifikt för {thisType}:\u001b[0m\n{Utilities.vTab}Antal sittplatser: {NumberOfSeats} st, Hjul: {Wheels} st";
        }

        public string ToStringTypeSpec()
        {
            return $"{this.Type}:[Wheels:{Wheels},NumberOfSeats:{NumberOfSeats}]";
        }
    }
}