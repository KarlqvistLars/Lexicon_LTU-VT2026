using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise4
{
    public class Vehicle
    {
        private int _uuid;
        private string _color;
        private int _wheels;
        private int _whight;
        private int _length;
       
        public Vehicle(int uuid, string color, int wheels, int whight, int length)
        {
            this._uuid = uuid;
            this._color = color;
            this._wheels = wheels;
            this._whight = whight;
            this._length = length   ;
        }

        public int Uuid
        {
            get => _uuid;
            set => _uuid = value;
        }

        public string Color
        {
            get => _color;
            set => _color = value;
        }

        public int Wheels
        {
            get => _wheels;
            set => _wheels = value;
        }

        public int Whight
        {
            get => _whight;
            set => _whight = value;
        }

        public int Length
        {
            get => _length;
            set => _length = value;
        }

        public override string ToString()
        {
            return $"Vehicle [Uuid={_uuid}, Color={_color}, Wheels={_wheels}, Whight={_whight}, Length={_length}]";
        }

    }
}