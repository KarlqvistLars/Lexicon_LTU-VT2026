using Exercise4.UtilitesClasses;

namespace Exercise4
{
    public class Airplane : Vehicle
    {
        int liftCapacity;
        decimal wingSpan;
        private int passengers;
        public Airplane(string uuid, string color, int whight, int length, int liftCapacity, decimal wingSpan, int passengers)
            : base(uuid, color, whight, length, "Airplane")
        {
            this.liftCapacity = liftCapacity;
            this.wingSpan = wingSpan;
            this.passengers = passengers;
        }
        public int LiftCapacity
        {
            get => liftCapacity;
            set => liftCapacity = value;
        }
        public decimal WingSpan
        {
            get => wingSpan;
            set => wingSpan = value;
        }
        public int Passengers
        {
            get => passengers;
            set => passengers = value;
        }
        public override string ToString()
        {
            return $"{Utilities.vTab}Flygplan nr: {Uuid}\n{Utilities.vTab}Färg: {Color}\n{Utilities.vTab}Vikt: {Whight} Kg\n{Utilities.vTab}Längd: {Length} m\n{Utilities.vTab}Lyftkapacitet: {LiftCapacity} kg\n{Utilities.vTab}Vingspann: {WingSpan} m\n{Utilities.vTab}Passagerare: {Passengers} st\n";
        }
        string thisType = "Flygplan";
        public override string ToString2()
        {
            return $"{Utilities.line30}{Utilities.line30}\n{Utilities.vTab}{thisType} nr: {Uuid}\n{Utilities.vTab}Färg: {Color}\tVikt: {Whight} Kg\tLängd: {Length} m\n{Utilities.vTab}Specifikt för {thisType}:\n{Utilities.vTab}Lyftkapacitet: {LiftCapacity} kg\tVingspann: {WingSpan} m\tPassagerare: {Passengers} st";
        }
    }
}