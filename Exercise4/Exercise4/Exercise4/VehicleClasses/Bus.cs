using Exercise4.UtilitesClasses;

namespace Exercise4
{
    public class Bus : Vehicle
    {
        private int _numberOfSeats;
        private int _wheels;

        public Bus(string uuid, string color, int whight, int length, int numberOfSeats, int wheels)
            : base(uuid, color, whight, length, "Bus")
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
            return $"{Utilities.vTab}Buss nr: {Uuid}\n{Utilities.vTab}Färg: {Color}\n{Utilities.vTab}Vikt: {Whight} Kg\n{Utilities.vTab}Längd: {Length} m\n{Utilities.vTab}Antal sittplatser: {NumberOfSeats} st\n{Utilities.vTab}Hjul: {Wheels} st";
        }

        //public string ToString2()
        //{
        //    return $"{MenuHandler.line30}{MenuHandler.line30}\n{MenuHandler.vTab}Buss nr: {Uuid}\tFärg: {Color}\tVikt: {Whight} Kg\t{MenuHandler.vTab}Längd: {Length} m\tAntal sittplatser: {NumberOfSeats} st\t{MenuHandler.vTab}Hjul: {Wheels} st\n";
        //}
    }
}