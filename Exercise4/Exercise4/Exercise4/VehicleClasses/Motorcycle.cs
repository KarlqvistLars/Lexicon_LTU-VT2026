using Exercise4.UtilitesClasses;

namespace Exercise4
{
    public class Motorcycle : Vehicle
    {
        private int _cubicInch;
        private int _wheels = 2;
        public Motorcycle(string uuid, string color, int whight, int length, int cubicInch, int wheels)
            : base(uuid, color, whight, length, "Motorcycle")
        {
            this._cubicInch = cubicInch;
            this._wheels = wheels;
        }
        public int CubicInch
        {
            get => _cubicInch;
            set => _cubicInch = value;
        }
        public int Wheels
        {
            get => _wheels;
            set => _wheels = value;
        }

        public override string ToString()
        {
            return $"{Utilities.vTab}Motorcykel nr: {Uuid}\n{Utilities.vTab}Färg: {Color}\n{Utilities.vTab}Vikt: {Whight} Kg\n{Utilities.vTab}Längd: {Length} m\n{Utilities.vTab}Kubik: {CubicInch} cc\n";
        }
        string thisType = "Motorcykel";
        public override string ToString2()
        {
            return $"{Utilities.line30}{Utilities.line30}\n{Utilities.vTab}{thisType} nr: {Uuid}\n{Utilities.vTab}Färg: {Color}\tVikt: {Whight} Kg\tLängd: {Length} m\n{Utilities.vTab}Specifikt för {thisType}:\n{Utilities.vTab}Kubik: {CubicInch} cc";
        }
    }
}