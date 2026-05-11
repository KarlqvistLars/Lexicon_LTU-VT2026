using Exercise3.UtilitesClasses;

namespace Exercise3
{
    public class Vehicle
    {
        private string? _uuid;
        private string? _color;
        private int _weight;
        private int _length;
        private string? _type;
        public Vehicle()
        {
            _color = string.Empty;
            _type = string.Empty;
        }
        public Vehicle(string uuid, string color, int weight, int length, string type = "")
        {
            this._uuid = uuid;
            this._color = color;
            this._weight = weight;
            this._length = length;
            this._type = type;
        }
        public string? Uuid
        {
            get => _uuid;
            set => _uuid = value;
        }
        public string Color
        {
            get => _color ?? string.Empty;
            set => _color = value;
        }
        public int Weight
        {
            get => _weight;
            set => _weight = value;
        }
        public int Length
        {
            get => _length;
            set => _length = value;
        }
        public string Type
        {
            get => _type ?? string.Empty;
        }
        public virtual string ToString2()
        {
            return $"{Utilities.line30}{Utilities.line30}\n{Utilities.vTab}{Type} nr: {Uuid}\n{Utilities.vTab}Färg: {Color}\tVikt: {Weight} Kg\t{Utilities.vTab}Längd: {Length} m";
        }
        public override string ToString()
        {
            return $"{Type} nr: {Uuid}\n  Färg: {Color}\n  Vikt: {Weight} Kg\n  Längd: {Length} m\n";
        }
    }
}