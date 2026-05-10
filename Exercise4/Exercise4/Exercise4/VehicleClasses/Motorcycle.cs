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
            return $"{MenuHandler.vTab}Motorcykel nr: {Uuid}\n{MenuHandler.vTab}Färg: {Color}\n{MenuHandler.vTab}Vikt: {Whight} Kg\n{MenuHandler.vTab}Längd: {Length} m\n{MenuHandler.vTab}Kubik: {CubicInch} cc\n";
        }
        //public string ToString2()
        //{
        //    return $"Motorcykel nr: {Uuid}\n{MenuHandler.vTab}Färg: {Color}\n{MenuHandler.vTab}Vikt: {Whight} Kg\n{MenuHandler.vTab}Längd: {Length} m\n{MenuHandler.vTab}Kubik: {CubicInch} cc\n";
        //}
    }
}