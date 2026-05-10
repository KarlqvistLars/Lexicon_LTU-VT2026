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
            return $"{MenuHandler.vTab}Flygplan nr: {Uuid}\n{MenuHandler.vTab}Färg: {Color}\n{MenuHandler.vTab}Vikt: {Whight} Kg\n{MenuHandler.vTab}Längd: {Length} m\n{MenuHandler.vTab}Lyftkapacitet: {LiftCapacity} kg\n{MenuHandler.vTab}Vingspann: {WingSpan} m\n{MenuHandler.vTab}Passagerare: {Passengers} st\n";
        }
        //public string ToString2()
        //{
        //    return $"Flygplan nr: {Uuid}\n{MenuHandler.vTab}Färg: {Color}\n{MenuHandler.vTab}Vikt: {Whight} Kg\n{MenuHandler.vTab}Längd: {Length} m\n{MenuHandler.vTab}Lyftkapacitet: {LiftCapacity} kg\n{MenuHandler.vTab}Vingspann: {WingSpan} m\n{MenuHandler.vTab}Passagerare: {Passengers} st\n";
        //}
    }
}