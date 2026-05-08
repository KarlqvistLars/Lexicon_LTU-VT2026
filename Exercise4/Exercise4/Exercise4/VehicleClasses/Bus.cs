using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise4
{
    public class Bus : Vehicle
    {
        private int _numberOfSeats;
        private int _wheels;

        public Bus(int uuid, string color, int whight, int length, int numberOfSeats, int wheels)
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
            return $"Buss nr: {Uuid}\n  Färg: {Color}\n  Hjul: {Wheels} st\n  Vikt: {Whight} Kg\n  Längd: {Length} m\n  Antal sittplatser: {NumberOfSeats} st\n";
        }
    }
}